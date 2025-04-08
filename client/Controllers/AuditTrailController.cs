using client.Helpers;
using client.Models;
using client.Models.Audit;
using client.Network;
using client.Services;
using Google.Apis.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class AuditTrailController
    {
        public async Task<bool> SaveAudit(AuditRecord record)
        {
            if (record == null)
            {
                Logger.Write("AuditError", "Attempted to save a null audit record");
                return false;
            }

            var auditData = new Dictionary<string, string>
            {
                { "user_id", record.UserId.ToString() },
                { "action_type", record.Action.ToString() },
                { "description", record.Description! },
                { "prev_value", record.OldValue! },
                { "new_value", record.NewValue! },
                { "ip_address", record.IPAddress },
                { "entity", record.EntityType.ToString() },
                { "entity_id", record.EntityId! }
            };

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.AuditSave,
                    Data = auditData
                });

                if (response == null)
                {
                    Logger.Write("AuditError", "No response received from server when saving audit log");
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                    else
                    {
                        string errorMessage = response.Data.ContainsKey("message")
                            ? $"Audit log save failed: {response.Data["message"]}"
                            : "Audit log save failed: Unknown error occurred";

                        Logger.Write("AuditError", errorMessage);
                        return false;
                    }
                }
                else
                {
                    Logger.Write("AuditError", "Invalid response format from server when saving audit log");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("AuditError", $"Error while saving audit log: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Audit>> GetAllAudits()
        {
            const string methodName = nameof(GetAllAudits);
            Logger.Write(methodName, "Starting to retrieve audits");

            try
            {
                // Send request to server
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GetAudit
                }).ConfigureAwait(false);

                // Handle null response
                if (response == null)
                {
                    const string errorMessage = "No response received from server";
                    Logger.Write(methodName, errorMessage);
                    MessageBox.Show(errorMessage, "Communication Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Audit>();
                }

                // Validate response structure
                if (response.Data == null || !response.Data.ContainsKey("success"))
                {
                    const string errorMessage = "Invalid response format from server";
                    Logger.Write(methodName, $"{errorMessage}. Data: {JsonSerializer.Serialize(response.Data)}");
                    MessageBox.Show(errorMessage, "Data Format Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Audit>();
                }

                // Handle unsuccessful response
                if (!response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string errorMessage = response.Data.TryGetValue("message", out var message)
                        ? $"Failed to retrieve audits: {message}"
                        : "Failed to retrieve audits: Unknown error occurred";

                    Logger.Write(methodName, errorMessage);
                    MessageBox.Show(errorMessage, "Audit Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Audit>();
                }

                // Process successful response
                if (!response.Data.TryGetValue("audits", out var auditsJson) || string.IsNullOrEmpty(auditsJson))
                {
                    Logger.Write(methodName, "No audits data found in response");
                    return new List<Audit>();
                }

                // Deserialize audits
                List<Audit>? audits;
                try
                {
                    audits = JsonSerializer.Deserialize<List<Audit>>(
                        auditsJson,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                        });
                }
                catch (JsonException ex)
                {
                    Logger.Write(methodName, $"Failed to deserialize audits: {ex.Message}");
                    MessageBox.Show("Failed to process audit data from server", "Data Processing Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Audit>();
                }

                // Update current audits
                var auditList = audits ?? new List<Audit>();
                CurrentAudit.SetAudits(auditList);

                Logger.Write(methodName, $"Successfully retrieved {auditList.Count} audits");
                return auditList;
            }
            catch (Exception ex)
            {
                Logger.Write(methodName, $"Unexpected error: {ex}");
                MessageBox.Show("An unexpected error occurred while retrieving audits", "System Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Audit>();
            }
        }
    }
}
