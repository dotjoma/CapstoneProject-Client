using client.Helpers;
using client.Models;
using client.Models.Audit;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace client.Controllers
{
    public class InventoryController
    {
        AuditService _auditService = new AuditService();

        public async Task<bool> CreateInventoryItem(
            string itemName, int categoryId, int subcategoryId, string batchNumber,
            string purchaseDate, string expirationDate, decimal batchQuantity,
            int unitTypeId, int unitMeasureId, decimal minStock, decimal maxStock,
            decimal reorderPoint, int leadTime, int turnOver, decimal unitCost, int? supplierId, bool enableLowStockAlert)
        {
            if (string.IsNullOrWhiteSpace(itemName) ||
                string.IsNullOrWhiteSpace(batchNumber) ||
                batchQuantity <= 0 ||
                unitCost <= 0)
            {
                MessageBox.Show("Required fields are missing or invalid", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime purchaseDateData = DateTime.Parse(purchaseDate);
            DateTime expirationDateData = DateTime.Parse(expirationDate);

            if (expirationDateData < purchaseDateData)
            {
                MessageBox.Show("Expiration date cannot be before purchase date", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateInventoryItem,
                    Data = new Dictionary<string, string>
                    {
                        { "itemName", itemName },
                        { "categoryId", categoryId.ToString() },
                        { "subcategoryId", subcategoryId.ToString() },
                        { "batchNumber", batchNumber },
                        { "purchaseDate", purchaseDateData.ToString() },
                        { "expirationDate", expirationDateData.ToString() },
                        { "batchQuantity", batchQuantity.ToString() },
                        { "unitTypeId", unitTypeId.ToString() },
                        { "unitMeasureId", unitMeasureId.ToString() },
                        { "minStock", minStock.ToString() },
                        { "maxStock", maxStock.ToString() },
                        { "reorderPoint", reorderPoint.ToString() },
                        { "leadTime", leadTime.ToString() },
                        { "turnOver", turnOver.ToString() },
                        { "unitCost", unitCost.ToString() },
                        { "supplierId", supplierId.ToString() ?? "" },
                        { "enableLowStockAlert", enableLowStockAlert ? "1" : "0" }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        string inventoryDetails = $"Item: {itemName}, " +
                            $"Batch: {batchNumber}, " +
                            $"Qty: {batchQuantity}{CurrentInventoryUnitMeasure.Current?.measureName}, " +
                            $"Cost: {unitCost:C}";

                        await _auditService.Log(new AuditRecord
                        {
                            UserId = CurrentUser.Current!.UserId,
                            Action = AuditActionType.Create,
                            Description = "Inventory item created successfully",
                            OldValue = "No inventory item existed",
                            NewValue = inventoryDetails,
                            EntityType = AuditEntityType.Inventory,
                            EntityId = response.Data.ContainsKey("inventoryId") ?
                                      response.Data["inventoryId"] : "unknown"
                        });

                        return true;
                    }
                    else
                    {
                        string errorMessage = "Inventory creation failed: " +
                            (response.Data.ContainsKey("message") ?
                             response.Data["message"] : "Unknown error occurred");

                        MessageBox.Show(errorMessage, "Inventory Creation Failed",
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> UpdateInventoryItem(
            int itemId,
            string itemName, int categoryId, int subcategoryId, string batchNumber,
            string purchaseDate, string expirationDate, decimal batchQuantity,
            decimal currentQuantity, int unitTypeId, int unitMeasureId, decimal minStock, 
            decimal maxStock, decimal reorderPoint, int leadTime, int turnOver, decimal unitCost, 
            int? supplierId, bool enableLowStockAlert)
        {
            if (string.IsNullOrWhiteSpace(itemName) ||
                string.IsNullOrWhiteSpace(batchNumber) ||
                batchQuantity <= 0 ||
                unitCost <= 0)
            {
                MessageBox.Show("Required fields are missing or invalid", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime purchaseDateData = DateTime.Parse(purchaseDate);
            DateTime expirationDateData = DateTime.Parse(expirationDate);

            if (expirationDateData < purchaseDateData)
            {
                MessageBox.Show("Expiration date cannot be before purchase date", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.UpdateInventoryItem,
                    Data = new Dictionary<string, string>
                    {
                        { "itemId", itemId.ToString() },
                        { "itemName", itemName },
                        { "categoryId", categoryId.ToString() },
                        { "subcategoryId", subcategoryId.ToString() },
                        { "batchNumber", batchNumber },
                        { "purchaseDate", purchaseDate },
                        { "expirationDate", expirationDate },
                        { "batchQuantity", batchQuantity.ToString() },
                        { "currentQuantity", currentQuantity.ToString() },
                        { "unitTypeId", unitTypeId.ToString() },
                        { "unitMeasureId", unitMeasureId.ToString() },
                        { "minStock", minStock.ToString() },
                        { "maxStock", maxStock.ToString() },
                        { "reorderPoint", reorderPoint.ToString() },
                        { "leadTime", leadTime.ToString() },
                        { "turnOver", turnOver.ToString() },
                        { "unitCost", unitCost.ToString() },
                        { "supplierId", supplierId?.ToString() ?? "" },
                        { "enableLowStockAlert", enableLowStockAlert ? "1" : "0" }
                    }
                });

                if (response == null)
                {
                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        string inventoryDetails = $"Item: {itemName}, Batch: {batchNumber}, Qty: {batchQuantity}{CurrentInventoryUnitMeasure.Current?.measureName}, Cost: {unitCost:C}";

                        await _auditService.Log(new AuditRecord
                        {
                            UserId = CurrentUser.Current!.UserId,
                            Action = AuditActionType.Update,
                            Description = "Inventory item updated successfully",
                            OldValue = "Previous inventory values not tracked here",
                            NewValue = inventoryDetails,
                            EntityType = AuditEntityType.Inventory,
                            EntityId = itemId.ToString()
                        });

                        return true;
                    }
                    else
                    {
                        string errorMessage = "Inventory update failed: " +
                            (response.Data.ContainsKey("message") ? response.Data["message"] : "Unknown error occurred");

                        MessageBox.Show(errorMessage, "Inventory Update Failed",
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<InventoryItem>> GetAllInventoryItems()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetInventoryItem
            });


            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
                return new List<InventoryItem>();
            }

            Logger.Write("GET ALL INVENTORY ITEMS", $"Response Data: {response.Data["inventoryitems"]}");

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string inventoryItemsJson = response.Data["inventoryitems"];
                    List<InventoryItem>? inventoryItems = JsonSerializer.Deserialize<List<InventoryItem>>(
                        inventoryItemsJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventoryItem.SetItems(inventoryItems);

                    return inventoryItems ?? new List<InventoryItem>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve inventory items: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Inventory Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<InventoryItem>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<InventoryItem>();
            }
        }

        public async Task<bool> CreateBatch(int itemId, string? batchNumber, string? purchaseDate,
            string? expirationDate, decimal quantity, decimal unitCost, int? supplierId, bool isActive)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateBatch,
                Data = new Dictionary<string, string>
                {
                    { "itemId", itemId.ToString() },
                    { "batchNumber", batchNumber ?? "" },
                    { "purchaseDate", purchaseDate ?? "" },
                    { "expirationDate", expirationDate ?? "" },
                    { "quantity", quantity.ToString() },
                    { "unitCost", unitCost.ToString() },
                    { "supplierId", supplierId?.ToString() ?? "" },
                    { "isActive", isActive.ToString().ToLower() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to create batch. Server not responding.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE BATCH", $"Batch '{batchNumber}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Batch created successfully",
                        OldValue = "No batch existed",
                        NewValue = $"New batch: {batchNumber}",
                        EntityType = AuditEntityType.Batch,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating batch";

                    Logger.Write("CREATE BATCH", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create batch: {errorMessage}", "Batch Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                Logger.Write("CREATE BATCH", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating batch.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> UpdateBatch(Dictionary<string, object> batchUpdateData)
        {
            var batchId = batchUpdateData["OldBatchId"]?.ToString() ?? "";
            var itemId = batchUpdateData["OldItemId"]?.ToString() ?? "";
            var oldBatchNumber = batchUpdateData["OldBatchNumber"]?.ToString() ?? "";
            var newBatchNumber = batchUpdateData["NewBatchNumber"]?.ToString() ?? "";

            var oldPurchaseDate = (DateTime)batchUpdateData["OldPurchaseDate"];
            var newPurchaseDate = (DateTime)batchUpdateData["NewPurchaseDate"];

            var oldExpirationDate = (DateTime)batchUpdateData["OldExpirationDate"];
            var newExpirationDate = (DateTime)batchUpdateData["NewExpirationDate"];

            var oldInitialQuantity = (decimal)batchUpdateData["OldInitialQuantity"];
            var newInitialQuantity = (decimal)batchUpdateData["NewInitialQuantity"];

            var oldCurrentQuantity = (decimal)batchUpdateData["OldCurrentQuantity"];
            var newCurrentQuantity = (decimal)batchUpdateData["NewCurrentQuantity"];

            var oldUnitCost = (decimal)batchUpdateData["OldUnitCost"];
            var newUnitCost = (decimal)batchUpdateData["NewUnitCost"];

            var oldSupplierId = batchUpdateData["OldSupplierId"]?.ToString() ?? "";
            var newSupplierId = batchUpdateData["NewSupplierId"].ToString() ?? "";

            var oldSupplierName = batchUpdateData["OldSupplierName"]?.ToString() ?? "";
            var newSupplierName = batchUpdateData["NewSupplierName"]?.ToString() ?? "";

            var newIsActive = (bool)batchUpdateData["NewIsActive"];

            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.UpdateBatch,
                Data = new Dictionary<string, string>
                {
                    { "batchId", batchId },
                    { "itemId", itemId },
                    { "batchNumber", newBatchNumber },
                    { "purchaseDate", newPurchaseDate.ToString("yyyy-MM-dd") },
                    { "expirationDate", newExpirationDate.ToString("yyyy-MM-dd") },
                    { "initialQuantity", newInitialQuantity.ToString() },
                    { "currentQuantity", newCurrentQuantity.ToString() },
                    { "unitCost", newUnitCost.ToString() },
                    { "supplierId", newSupplierId },
                    { "isActive", newIsActive.ToString().ToLower() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to update batch. Server not responding.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("UPDATE BATCH", $"Batch '{newBatchNumber}' updated successfully");

                    var oldValues = new List<string>();
                    var newValues = new List<string>();
                    var descriptionChanges = new List<string>();

                    if (oldPurchaseDate != newPurchaseDate)
                    {
                        oldValues.Add($"Purchase Date: {oldPurchaseDate:yyyy-MM-dd}");
                        newValues.Add($"Purchase Date: {newPurchaseDate:yyyy-MM-dd}");
                        descriptionChanges.Add("Purchase Date changed");
                    }
                    if (oldExpirationDate != newExpirationDate)
                    {
                        oldValues.Add($"Expiration Date: {oldExpirationDate:yyyy-MM-dd}");
                        newValues.Add($"Expiration Date: {newExpirationDate:yyyy-MM-dd}");
                        descriptionChanges.Add("Expiration Date changed");
                    }
                    if (oldInitialQuantity != newInitialQuantity)
                    {
                        oldValues.Add($"Initial Quantity: {oldInitialQuantity}");
                        newValues.Add($"Initial Quantity: {newInitialQuantity}");
                        descriptionChanges.Add("Initial Quantity changed");
                    }
                    if (oldCurrentQuantity != newCurrentQuantity)
                    {
                        oldValues.Add($"Current Quantity: {oldCurrentQuantity}");
                        newValues.Add($"Current Quantity: {newCurrentQuantity}");
                        descriptionChanges.Add("Current Quantity changed");
                    }
                    if (oldUnitCost != newUnitCost)
                    {
                        oldValues.Add($"Unit Cost: {oldUnitCost}");
                        newValues.Add($"Unit Cost: {newUnitCost}");
                        descriptionChanges.Add("Unit Cost changed");
                    }
                    if (oldSupplierName != newSupplierName)
                    {
                        oldValues.Add($"Supplier: {oldSupplierName}");
                        newValues.Add($"Supplier: {newSupplierName}");
                        descriptionChanges.Add("Supplier changed");
                    }

                    if (oldValues.Count == 0)
                    {
                        oldValues.Add("No changes");
                        newValues.Add("No changes");
                        descriptionChanges.Add("No fields changed");
                    }

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Update,
                        Description = $"Batch updated: {string.Join(", ", descriptionChanges)}",
                        OldValue = string.Join(", ", oldValues),
                        NewValue = string.Join(", ", newValues),
                        EntityType = AuditEntityType.Batch,
                        EntityId = batchId
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while updating batch";

                    Logger.Write("UPDATE BATCH", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to update batch: {errorMessage}", "Batch Update Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                Logger.Write("UPDATE BATCH", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while updating batch.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<Dictionary<string, object>>> GetBatch(string? itemId)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetBatch,
                Data = new Dictionary<string, string>
                {
                    { "itemId", itemId! }
                }
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server (GetBatch)");
                return new List<Dictionary<string, object>>();
            }

            Logger.Write("GET BATCH", $"Response Data: {response.Data}");

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    if (response.Data.ContainsKey("batches"))
                    {
                        string batchesJson = response.Data["batches"];

                        try
                        {
                            var rawBatches = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(
                                batchesJson,
                                new JsonSerializerOptions
                                {
                                    PropertyNameCaseInsensitive = true
                                }
                            );

                            var batches = new List<Dictionary<string, object>>();

                            foreach (var rawBatch in rawBatches!)
                            {
                                var batch = new Dictionary<string, object>();

                                foreach (var kvp in rawBatch)
                                {
                                    object value;

                                    switch (kvp.Value.ValueKind)
                                    {
                                        case JsonValueKind.String:
                                            value = kvp.Value.GetString()!;
                                            break;
                                        case JsonValueKind.Number:
                                            if (kvp.Value.TryGetInt32(out int intValue))
                                                value = intValue;
                                            else if (kvp.Value.TryGetInt64(out long longValue))
                                                value = longValue;
                                            else if (kvp.Value.TryGetDouble(out double doubleValue))
                                                value = doubleValue;
                                            else
                                                value = kvp.Value.ToString()!;
                                            break;
                                        case JsonValueKind.True:
                                        case JsonValueKind.False:
                                            value = kvp.Value.GetBoolean();
                                            break;
                                        case JsonValueKind.Null:
                                            value = string.Empty;
                                            break;
                                        default:
                                            value = kvp.Value.ToString()!;
                                            break;
                                    }

                                    batch.Add(kvp.Key, value);
                                }

                                batches.Add(batch);
                            }

                            return batches;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to parse batch data: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Logger.Write("DESERIALIZATION ERROR", ex.Message);
                            return new List<Dictionary<string, object>>();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No batch data found in the response.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new List<Dictionary<string, object>>();
                    }
                }
                else
                {
                    string errorMessage = "Failed to retrieve batches: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Batch Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Dictionary<string, object>>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Dictionary<string, object>>();
            }
        }
    }
}
