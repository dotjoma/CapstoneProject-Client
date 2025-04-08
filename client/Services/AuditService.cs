using client.Controllers;
using client.Helpers;
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
        Task Log(AuditRecord record);
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

        AuditTrailController _auditTrailController = new AuditTrailController();


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

        public async Task Log(AuditRecord record)
        {
            if (record == null)
            {
                Logger.Write("AUDIT_TRAIL_ERROR", "Audit record cannot be null");
                throw new ArgumentNullException(nameof(record));
            }

            try
            {
                string json = JsonSerializer.Serialize(record, _jsonOptions);
                await File.AppendAllTextAsync(_logPath, $"{json}{Environment.NewLine}");

                Logger.Write("AUDIT_TRAIL_DEBUG", $"Local audit log written: {record.Action} for {record.Username}");

                bool success = await _auditTrailController.SaveAudit(record);
                if (!success)
                {
                    Logger.Write("AUDIT_TRAIL_WARNING", $"Database save failed for {record.Action} (User: {record.Username})");
                }
            }
            catch (JsonException jsonEx)
            {
                Logger.Write("AUDIT_TRAIL_ERROR", $"JSON serialization failed: {jsonEx.Message}");
                throw;
            }
            catch (IOException ioEx)
            {
                Logger.Write("AUDIT_TRAIL_CRITICAL", $"File write failed: {ioEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Logger.Write("AUDIT_TRAIL_CRITICAL", $"Unexpected error: {ex.Message}");
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