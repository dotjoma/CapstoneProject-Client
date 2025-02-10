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
                // Clean up any existing connections first
                Disconnect();

                // Create new TCP client
                tcpClient = new TcpClient();

                // Create connection timeout
                var result = tcpClient.BeginConnect(serverIp, serverPort, null, null);
                var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5)); // 5 second timeout

                if (!success)
                {
                    Disconnect();
                    Debug.WriteLine("Failed to connect to server: Connection timed out");
                    return false;
                }


                tcpClient.EndConnect(result);

                // Initialize network stream
                networkStream = tcpClient.GetStream();
                if (networkStream == null)
                {
                    Debug.WriteLine("Failed to initialize network stream");
                    return false;
                }



                Debug.WriteLine("Successfully connected to server");
                return true;
            }
            catch (SocketException ex)
            {
                Debug.WriteLine($"Socket error: {ex.Message}");
                Disconnect();
                Debug.WriteLine("Could not connect to server. Please check if the server is running.");
                return false;
            }
            catch (Exception ex)


            {
                Debug.WriteLine($"Connection error: {ex.Message}");
                Disconnect();
                Debug.WriteLine($"Failed to connect: {ex.Message}");
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
                    Debug.WriteLine("No active connection, attempting to connect...");
                    if (!Connect())
                    {
                        MessageBox.Show("Could not establish connection to server", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Ensure we have a valid stream after connection
                if (networkStream == null)
                {
                    Debug.WriteLine("Network stream is not available");
                }


                string jsonData = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(jsonData);

                if (networkStream != null)
                {
                    networkStream.Write(data, 0, data.Length);
                    Debug.WriteLine($"Sent packet: {jsonData}");
                }
                else
                {
                    Debug.WriteLine("Cannot send data, network stream is null.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error sending data: {ex.Message}");
                Disconnect(); // Clean up the connection on error
                Debug.WriteLine($"Failed to send data: {ex.Message}");
            }
        }

        public async Task<Packet?> SendToServerAndWaitResponse(Packet packet)
        {
            try
            {
                // Check connection and try to connect if needed
                if (!IsConnected || networkStream == null)
                {
                    Debug.WriteLine("No active connection, attempting to connect...");
                    if (!Connect())
                    {
                        throw new Exception("Could not establish connection to server");
                    }
                }

                if (networkStream == null)
                {
                    throw new Exception("Network stream is not available");
                }

                // Send the packet
                string jsonData = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(jsonData);
                await networkStream.WriteAsync(data, 0, data.Length);
                Debug.WriteLine($"Sent packet: {jsonData}");

                // Wait for response with timeout
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10)); // 10 second timeout
                byte[] responseBuffer = new byte[4096];

                try
                {
                    int bytesRead = await networkStream.ReadAsync(responseBuffer, 0, responseBuffer.Length, cts.Token);

                    if (bytesRead > 0)
                    {
                        string responseJson = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);
                        Debug.WriteLine($"Received response: {responseJson}");

                        var response = JsonConvert.DeserializeObject<Packet>(responseJson);
                        if (response == null)
                        {
                            throw new Exception("Failed to deserialize server response");
                        }

                        // Validate the response format
                        if (!IsValidResponse(response))
                        {
                            throw new Exception("Invalid response format from server");
                        }

                        return response;
                    }
                    else
                    {
                        throw new Exception("Server sent empty response");
                    }
                }
                catch (OperationCanceledException)
                {
                    throw new Exception("Server response timeout");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in communication: {ex.Message}");
                Disconnect();
                throw;
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
                Debug.WriteLine("Response missing required Data fields");
                return false;
            }

            // Validate success value is a valid string
            if (string.IsNullOrEmpty(response.Data["success"]))
            {
                Debug.WriteLine("Response success value is empty");
                return false;
            }

            // Validate message exists (can be empty but should exist)
            if (!response.Data.ContainsKey("message"))
            {
                Debug.WriteLine("Response missing message field");
                return false;
            }

            // Check packet type is valid
            if (!Enum.IsDefined(typeof(PacketType), response.Type))
            {
                Debug.WriteLine($"Invalid packet type: {response.Type}");
                return false;
            }

            Debug.WriteLine("Response validation successful");
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
                Debug.WriteLine($"Error during disconnect: {ex.Message}");
            }
            finally
            {
                networkStream = null;
                tcpClient = null;
            }
        }
    }
}
