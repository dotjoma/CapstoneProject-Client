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

namespace client.Controllers
{
    public class UnitController
    {
        public async Task<bool> Get()
        {
            var getUnitPacket = new Packet
            {
                Type = PacketType.GetUnit
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(getUnitPacket));

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("RESPONSE", "No response received from server");
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string unitsJson = response.Data["units"];
                    List<Unit>? units = JsonSerializer.Deserialize<List<Unit>>(
                        unitsJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentUnit.SetUnits(units ?? new List<Unit>());

                    LoggerHelper.Write("GET UNIT", units?.Count > 0
                        ? $"Retrieved {units.Count} units successfully"
                        : "No units found");

                    return true;
                }
                else
                {
                    string errorMessage = "Unit retrieval failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Unit Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<Unit>> GetAllUnits()
        {
            var getAllUnitPacket = new Packet
            {
                Type = PacketType.GetUnit
            };

            var response = await Client.Instance.SendToServerAndWaitResponse(getAllUnitPacket);
            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("RESPONSE", "No response received from server");
                return new List<Unit>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string unitsJson = response.Data["units"];
                    List<Unit>? units = JsonSerializer.Deserialize<List<Unit>>(
                        unitsJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentUnit.SetUnits(units ?? new List<Unit>());

                    LoggerHelper.Write("GET ALL UNITS", units?.Count > 0
                        ? $"Retrieved {units.Count} units successfully"
                        : "No units found");

                    return units ?? new List<Unit>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve units: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Unit Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Unit>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Unit>();
            }
        }

        public async Task<bool> Create(string unitName, string unitDescription)
        {
            if (string.IsNullOrWhiteSpace(unitName))
            {
                MessageBox.Show("Unit name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(unitDescription))
            {
                MessageBox.Show("Unit description cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var createUnitPacket = new Packet
            {
                Type = PacketType.CreateUnit,
                Data = new Dictionary<string, string>
                {
                    { "unitName", unitName },
                    { "unitDescription", unitDescription }
                }
            };

            try
            {
                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(createUnitPacket));

                if (response == null)
                {
                    MessageBox.Show("Failed to create unit. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true && response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    LoggerHelper.Write("CREATE UNIT", $"Unit '{unitName}' created successfully");
                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true ? response.Data["message"] : "Unknown error occurred while creating unit";
                    LoggerHelper.Write("CREATE UNIT", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create unit: {errorMessage}", "Unit Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("CREATE UNIT", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
