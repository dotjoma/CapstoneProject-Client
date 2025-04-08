using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using Microsoft.Win32;

namespace client.Models.Audit
{
    public class AuditRecord
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public string? Username { get; set; }
        public AuditActionType Action { get; set; }
        public AuditEntityType EntityType { get; set; }
        public string? EntityId { get; set; }
        public string? Description { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string IPAddress { get; set; } = GetDefaultIP();
        public string MachineId { get; set; } = GetMachineGuid();
        public string WindowsSessionId { get; set; } = GetWindowsSessionId();
        public string WindowsUserSid { get; set; } = GetWindowsUserSid();
        public string? DeviceInfo { get; set; } = GetDeviceInfo();
        public string? Status { get; set; }

        private static string GetDefaultIP()
        {
            try
            {
                return Dns.GetHostEntry(Dns.GetHostName())
                    .AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?
                    .ToString() ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }

        private static string GetMachineGuid()
        {
            try
            {
                var guid = Registry.GetValue(
                    @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography",
                    "MachineGuid",
                    null) as string;

                return guid ?? "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }

        private static string GetWindowsSessionId()
        {
            return Process.GetCurrentProcess().SessionId.ToString();
        }

        private static string GetWindowsUserSid()
        {
            return WindowsIdentity.GetCurrent().User?.Value ?? "Unknown";
        }

        private static string GetDeviceInfo()
        {
            return $"{Environment.MachineName} | " +
                   $"{Environment.OSVersion.VersionString} | " +
                   $"{(Environment.Is64BitOperatingSystem ? "x64" : "x86")}";
        }


    }
}