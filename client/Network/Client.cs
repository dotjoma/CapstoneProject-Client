using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Configuration;
using Newtonsoft.Json;
using client.Helpers;
using client.Models;
using client.Services.Auth;
using Newtonsoft.Json.Linq;

namespace client.Network
{
    public class Client : IDisposable
    {
        private static readonly object _instanceLock = new object();
        private static Client? _instance;

        // Connection pool settings
        private const int MaxPoolSize = 3;
        private const int MinPoolSize = 1;
        private readonly ConcurrentBag<TcpClient> _connectionPool = new();
        private readonly SemaphoreSlim _poolSemaphore = new(MaxPoolSize, MaxPoolSize);
        private readonly CancellationTokenSource _lifetimeCts = new();

        // Network settings
        private readonly string _serverIp;
        private readonly int _serverPort;
        private readonly TimeSpan _connectTimeout = TimeSpan.FromSeconds(5);
        private readonly TimeSpan _sendTimeout = TimeSpan.FromSeconds(10);
        private readonly TimeSpan _receiveTimeout = TimeSpan.FromSeconds(30);
        private readonly TimeSpan _keepAliveInterval = TimeSpan.FromSeconds(30);
        private const int MaxRetryAttempts = 2;
        private const int RetryBaseDelayMs = 1000;

        // Statistics
        private int _totalConnectionsCreated;
        private int _failedConnections;

