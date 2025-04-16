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
using static System.Windows.Forms.Design.AxImporter;

namespace client.Controllers
{
    public class SubCategoryController
    {
        AuditService _auditService = new AuditService();
        public async Task<bool> Create(string name, int categoryId)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateSubCategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name },
                    { "categoryId", categoryId.ToString() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to create sub-category. Server not responding.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE SUBCATEGORY", $"Sub-category '{name}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Subcategory created successfully",
                        OldValue = "No subcategory existed",
                        NewValue = $"Name: {name}",
                        EntityType = AuditEntityType.Subcategory,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating sub-category";

                    Logger.Write("CREATE SUBCATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create sub-category: {errorMessage}", "Sub-category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                Logger.Write("CREATE SUBCATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating sub-category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Get(int selectedCategoryId)
        {
            try
            {
                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GetSubCategory,
                    Data = new Dictionary<string, string>()
                    {
                        { "catId", selectedCategoryId.ToString() }
                    }
                });

                if (response == null)
                {
                    Logger.Write("GET SUBCATEGORY", "No response from server");
                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        Logger.Write("GET SUBCATEGORY", "Sub category retrieved successful");

                        if (response.Data.ContainsKey("subcategories"))
                        {
                            try
                            {
                                var subcategories = System.Text.Json.JsonSerializer
                                    .Deserialize<List<SubCategory>>(response.Data["subcategories"]);

                                if (subcategories != null)
                                {
                                    CurrentSubCategory.SetSubCategories(subcategories);
                                    Logger.Write("GET SUBCATEGORY", $"Successfully stored {subcategories.Count} subcategories");
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                Logger.Write("GET SUBCATEGORY", $"Error deserializing subcategories: {ex.Message}");
                                MessageBox.Show("Error processing subcategories data", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        string errorMessage = "Sub category retrieved failed: ";

                        if (response.Data.ContainsKey("message"))
                        {
                            errorMessage += response.Data["message"];
                        }
                        else
                        {
                            errorMessage += "Unknown error occurred";
                        }

                        MessageBox.Show(errorMessage, "Sub category retrieved Failed",
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
                Logger.Write("GET SUBCATEGORY", $"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<SubCategory>> GetAllSubcategory()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetAllSubcategory,
                Data = new Dictionary<string, string>()
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
                return new List<SubCategory>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("SUBCATEGORY DEBUG", $"Raw response: {JsonSerializer.Serialize(response.Data)}");

                    string subcategoriesJson = response.Data["subcategories"];
                    Logger.Write("SUBCATEGORY DEBUG", $"JSON string: {subcategoriesJson}");

                    List<SubCategory>? subcategories = JsonSerializer.Deserialize<List<SubCategory>>(
                        subcategoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    Logger.Write("SUBCATEGORY DEBUG", $"Deserialized count: {subcategories?.Count ?? 0}");
                    CurrentSubCategory.SetSubCategories(subcategories ?? new List<SubCategory>());

                    Logger.Write("SUBCATEGORY DEBUG",
                        $"Stored subcategories count: {CurrentSubCategory.AllSubCategories.Count}");

                    Logger.Write("GET ALL CATEGORIES", subcategories?.Count > 0
                        ? $"Retrieved {subcategories.Count} categories successfully"
                        : "No categories found");

                    return subcategories ?? new List<SubCategory>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve subcategories: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Subcategory Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<SubCategory>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<SubCategory>();
            }
        }

        public async Task<bool> CreateInventorySubCategory(string name, int categoryId)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateInventorySubcategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name },
                    { "categoryId", categoryId.ToString() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to create sub-category. Server not responding.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE INVENTORY SUBCATEGORY", $"Sub-category '{name}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Sub-category created successfully",
                        OldValue = "No subcategory existed",
                        NewValue = $"Name: {name}, CategoryId: {categoryId}",
                        EntityType = AuditEntityType.InventorySubCategory,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating sub-category";

                    Logger.Write("CREATE INVENTORY SUBCATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create sub-category: {errorMessage}", "Sub-category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                Logger.Write("CREATE INVENTORY SUBCATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating sub-category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<InventorySubCategory>> GetAllInventorySubcategory()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetAllInventorySubcategory,
                Data = new Dictionary<string, string>()
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventorySubCategory>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string subcategoriesJson = response.Data["subcategories"];

                    List<InventorySubCategory>? subcategories = JsonSerializer.Deserialize<List<InventorySubCategory>>(
                        subcategoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventorySubCategory.SetInventorySubCategories(subcategories ?? new List<InventorySubCategory>());

                    return subcategories ?? new List<InventorySubCategory>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve subcategories: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Subcategory Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return new List<InventorySubCategory>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<InventorySubCategory>();
            }
        }
    }
}
