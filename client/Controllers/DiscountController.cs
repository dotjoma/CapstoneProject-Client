using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class DiscountController
    {
        public async Task<bool> Create(string name, string type, decimal value, int vatExempt, int status, List<int> categoryIds)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Unit name cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Unit description cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (value <= 0)
            {
                MessageBox.Show("Enter value.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var createDiscountPacket = new Packet
            {
                Type = PacketType.CreateDiscount,
                Data = new Dictionary<string, string>
                {
                    { "name", name},
                    { "type", type.ToLower() },
                    { "value", value.ToString() },
                    { "vatExempt", vatExempt.ToString() },
                    { "status", status.ToString() },
                    { "categoryIds", JsonConvert.SerializeObject(categoryIds) }
                }
            };

            try
            {
                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(createDiscountPacket));

                if (response == null)
                {
                    MessageBox.Show("Failed to create unit. Server not responding.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (response.Data?.ContainsKey("success") == true && response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    LoggerHelper.Write("CREATE DISCOUNT", $"Discount '{name}' created successfully");
                    return true;
                }
                else
                {
                    string errorMessage = response.Data?.ContainsKey("message") == true ? response.Data["message"] : "Unknown error occurred while creating unit";
                    LoggerHelper.Write("CREATE DISCOUNT", $"Server error: {errorMessage}");
                    MessageBox.Show($"Failed to create discount: {errorMessage}", "Discount Creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("CREATE DISCOUNT", $"Exception: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<Discount>> GetAllDiscounts()
        {
            var getAllDiscountPacket = new Packet
            {
                Type = PacketType.GetDiscount
            };

            var response = await Client.Instance.SendToServerAndWaitResponse(getAllDiscountPacket);
            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("RESPONSE", "No response received from server");
                return new List<Discount>();
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string discountsJson = response.Data["discounts"];
                    List<Discount>? discounts = System.Text.Json.JsonSerializer.Deserialize<List<Discount>>(
                        discountsJson,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                    );

                    CurrentDiscount.SetDiscounts(discounts ?? new List<Discount>());

                    LoggerHelper.Write("GET ALL DISCOUNTS", discounts?.Count > 0
                        ? $"Retrieved {discounts.Count} discounts successfully"
                        : "No discounts found");

                    return discounts ?? new List<Discount>();
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

                    MessageBox.Show(errorMessage, "Discount Retrieve Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Discount>();
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Discount>();
            }
        }
    }
}