        public static Client Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        _instance ??= new Client();
                    }
                }
                return _instance;
            }
        }

        private Client()
        {
            _serverIp = ConfigurationManager.AppSettings["ServerIP"] ?? "127.0.0.1";
            if (!int.TryParse(ConfigurationManager.AppSettings["ServerPort"], out int port))
            {
                port = 8888;
            }
            _serverPort = port;

            // Initialize connection pool
            _ = InitializeConnectionPoolAsync();
        }

        private async Task InitializeConnectionPoolAsync()
        {
            for (int i = 0; i < MinPoolSize; i++)
            {
                var client = await CreateNewConnectionAsync();
                if (client != null)
                {
                    _connectionPool.Add(client);
                }
            }
        }

        public async Task<Packet?> SendRequestAsync(Packet packet)
        {
            for (int attempt = 0; attempt <= MaxRetryAttempts; attempt++)
            {
                TcpClient? client = null;
                NetworkStream? stream = null;

                try
                {
                    // Get connection from pool or create new one
                    client = await GetConnectionAsync();
                    if (client == null)
                    {
                        Logger.Write("CONNECTION", "Failed to obtain connection");
                        continue;
                    }

                    stream = client.GetStream();
                    stream.ReadTimeout = (int)_receiveTimeout.TotalMilliseconds;
                    stream.WriteTimeout = (int)_sendTimeout.TotalMilliseconds;

                    // Send request
                    var sendTask = SendPacketAsync(stream, packet);
                    var timeoutTask = Task.Delay(_sendTimeout, _lifetimeCts.Token);
                    var completedTask = await Task.WhenAny(sendTask, timeoutTask);

                    if (completedTask == timeoutTask)
                    {
                        Logger.Write("TIMEOUT", "Send operation timed out");
                        continue;
                    }

                    if (!await sendTask)
                    {
                        continue;
                    }

                    // Receive response
                    var receiveTask = ReceiveResponseAsync(stream);
                    timeoutTask = Task.Delay(_receiveTimeout, _lifetimeCts.Token);
                    completedTask = await Task.WhenAny(receiveTask, timeoutTask);

                    if (completedTask == timeoutTask)
                    {
                        Logger.Write("TIMEOUT", "Receive operation timed out");
                        continue;
                    }

                    var response = await receiveTask;
                    if (response != null)
                    {
                        HandleLogin(response);
                        ReturnConnectionToPool(client);
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Write("ERROR", $"Attempt {attempt + 1} failed: {ex.Message}");
                    client?.Dispose();

                    if (attempt < MaxRetryAttempts)
                    {
                        int delay = RetryBaseDelayMs * (attempt + 1);
                        Logger.Write("RETRY", $"Waiting {delay}ms before retry...");
                        await Task.Delay(delay, _lifetimeCts.Token);
                    }
                }
                finally
                {
                    stream?.Dispose();
                }
            }

            Logger.Write("ERROR", "Max retry attempts reached");
            return null;
        }

        private async Task<TcpClient?> GetConnectionAsync()
        {
            // Try to get from pool first
            if (_connectionPool.TryTake(out var client))
            {
                if (IsConnectionValid(client))
                {
                    return client;
                }
                client.Dispose();
            }

            // Create new connection if pool is empty
            return await CreateNewConnectionAsync();
        }

        private void ReturnConnectionToPool(TcpClient client)
        {
            if (_connectionPool.Count < MaxPoolSize && IsConnectionValid(client))
            {
                _connectionPool.Add(client);
            }
            else
            {
                client.Dispose();
            }
        }

        private async Task<TcpClient?> CreateNewConnectionAsync()
        {
            try
            {
                var client = new TcpClient();
                ConfigureKeepAlive(client.Client);

                var connectTask = client.ConnectAsync(_serverIp, _serverPort);
                var timeoutTask = Task.Delay(_connectTimeout, _lifetimeCts.Token);
                var completedTask = await Task.WhenAny(connectTask, timeoutTask);

                if (completedTask == timeoutTask || !client.Connected)
                {
                    client.Dispose();
                    _failedConnections++;
                    Logger.Write("CONNECTION", "Connection timed out");
                    return null;
                }

                _totalConnectionsCreated++;
                return client;
            }
            catch (Exception ex)
            {
                _failedConnections++;
                Logger.Write("CONNECTION", $"Failed to create connection: {ex.Message}");
                return null;
            }
        }

        private bool IsConnectionValid(TcpClient client)
        {
            try
            {
                return client.Connected &&
                       client.Client != null &&
                       client.Client.Connected &&
                       (client.Client.Poll(1000, SelectMode.SelectRead) ? client.Client.Available > 0 : true);
            }
            catch
            {
                return false;
            }
        }

        private void ConfigureKeepAlive(Socket socket)
        {
            try
            {
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

                if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                {
                    byte[] inValue = new byte[12];
                    BitConverter.GetBytes(1u).CopyTo(inValue, 0);
                    BitConverter.GetBytes((uint)_keepAliveInterval.TotalMilliseconds).CopyTo(inValue, 4);
                    BitConverter.GetBytes((uint)_keepAliveInterval.TotalMilliseconds).CopyTo(inValue, 8);

                    socket.IOControl(IOControlCode.KeepAliveValues, inValue, null);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("KEEPALIVE", $"Failed to configure keep-alive: {ex.Message}");
            }
        }

        private async Task<bool> SendPacketAsync(NetworkStream stream, Packet packet)
        {
            string jsonData = JsonConvert.SerializeObject(packet) + "\n";
            byte[] data = Encoding.UTF8.GetBytes(jsonData);

            await stream.WriteAsync(data, 0, data.Length, _lifetimeCts.Token);
            await stream.FlushAsync(_lifetimeCts.Token);

            Logger.Write("NETWORK", $"Sent packet (Type: {packet.Type})");
            return true;
        }

        private async Task<Packet?> ReceiveResponseAsync(NetworkStream stream)
        {
            try
            {
                using var memoryStream = new MemoryStream();
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, _lifetimeCts.Token)) > 0)
                {
                    await memoryStream.WriteAsync(buffer, 0, bytesRead, _lifetimeCts.Token);

                    // Check for message terminator
                    if (buffer[bytesRead - 1] == '\n')
                    {
                        break;
                    }
                }

                if (memoryStream.Length == 0)
                {
                    Logger.Write("NETWORK", "Empty response received");
                    return null;
                }

                string responseJson = Encoding.UTF8.GetString(memoryStream.ToArray()).Trim();

                try
                {
                    var parsed = JObject.Parse(responseJson);

                    if (parsed.TryGetValue("Data", out var dataToken) && dataToken is JObject dataObj)
                    {
                        if (dataObj.TryGetValue("products", out var productsToken))
                        {
                            JArray? productArray = productsToken.Type == JTokenType.String
                                ? JArray.Parse(productsToken.ToString())
                                : productsToken as JArray;

                            if (productArray != null)
                            {
                                foreach (var product in productArray)
                                {
                                    if (product is JObject productObj)
                                    {
                                        productObj.Remove("productImage");
                                    }
                                }

                                dataObj["products"] = productArray;
                            }
                        }

                        var sanitized = new JObject(parsed);
                        string sanitizedLog = sanitized.ToString(Formatting.None);

                        Logger.Write("NETWORK", $"Received: {sanitizedLog}");
                    }
                    else
                    {
                        Logger.Write("NETWORK", $"Received (basic structure): {new JObject { ["Type"] = parsed["Type"] }}");
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        var minimalInfo = JObject.Parse(responseJson);
                        minimalInfo.Remove("Data");
                        Logger.Write("NETWORK", $"Received (minimal): {minimalInfo.ToString(Formatting.None)}");
                    }
                    catch
                    {
                        Logger.Write("NETWORK", "Received (raw data unavailable)");
                    }
                    Logger.Write("ERROR", $"Failed to process response: {ex.Message}");
                }

                var response = JsonConvert.DeserializeObject<Packet>(responseJson);
                if (response == null || !IsValidResponse(response))
                {
                    Logger.Write("NETWORK", "Invalid response format");
                    return null;
                }

                return response;
            }
            catch (Exception ex)
            {
                Logger.Write("NETWORK", $"Receive error: {ex.Message}");
                throw;
            }
        }

        private bool IsValidResponse(Packet response)
        {
            return response != null &&
                   response.Data != null &&
                   response.Data.ContainsKey("success") &&
                   Enum.IsDefined(typeof(PacketType), response.Type);
        }

        private void HandleLogin(Packet response)
        {
            if (response.Type == PacketType.LoginResponse &&
                response.Data.TryGetValue("success", out var success) &&
                success == "true")
            {
                try
                {
                    var userSession = new UserSession
                    {
                        UserId = Convert.ToInt32(response.Data["userId"]),
                        Username = response.Data["username"],
                        Role = response.Data["role"],
                        LoginTime = DateTime.Now
                    };

                    CurrentUser.SetCurrentUser(userSession);
                    Logger.Write("AUTH", $"User authenticated: {userSession.Username}");
                }
                catch (Exception ex)
                {
                    Logger.Write("AUTH", $"Error setting user session: {ex.Message}");
                }
            }
        }

        public void Dispose()
        {
            _lifetimeCts.Cancel();

            while (_connectionPool.TryTake(out var client))
            {
                client.Dispose();
            }

            _poolSemaphore.Dispose();
            _lifetimeCts.Dispose();
        }
    }
}