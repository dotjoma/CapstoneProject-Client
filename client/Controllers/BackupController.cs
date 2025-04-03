using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Security.Cryptography;
using SkiaSharp;
using System.IO.Compression;
using System.Diagnostics;

namespace client.Controllers
{
    public class BackupController
    {
        public async Task<string?> GetBackupDataAsync(bool isFullBackup, List<string>? selectedTables = null, string? encryptionPassword = null)
        {
            try
            {
                var requestData = new Dictionary<string, object>
                {
                    { "isFullBackup", isFullBackup },
                    { "encryptionPassword", encryptionPassword ?? "" }
                };

                if (!isFullBackup && selectedTables != null)
                {
                    requestData.Add("selectedTables", selectedTables);
                }

                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GetBackupData,
                    Data = new Dictionary<string, string>
                    {
                        { "requestData", JsonSerializer.Serialize(requestData) }
                    }
                });

                if (response?.Data == null)
                {
                    ShowError("No response from server.");
                    return null;
                }

                if (!response.Data.TryGetValue("success", out var successValue) || !bool.TryParse(successValue, out bool isSuccess) || !isSuccess)
                {
                    ShowError(response.Data.TryGetValue("message", out var errorMsg) ? errorMsg : "Backup failed.");
                    return null;
                }

                if (!response.Data.TryGetValue("backupChunks", out var chunkJson) || string.IsNullOrWhiteSpace(chunkJson))
                {
                    ShowError("No backup data received.");
                    return null;
                }

                List<string>? chunks;
                try
                {
                    chunks = JsonSerializer.Deserialize<List<string>>(chunkJson);
                    if (chunks == null || chunks.Count == 0)
                    {
                        ShowError("Backup data is empty.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Failed to parse backup data: {ex.Message}");
                    return null;
                }

                bool isEncrypted = response.Data.TryGetValue("isEncrypted", out var encryptedValue) && encryptedValue == "true";
                string fileExtension = isEncrypted ? ".enc" : ".sql";

                string backupFilePath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}{fileExtension}");

                try
                {
                    byte[] backupBytes = chunks.SelectMany(Convert.FromBase64String).ToArray();
                    File.WriteAllBytes(backupFilePath, backupBytes);
                }
                catch (Exception ex)
                {
                    ShowError($"Failed to write backup file: {ex.Message}");
                    return null;
                }

