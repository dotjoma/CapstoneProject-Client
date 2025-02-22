using client.Forms.POS.POSUserControl;
using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client.Controllers
{
    public class CategoryController
    {
        public async Task<bool> Create(string name)
        {
            var createCategoryPacket = new Packet
            {
                Type = PacketType.CreateCategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name }
                }
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(createCategoryPacket));

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
                    LoggerHelper.Write("CREATE CATEGORY", $"Category '{name}' created successfully");

                    return true;
                }
                else
                {
                    // Handle error response
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating category";

                    LoggerHelper.Write("CREATE CATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create category: {errorMessage}", "Category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                LoggerHelper.Write("CREATE CATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Get()
        {
            var getCategoryPacket = new Packet
            {
                Type = PacketType.GetCategory
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(getCategoryPacket));

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("RESPONSE", $"No response received from server");
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

                    LoggerHelper.Write("GET CATEGORY", categories?.Count > 0
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
    }
}
