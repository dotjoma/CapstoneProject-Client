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
                        { "purchaseDate", purchaseDate.ToString() },
                        { "expirationDate", expirationDate.ToString() },
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
    }
}
