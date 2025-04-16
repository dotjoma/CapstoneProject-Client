using client.Forms.POS.POSUserControl;
using client.Forms.POS.POSUserControl.ProductFoodCategory;
using client.Forms.UserManagement;
using client.Helpers;
using client.Models;
using client.Models.Audit;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client.Controllers
{
    public class CategoryController
    {
        AuditService _auditService = new AuditService();
        public async Task<bool> Create(string name)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateCategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to create category. Server not responding.", 
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE CATEGORY", $"Category '{name}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Category created successfully",
                        OldValue = "No category existed",
                        NewValue = $"New category: {name}",
                        EntityType = AuditEntityType.Category,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    // Handle error response
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating category";

                    Logger.Write("CREATE CATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create category: {errorMessage}", "Category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                Logger.Write("CREATE CATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Get()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetCategory
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", $"No response received from server");
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string categoriesJson = response.Data["categories"];
                    List<Category>? categories = JsonSerializer.Deserialize<List<Category>>(
                        categoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentCategory.SetCategories(categories ?? new List<Category>());

                    Logger.Write("GET CATEGORY", categories?.Count > 0
                        ? $"Retrieved {categories.Count} categories successfully"
                        : "No categories found");

                    return true;
                }
                else
                {
                    string errorMessage = "Category retrieved failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Category retrieved Failed",
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

        public async Task<List<Category>> GetAllCategories()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetCategory
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
                return new List<Category>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string categoriesJson = response.Data["categories"];
                    List<Category>? categories = JsonSerializer.Deserialize<List<Category>>(
                        categoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentCategory.SetCategories(categories ?? new List<Category>());

                    Logger.Write("GET ALL CATEGORIES", categories?.Count > 0
                        ? $"Retrieved {categories.Count} categories successfully"
                        : "No categories found");

                    return categories ?? new List<Category>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve categories: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Category Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Category>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Category>();
            }
        }

        public async Task<bool> CreateInventoryCategory(string name)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateInventoryCategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name }
                }
            });

            if (response == null)
            {
                MessageBox.Show("Failed to create inventory category. Server not responding.",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    Logger.Write("CREATE INVENTORY CATEGORY", $"Inventory category '{name}' created successfully");

                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Inventory category created successfully",
                        OldValue = "No category existed",
                        NewValue = $"New inventory category: {name}",
                        EntityType = AuditEntityType.InventoryCategory,
                        EntityId = ""
                    });

                    //MessageBox.Show($"Inventory category '{name}' created successfully.", "Category Created",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating inventory category";

                    Logger.Write("CREATE INVENTORY CATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create inventory category: {errorMessage}", "Inventory Category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                Logger.Write("CREATE INVENTORY CATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating inventory category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> GetInventoryCategory()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetInventoryCategory
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", $"No response received from server");
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string categoriesJson = response.Data["categories"];
                    List<InventoryCategory>? categories = JsonSerializer.Deserialize<List<InventoryCategory>>(
                        categoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventoryCategory.SetInventoryCategories(categories ?? new List<InventoryCategory>());

                    Logger.Write("GET INVENTORY CATEGORY", categories?.Count > 0
                        ? $"Retrieved {categories.Count} categories successfully"
                        : "No categories found");

                    return true;
                }
                else
                {
                    string errorMessage = "Category retrieval failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Category Retrieval Failed",
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

        public async Task<List<InventoryCategory>> GetAllInventoryCategories()
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetInventoryCategory
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server");
                return new List<InventoryCategory>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string categoriesJson = response.Data["categories"];
                    List<InventoryCategory>? categories = JsonSerializer.Deserialize<List<InventoryCategory>>(
                        categoriesJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentInventoryCategory.SetInventoryCategories(categories ?? new List<InventoryCategory>());

                    Logger.Write("GET ALL INVENTORY CATEGORIES", categories?.Count > 0
                        ? $"Retrieved {categories.Count} inventory categories successfully"
                        : "No inventory categories found");

                    return categories ?? new List<InventoryCategory>();
                }
                else
                {
                    string errorMessage = "Failed to retrieve inventory categories: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Inventory Category Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<InventoryCategory>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<InventoryCategory>();
            }
        }
    }
}
