using client.Models;
using client.Network;
using client.Services;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using client.Forms.POS.POSUserControl;
using client.Helpers;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client.Controllers
{
    public class ProductController
    {
        public async Task<bool> Get()
        {
            try
            {
                var getProduct = new Packet()
                {
                    Type = PacketType.GetProduct,
                    Data = new Dictionary<string, string>()
                };

                LoggerHelper.Write("GET PRODUCT", "Sending request to server");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    DefaultBufferSize = 104857600 // 100MB buffer
                };

                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(getProduct));

                if (response?.Data != null &&
                    response.Data.ContainsKey("success") &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    if (response.Data.ContainsKey("products"))
                    {
                        var products = JsonSerializer.Deserialize<List<Product>>(
                            response.Data["products"],
                            options
                        );

                        if (products != null && products.Count > 0)
                        {
                            CurrentProduct.SetProducts(products);
                            LoggerHelper.Write("GET PRODUCT", $"Successfully retrieved {products.Count} products");
                            return true;
                        }
                    }
                }
                else
                {
                    string errorMessage = response?.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred";
                    LoggerHelper.Write("GET PRODUCT", $"Server returned error: {errorMessage}");
                }

                return false;
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("GET PRODUCT", $"Error: {ex.Message}");
                MessageBox.Show($"Error retrieving products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Create(string name, string image, string price, string description, int categoryId, int subcategoryId, int unitId)
        {
            var createProductPacket = new Packet
            {
                Type = PacketType.CreateProduct,
                Data = new Dictionary<string, string>
                {
                    { "pName", name },
                    { "image", image },
                    { "unitPrice", price },
                    { "pDesc", description },
                    { "catId", categoryId.ToString()},
                    { "scId", subcategoryId.ToString() },
                    { "unitId", unitId.ToString() }
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
                    MessageBox.Show("Product creation successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                else
                {
                    string errorMessage = "Product creation failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Product creation Failed",
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
