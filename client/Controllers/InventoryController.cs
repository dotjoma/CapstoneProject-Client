using client.Models.Audit;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class InventoryController
    {
        AuditService _auditService = new AuditService();

        public async Task<bool> CreateInventoryItem(
            string itemName, string category, string subcategory, string batchNumber,
            DateTime purchaseDate, DateTime expirationDate, decimal batchQuantity,
            string unitType, string unitMeasure, decimal minStock, decimal maxStock,
            decimal reorderPoint, int leadTime, int turnOver, decimal unitCost, string supplier)
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

            if (expirationDate < purchaseDate)
            {
                MessageBox.Show("Expiration date cannot be before purchase date", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.CreateProduct,
                    Data = new Dictionary<string, string>
                    {
                        { "itemName", itemName },
                        { "category", category },
                        { "subCategory", subcategory },
                        { "batchNumber", batchNumber },
                        { "purchaseDate", purchaseDate.ToString() },
                        { "expirationDate", expirationDate.ToString() },
                        { "batchQuantity", batchQuantity.ToString() },
                        { "unitType", unitType },
                        { "unitMeasure", unitMeasure },
                        { "minStock", minStock.ToString() },
                        { "maxStock", maxStock.ToString() },
                        { "reorderPoint", reorderPoint.ToString() },
                        { "leadTime", leadTime.ToString() },
                        { "turnOver", turnOver.ToString() },
                        { "unitCost", unitCost.ToString() },
                        { "supplier", supplier }
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
                            $"Qty: {batchQuantity}{unitMeasure}, " +
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
    }
}
