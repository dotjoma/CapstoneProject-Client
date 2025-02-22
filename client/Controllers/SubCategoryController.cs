using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class SubCategoryController
    {
        public async Task<bool> Create(string name, int categoryId)
        {
            var createSubCategoryPacket = new Packet
            {
                Type = PacketType.CreateSubCategory,
                Data = new Dictionary<string, string>
                {
                    { "name", name },
                    { "categoryId", categoryId.ToString() }
                }
            };

            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(createSubCategoryPacket));

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
                    LoggerHelper.Write("CREATE SUBCATEGORY", $"Sub-category '{name}' created successfully");

                    return true;
                }
                else
                {
                    string errorMessage = response.Data.ContainsKey("message")
                        ? response.Data["message"]
                        : "Unknown error occurred while creating sub-category";

                    LoggerHelper.Write("CREATE SUBCATEGORY", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create sub-category: {errorMessage}", "Sub-category Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                LoggerHelper.Write("CREATE SUBCATEGORY", "Invalid server response format");
                MessageBox.Show("Server returned an invalid response format while creating sub-category.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Get(int selectedCategoryId)
        {
            try
            {
                var getSubCategoryPacket = new Packet
                {
                    Type = PacketType.GetSubCategory,
                    Data = new Dictionary<string, string>()
                    {
                        { "catId", selectedCategoryId.ToString() }
                    }
                };

                var response = await Client.Instance.SendToServerAndWaitResponse(getSubCategoryPacket);
                if (response == null)
                {
                    LoggerHelper.Write("GET SUBCATEGORY", "No response from server");
                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        LoggerHelper.Write("GET SUBCATEGORY", "Sub category retrieved successful");

                        if (response.Data.ContainsKey("subcategories"))
                        {
                            try
                            {
                                var subcategories = System.Text.Json.JsonSerializer
                                    .Deserialize<List<SubCategory>>(response.Data["subcategories"]);

                                if (subcategories != null)
                                {
                                    CurrentSubCategory.SetSubCategories(subcategories);
                                    LoggerHelper.Write("GET SUBCATEGORY", $"Successfully stored {subcategories.Count} subcategories");
                                    return true;
                                }
                            }
                            catch (Exception ex)
                            {
                                LoggerHelper.Write("GET SUBCATEGORY", $"Error deserializing subcategories: {ex.Message}");
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
                LoggerHelper.Write("GET SUBCATEGORY", $"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
