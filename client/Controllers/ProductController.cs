using client.Network;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace client.Controllers
{
    public class ProductController
    {
        public async Task<bool> Create(string name, string description, string price, string image)
        {
            // Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Name and price are required fields", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(price, out decimal priceValue))
            {
                MessageBox.Show("Price must be a valid number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Create product packet to send to the server.
            var createProductPacket = new Packet
            {
                Type = PacketType.CreateProduct,
                Data = new Dictionary<string, string>
                {
                    { "name", name.Trim() },
                    { "description", description.Trim() ?? ""},
                    { "price", price.Trim()},
                    { "image", image ?? ""},
                }
            };

            // Send packet to the server and wait for a response
            var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(createProductPacket));

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Handle server response
            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Registration successful! Please login.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    string errorMessage = "Registration failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Registration Failed",
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