                return backupFilePath;
            }
            catch (Exception ex)
            {
                ShowError($"Unexpected error: {ex.Message}");
                return null;
            }
        }

        public async Task<bool> UploadToGoogleDriveAsync(string filePath, string folderId)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string encryptedFilePath = Path.Combine(appDirectory, "service-account.enc");
                string decryptedServiceAccountKeyPath = Path.Combine(Path.GetTempPath(), "service-account.json");
                string encryptionKey = "Ao8+WOMEXpRW322CIMxkUrhfWwKCP8tZzZLdwu0FPTY=";

                if (!File.Exists(encryptedFilePath))
                {
                    MessageBox.Show("Encrypted service account file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string encryptedJson = File.ReadAllText(encryptedFilePath);
                string decryptedJson = DecryptString(encryptedJson, encryptionKey);
                File.WriteAllText(decryptedServiceAccountKeyPath, decryptedJson);

                GoogleCredential credential;
                using (var stream = new FileStream(decryptedServiceAccountKeyPath, FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream)
                        .CreateScoped(DriveService.ScopeConstants.DriveFile);
                }

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "ELICIAS GARDEN FOOD PARK",
                });

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(filePath),
                    Parents = new List<string> { folderId }
                };

                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    var request = service.Files.Create(fileMetadata, stream, "application/zip");
                    request.Fields = "id";
                    var result = await request.UploadAsync();

                    if (File.Exists(decryptedServiceAccountKeyPath))
                    {
                        File.WriteAllText(decryptedServiceAccountKeyPath, new string('X', 1024));
                        File.Delete(decryptedServiceAccountKeyPath);
                    }

                    return result.Status == UploadStatus.Completed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Google Drive upload error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> RestoreBackupAsync(string backupFilePath, IProgress<int> progress = null!)
        {
            if (!File.Exists(backupFilePath))
            {
                MessageBox.Show("Backup file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESTORE", "Backup file not found.");
                return false;
            }

            bool isZip = backupFilePath.EndsWith(".zip", StringComparison.OrdinalIgnoreCase);
            bool isSql = backupFilePath.EndsWith(".sql", StringComparison.OrdinalIgnoreCase);

            if (!isZip && !isSql)
            {
                MessageBox.Show("Invalid backup file format. Expected .sql or .zip.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESTORE", "Invalid backup file format.");
                return false;
            }

            string extractedSqlFilePath = backupFilePath;
            string? tempFolder = null;

            try
            {
                if (isZip)
                {
                    tempFolder = Path.Combine(Path.GetTempPath(), "BackupRestore_" + Guid.NewGuid());
                    Directory.CreateDirectory(tempFolder);

                    try
                    {
                        ZipFile.ExtractToDirectory(backupFilePath, tempFolder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to extract ZIP file: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.Write("RESTORE", $"ZIP extraction failed: {ex.Message}");
                        return false;
                    }

                    string[] sqlFiles = Directory.GetFiles(tempFolder, "*.sql", SearchOption.AllDirectories);
                    if (sqlFiles.Length == 0)
                    {
                        MessageBox.Show("No .sql file found in the ZIP archive.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.Write("RESTORE", "No .sql file found in ZIP.");
                        return false;
                    }
                    extractedSqlFilePath = sqlFiles[0];
                }

                var fileInfo = new FileInfo(extractedSqlFilePath);
                if (fileInfo.Length > 100 * 1024 * 1024)
                {
                    var result = MessageBox.Show($"This backup file is large ({fileInfo.Length / (1024 * 1024)}MB). " +
                        "Restoring may take significant time. Continue?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        Logger.Write("RESTORE", "User canceled large file restore.");
                        return false;
                    }
                }

                int chunkSize = 512 * 1024;
                long fileLength = fileInfo.Length;
                int totalChunks = (int)Math.Ceiling((double)fileLength / chunkSize);
                string restoreId = Guid.NewGuid().ToString();

                Logger.Write("RESTORE", $"Starting restore {restoreId} ({totalChunks} chunks)");

                Stopwatch stopwatch = Stopwatch.StartNew();

                using (var fileStream = File.OpenRead(extractedSqlFilePath))
                {
                    byte[] buffer = new byte[chunkSize];
                    int bytesRead;
                    int chunkIndex = 0;

                    while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        byte[] chunkData = bytesRead < buffer.Length ? buffer.Take(bytesRead).ToArray() : buffer;
                        string encodedChunk = Convert.ToBase64String(chunkData);

                        var restoreRequest = new Packet
                        {
                            Type = PacketType.RestoreData,
                            Data = new Dictionary<string, string>
                            {
                                { "restoreId", restoreId },
                                { "chunkIndex", chunkIndex.ToString() },
                                { "totalChunks", totalChunks.ToString() },
                                { "sqlChunk", encodedChunk }
                            }
                        };

                        var response = await Client.Instance.SendRequestAsync(restoreRequest);
                        if (response == null || !response.Success)
                        {
                            string errorMessage = response?.Message ?? "Unknown error";
                            Logger.Write("RESTORE", $"Restore failed at chunk {chunkIndex + 1}/{totalChunks}: {errorMessage}");

                            await Client.Instance.SendRequestAsync(new Packet
                            {
                                Type = PacketType.RestoreData,
                                Data = new Dictionary<string, string> { { "restoreId", restoreId } }
                            });

                            MessageBox.Show($"Restore failed: {errorMessage}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        chunkIndex++;
                        progress?.Report((int)((chunkIndex * 100) / totalChunks));
                    }
                }

                stopwatch.Stop();
                double executionTime = stopwatch.Elapsed.TotalSeconds;
                Logger.Write("RESTORE", $"Restore {restoreId} completed successfully");

                MessageBox.Show($"Database restored successfully in {executionTime:F2} seconds!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            finally
            {
                if (tempFolder != null && Directory.Exists(tempFolder))
                {
                    try
                    {
                        Directory.Delete(tempFolder, true);
                    }
                    catch (Exception ex)
                    {
                        Logger.Write("RESTORE", $"Failed to delete temporary files: {ex.Message}");
                    }
                }
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Logger.Write("ERROR", message);
        }

        private void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Logger.Write("SUCCESS", message);
        }

        private void EncryptServiceAccount()
        {
            string key = "Ao8+WOMEXpRW322CIMxkUrhfWwKCP8tZzZLdwu0FPTY=";
            string jsonPath = "C:\\Users\\raymond balondo\\Desktop\\CAPSTONE\\client\\eliciasgardenbackup-b91eab79c4df.json"; // Original credentials
            string encryptedPath = "C:\\Users\\raymond balondo\\Desktop\\CAPSTONE\\client\\service-account.enc"; // Output file

            string jsonContent = File.ReadAllText(jsonPath);
            string encryptedContent = EncryptString(jsonContent, key);
            File.WriteAllText(encryptedPath, encryptedContent);

            MessageBox.Show("Service account credentials encrypted successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string EncryptString(string plainText, string key)
        {
            try
            {
                byte[] iv = new byte[16];
                byte[] keyBytes = new byte[32];
                byte[] sourceKeyBytes = Encoding.UTF8.GetBytes(key);
                Array.Copy(sourceKeyBytes, keyBytes, Math.Min(sourceKeyBytes.Length, keyBytes.Length));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                            {
                                streamWriter.Write(plainText);
                            }
                        }

                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        private string DecryptString(string cipherText, string key)
        {
            try
            {
                byte[] iv = new byte[16];
                byte[] buffer = Convert.FromBase64String(cipherText);

                using (Aes aes = Aes.Create())
                {
                    byte[] keyBytes = new byte[32];
                    byte[] sourceKeyBytes = Encoding.UTF8.GetBytes(key);
                    Array.Copy(sourceKeyBytes, keyBytes, Math.Min(sourceKeyBytes.Length, keyBytes.Length));

                    aes.Key = keyBytes;
                    aes.IV = iv;

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream(buffer))
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    using (StreamReader streamReader = new StreamReader(cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption failed: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
