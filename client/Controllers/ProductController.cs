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
        public async Task<bool> Create(string name, string image, string price, string description, string category)
        {
            var createProductPacket = new Packet
            {
                Type = PacketType.CreateProduct,
                Data = new Dictionary<string, string>
                {
                    { "name", name },
                    { "image", image },
                    { "price", price },
                    { "description", description },
                    { "category", category }
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
