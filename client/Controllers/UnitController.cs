using client.Forms.ProductManagement;
using client.Helpers;
using client.Models;
using client.Models.Audit;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace client.Controllers
{
    public class UnitController
    {
        AuditService _auditService = new AuditService();
        public async Task<bool> Get()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetUnit
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
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

                    Logger.Write("GET UNIT", units?.Count > 0
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
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetUnit
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
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

                    Logger.Write("GET ALL UNITS", units?.Count > 0
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

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateUnit,
                    Data = new Dictionary<string, string>
                    {
                        { "unitName", unitName },
                        { "unitDescription", unitDescription }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("Failed to create unit. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true && response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE UNIT", $"Unit '{unitName}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Unit created successfully",
                        OldValue = "No unit existed",
                        NewValue = $"Name: {unitName}",
                        EntityType = AuditEntityType.Unit,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true ? response.Data["message"] : "Unknown error occurred while creating unit";
                    Logger.Write("CREATE UNIT", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create unit: {errorMessage}", "Unit Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("CREATE UNIT", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> CreateUnitType(string unitTypeName, string symbol)
        {
            if (string.IsNullOrWhiteSpace(unitTypeName))
            {
                MessageBox.Show("Unit type name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateUnitType,
                    Data = new Dictionary<string, string>
                    {
                        { "unitName", unitTypeName },
                        { "unitSymbol", symbol }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("Failed to create unit type. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE UNIT TYPE", $"Unit type '{unitTypeName}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Unit type created successfully",
                        OldValue = "No unit type existed",
                        NewValue = $"Name: {unitTypeName}",
                        EntityType = AuditEntityType.UnitType,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred while creating unit type";

                    Logger.Write("CREATE UNIT TYPE", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create unit type: {errorMessage}", "Unit Type Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("CREATE UNIT TYPE", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<InventoryUnitType>> GetAllInventoryUnitTypes()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetUnitType
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventoryUnitType>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string unitTypesJson = response.Data["unittypes"];
                    List<InventoryUnitType>? unitTypes = JsonSerializer.Deserialize<List<InventoryUnitType>>(
                        unitTypesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventoryUnitType.SetUnitTypes(unitTypes ?? new List<InventoryUnitType>());

                    return unitTypes ?? new List<InventoryUnitType>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve unit types: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Unit Type Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return new List<InventoryUnitType>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventoryUnitType>();
            }
        }

        public async Task<bool> CreateUnitMeasure(string measureName, string measureSymbol)
        {
            if (string.IsNullOrWhiteSpace(measureName))
            {
                MessageBox.Show("Measure name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateUnitMeasure,
                    Data = new Dictionary<string, string>
                    {
                        { "measureName", measureName },
                        { "measureSymbol", measureSymbol }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("Failed to create unit measure. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE UNIT MEASURE", $"Unit measure '{measureName}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Unit measure created successfully",
                        OldValue = "No unit measure existed",
                        NewValue = $"Name: {measureName}",
                        EntityType = AuditEntityType.UnitMeasure,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred while creating unit measure";

                    Logger.Write("CREATE UNIT MEASURE", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create unit measure: {errorMessage}", "Unit Measure Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("CREATE UNIT MEASURE", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<InventoryUnitMeasure>> GetAllInventoryUnitMeasures()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetUnitMeasure
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventoryUnitMeasure>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string unitMeasuresJson = response.Data["unitmeasures"];
                    List<InventoryUnitMeasure>? unitMeasures = JsonSerializer.Deserialize<List<InventoryUnitMeasure>>(
                        unitMeasuresJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventoryUnitMeasure.SetUnitMeasures(unitMeasures ?? new List<InventoryUnitMeasure>());

                    return unitMeasures ?? new List<InventoryUnitMeasure>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve unit measures: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Unit Measure Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return new List<InventoryUnitMeasure>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventoryUnitMeasure>();
            }
        }
    }
}
