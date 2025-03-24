using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace client.Helpers
{
    public class Logger
    {
        private static readonly string logDirectory = "logs";
        private const long MAX_FILE_SIZE = 5 * 1024 * 1024; // 5MB in bytes

        public static void Write(string type, string message)
        {
            try
            {
                EnsureLogDirectoryExists();
                string logFilePath = GetCurrentLogFilePath();

                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ {type} ] : {message}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }

        public static void LogPOSEvent(string eventType, string details, int orderId)
        {
            try
            {
                EnsureLogDirectoryExists();
                string logFilePath = GetCurrentLogFilePath();

                var logEntry = new
                {
                    Timestamp = DateTime.Now,
                    Event = eventType,
                    OrderId = orderId,
                    Details = details,
                    Machine = Environment.MachineName
                };

                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ POS_EVENT ] : {JsonSerializer.Serialize(logEntry)}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error logging POS event: {ex.Message}");
            }
        }

        private static void EnsureLogDirectoryExists()
        {
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        private static string GetCurrentLogFilePath()
        {
            string baseFileName = DateTime.Now.ToString("yyyy-MM-dd");
            string initialPath = Path.Combine(logDirectory, $"{baseFileName}.log");

            if (!File.Exists(initialPath))
            {
                return initialPath;
            }

            var fileInfo = new FileInfo(initialPath);
            if (fileInfo.Length < MAX_FILE_SIZE)
            {
                return initialPath;
            }

            int index = 1;
            while (true)
            {
                string newPath = Path.Combine(logDirectory, $"{baseFileName}_{index}.log");
                if (!File.Exists(newPath))
                {
                    return newPath;
                }

                fileInfo = new FileInfo(newPath);
                if (fileInfo.Length < MAX_FILE_SIZE)
                {
                    return newPath;
                }

                index++;
            }
        }
    }
}