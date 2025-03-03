using client.Helpers;
using client.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
