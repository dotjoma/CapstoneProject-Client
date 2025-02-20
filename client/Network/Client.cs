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
using client.Models;

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
            int retryCount = 0;
            const int maxRetries = 2;

            while (retryCount <= maxRetries)
            {
                try
                {
                    if (!HasConnection())
                    {
                        Logger.Write("CONNECTION", "No connection available");
                        return null;
                    }

                    if (networkStream == null)
                    {
                        Logger.Write("NETWORKSTREAM", "Network stream is not available");
                        return null;
                    }

                    try
                    {
                        string jsonData = JsonConvert.SerializeObject(packet) + "\n";
                        byte[] data = Encoding.UTF8.GetBytes(jsonData);
                        await networkStream.WriteAsync(data, 0, data.Length);
                        await networkStream.FlushAsync();

                        Logger.Write("NETWORKSTREAM", "Packet sent success.");
                    }
                    catch (Exception ex)
                    {
                        Logger.Write("WRITE ERROR", $"Failed to send data: {ex.Message}");
                        Disconnect();
                        retryCount++;
                        continue;
                    }

                    // Wait for response with timeout
                    using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                    byte[] responseBuffer = new byte[8192];

                    try
                    {
                        // Read a single response
                        int bytesRead = await networkStream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cts.Token);

                        if (bytesRead <= 0)
                        {
                            Logger.Write("BYTES", "Server sent empty response");
                            return null;
                        }

                        string responseJson = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead).Trim();
                        Logger.Write("JSON RESPONSE", $"Received response: {responseJson}");

                        var response = JsonConvert.DeserializeObject<Packet>(responseJson);
                        if (response == null)
                        {
                            Logger.Write("JSON RESPONSE", "Failed to deserialize server response");
                            return null;
                        }

                        if (!IsValidResponse(response))
                        {
                            Logger.Write("JSON RESPONSE", "Invalid response format from server");
                            return null;
                        }

                        HandleLogin(response);
                        return response;
                    }
                    catch (IOException ex)
                    {
                        Logger.Write("READ ERROR", $"Connection error while reading: {ex.Message}");
                        Disconnect();

                        if (retryCount < maxRetries)
                        {
                            Logger.Write("RETRY", $"Attempting to reconnect (Attempt {retryCount + 1} of {maxRetries})");
                            await Task.Delay(1000); // Wait 1 second before retrying
                            retryCount++;
                            continue;
                        }
                        return null;
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

                    if (retryCount < maxRetries)
                    {
                        Logger.Write("RETRY", $"Attempting to reconnect (Attempt {retryCount + 1} of {maxRetries})");
                        await Task.Delay(1000); // Wait 1 second before retrying
                        retryCount++;
                        continue;
                    }
                    return null;
                }
            }

            Logger.Write("RETRY", "Max retry attempts reached");
            return null;
        }

        public void HandleLogin(Packet response)
        {
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
                        var userSession = new UserSession()
                        {
                            UserId = userId,
                            Username = username,
                            Role = role,
                            LoginTime = DateTime.Now
                        };
                        
                        CurrentUser.SetCurrentUser(userSession);

                        Logger.Write("CURRENT USER", $"Current user set successfully");
                    }
                    catch (Exception ex)
                    {
                        Logger.Write("CURRENT USER", $"Error setting current user: {ex.Message}");
                        MessageBox.Show("Error setting current user, Please contact support", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool HasConnection()
        {
            try
            {
                if (tcpClient?.Client != null && networkStream != null)
                {
                    // Check if connection is actually still valid
                    if (!tcpClient.Connected)
                    {
                        Logger.Write("CONNECTION CHECK", "Connection detected as closed");
                        Disconnect();
                        return Connect();
                    }
                    return true;
                }

                Logger.Write("TCP & NETWORKSTREAM", "No active connection, attempting to connect...");
                return Connect();
            }
            catch (Exception ex)
            {
                Logger.Write("CONNECTION CHECK", $"Error checking connection: {ex.Message}");
                Disconnect();
                return Connect();
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
