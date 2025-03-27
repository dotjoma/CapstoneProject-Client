using client.Models.Audit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace client.Services
{
    public interface IAuditService
    {
        void Log(AuditRecord record);
        IEnumerable<AuditRecord> GetLogs(DateTime from, DateTime to);
        IEnumerable<AuditRecord> GetEntityLogs(AuditEntityType type, string entityId);
    }

    public class AuditService : IAuditService
    {
        private readonly string _logPath;
        private readonly object _fileLock = new object();
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = false
        };

        public AuditService(string? logPath = null)
        {
            _logPath = logPath ?? GetDefaultLogPath();
            EnsureLogDirectoryExists();
        }

        private string GetDefaultLogPath()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            return Path.Combine(appDataPath, "EliciasGarden", "audit.log");
        }

        private void EnsureLogDirectoryExists()
        {
            try
            {
                var directoryPath = Path.GetDirectoryName(_logPath);

                if (string.IsNullOrWhiteSpace(directoryPath))
                {
                    directoryPath = Path.GetDirectoryName(GetDefaultLogPath());
                }

                if (!string.IsNullOrWhiteSpace(directoryPath) && !Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to create audit log directory: {ex.Message}", ex);
            }
        }

        public void Log(AuditRecord record)
        {
            if (record == null) throw new ArgumentNullException(nameof(record));

            lock (_fileLock)
            {
                try
                {
                    string json = JsonSerializer.Serialize(record, _jsonOptions);
                    File.AppendAllText(_logPath, $"{json}{Environment.NewLine}");
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException($"Failed to write audit log: {ex.Message}", ex);
                }
            }
        }

        public IEnumerable<AuditRecord> GetLogs(DateTime from, DateTime to)
        {
            lock (_fileLock)
            {
                if (!File.Exists(_logPath))
                    return Enumerable.Empty<AuditRecord>();

                return File.ReadLines(_logPath)
                    .Select(line => JsonSerializer.Deserialize<AuditRecord>(line))
                    .OfType<AuditRecord>()
                    .Where(record => record.Timestamp >= from && record.Timestamp <= to)
                    .OrderByDescending(r => r.Timestamp);
            }
        }

        public IEnumerable<AuditRecord> GetEntityLogs(AuditEntityType type, string entityId)
        {
            return GetLogs(DateTime.MinValue, DateTime.MaxValue)
                .Where(r => r.EntityType == type && r.EntityId == entityId);
        }
    }
}