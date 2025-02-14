using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Configuration;
using client.Helpers;
using client.Services.Auth;

namespace client.Network
{
    public class Client
    {
        private static Client? _instance;
        private static readonly object _lock = new object();
        private TcpClient? tcpClient;
        private NetworkStream? networkStream;
        private readonly string serverIp;
        private readonly int serverPort;
        public bool IsConnected => tcpClient?.Connected ?? false && networkStream != null;

        public static Client Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new Client();
                    }
                }
                return _instance;
            }
        }

        private Client()
        {
            serverIp = ConfigurationManager.AppSettings["ServerIP"] ?? "127.0.0.1";
            if (!int.TryParse(ConfigurationManager.AppSettings["ServerPort"], out int port))
            {
                port = 8888;
            }
            serverPort = port;
        }

        public bool Connect()
        {
            try
            {
                Disconnect();

                // Create new TCP client
                tcpClient = new TcpClient();

                // Create connection timeout
                var result = tcpClient.BeginConnect(serverIp, serverPort, null, null);
                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5));

                if (!success)
                {
                    Disconnect();
                    Logger.Write("CONNECTION TIMEOUT", "Failed to connect to server: Connection timed out");
                    return false;
                }


                tcpClient.EndConnect(result);

                // Initialize network stream
                networkStream = tcpClient.GetStream();
                if (networkStream == null)
                {
                    Logger.Write("TCP CLIENT", "Failed to initialize network stream");
                    return false;
                }

                Logger.Write("TCP CLIENT", "Successfully connected to server");
                return true;
            }
            catch (SocketException ex)
            {
                Logger.Write("SOCKET", $"Socket error: {ex.Message}");
                Disconnect();
                Logger.Write("SOCKET", "Could not connect to server. Please check if the server is running.");
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write("EXCEPTION", $"Connection error: {ex.Message}");
                Disconnect();
                Logger.Write("EXCEPTION", $"Failed to connect: {ex.Message}");
                return false;

            }
        }

        public void SendToServer(Packet packet)
        {
            try
            {
                // Check connection and try to connect if needed
                if (!IsConnected || networkStream == null)
                {
                    Logger.Write("TCP & NETWORKSTREAM", "No active connection, attempting to connect...");
                    if (!Connect())
                    {
                        MessageBox.Show("Could not establish connection to server", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Ensure we have a valid stream after connection
                if (networkStream == null)
                {
                    Logger.Write("NETWORKSTREAM", "Network stream is not available");
                }


                string jsonData = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(jsonData);

                if (networkStream != null)
                {
                    networkStream.Write(data, 0, data.Length);
                    Logger.Write("NETWORKSTREAM", "Packet sent success.");
                }
                else
                {
                    Logger.Write("NETWORKSTREAM", "Cannot send data, network stream is null.");
                }
            }
            catch (Exception ex)
            {
                Logger.Write("EXCEPTION", $"Error sending data: {ex.Message}");
                Disconnect();
                Logger.Write("EXCEPTION", $"Failed to send data: {ex.Message}");
            }
        }

        public async Task<Packet?> SendToServerAndWaitResponse(Packet packet)
        {
            try
            {
                // Check connection and try to connect if needed
                if (!IsConnected || networkStream == null)
                {
                    Logger.Write("TCP & NETWORKSTREAM", "No active connection, attempting to connect...");
                    if (!Connect())
                    {
                        Logger.Write("TCP CLIENT", "Could not establish connection to server");
                    }
                }

                if (networkStream == null)
                {
                    Logger.Write("NETWORKSTREAM", "Network stream is not available");
                    return null;
                }

                // Send the packet
                string jsonData = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(jsonData);
                await networkStream.WriteAsync(data, 0, data.Length);
                Logger.Write("NETWORKSTREAM", "Packet sent success.");

                // Wait for response with timeout
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                byte[] responseBuffer = new byte[4096];

                try
                {
                    int bytesRead = await networkStream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cts.Token);

                    if (bytesRead > 0)
                    {
                        string responseJson = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                        Logger.Write("JSON RESPONSE", $"Received response: {responseJson}");

                        var response = JsonConvert.DeserializeObject<Packet>(responseJson);
                        if (response == null)
                        {
                            Logger.Write("JSON RESPONSE", "Failed to deserialize server response");
                            return null;
                        }

                        // Validate the response format
                        if (!IsValidResponse(response))
                        {
                            Logger.Write("JSON RESPONSE", "Invalid response format from server");
                            return null;
                        }

                        if (Convert.ToInt32(response.Type) == 4 && response.Data["success"] == "true")
                        {
                            int userId = Convert.ToInt32(response.Data["userId"]);
                            string username = response.Data["username"];
                            string role = response.Data["role"];
                            bool success = Convert.ToBoolean(response.Data["success"]);
                            
                            if (success)
                            {
                                try
                                {
                                    CurrentUser.SetCurrentUser(
                                        userId: userId,
                                        username: username,
                                        role: role
                                    );

                                    Logger.Write("CURRENT USER", "Current user set successfully");
                                }
                                catch (Exception ex)
                                {
                                    Logger.Write("CURRENT USER", $"Error setting current user: {ex.Message}");
                                    MessageBox.Show("Error setting current user, Please contact support", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        
                        
                        return response;
                    }
                    else
                    {
                        Logger.Write("BYTES", "Server sent empty response");
                        return null;
                    }
                }
                catch (OperationCanceledException)
                {
                    Logger.Write("CANCELED EXCEPTION", "Server response timeout");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("SEND TO SERVER & WAIT RESPONSE", $"Error in communication: {ex.Message}");
                Disconnect();
                return null;
            }
            finally
            {
                Disconnect();
            }
        }

        private bool IsValidResponse(Packet response)
        {
            if (response == null) return false;

            // Check if Data dictionary exists and has required keys
            if (response.Data == null || !response.Data.ContainsKey("success") || !response.Data.ContainsKey("message"))
            {
                Logger.Write("SERVER RESPONSE", "Response missing required Data fields");
                return false;
            }

            // Validate success value is a valid string
            if (string.IsNullOrEmpty(response.Data["success"]))
            {
                Logger.Write("SERVER RESPONSE", "Response success value is empty");
                return false;
            }

            // Validate message exists (can be empty but should exist)
            if (!response.Data.ContainsKey("message"))
            {
                Logger.Write("SERVER RESPONSE", "Response missing message field");
                return false;
            }

            // Check packet type is valid
            if (!Enum.IsDefined(typeof(PacketType), response.Type))
            {
                Logger.Write("SERVER RESPONSE", $"Invalid packet type: {response.Type}");
                return false;
            }

            Logger.Write("SERVER RESPONSE", "Response validation successful");
            return true;
        }


        public void Disconnect()
        {
            try
            {
                networkStream?.Close();
                tcpClient?.Close();
            }
            catch (Exception ex)
            {
                Logger.Write("TCP & NETWORKSTREAM", $"Error during disconnect: {ex.Message}");
            }
            finally
            {
                networkStream = null;
                tcpClient = null;
            }
        }
    }
}
