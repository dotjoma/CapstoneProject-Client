using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class SalesReportController
    {
        public async Task<List<SalesReport>> GetAllSalesReports()
        {
            List<SalesReport> salesReports = new List<SalesReport>();

            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.GetSalesReport
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "No response received from server for sales reports");
                return salesReports;
            }

            if (response.Data != null)
            {
                if (response.Data.TryGetValue("success", out var successValue) &&
                    successValue.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    string salesReportsJson = response.Data["salesreports"];

                    try
                    {
                        salesReports = JsonSerializer.Deserialize<List<SalesReport>>(salesReportsJson,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<SalesReport>();
                    }
                    catch (JsonException ex)
                    {
                        Logger.Write("GET ALL SALES REPORTS", $"Deserialization failed: {ex.Message}");
                        salesReports = new List<SalesReport>();
                    }

                    CurrentSalesReport.SetSalesReports(salesReports);

                    Logger.Write("GET ALL SALES REPORTS", salesReports.Count > 0
                        ? $"Retrieved {salesReports.Count} sales reports successfully"
                        : "No sales reports found");

                    return salesReports;
                }
                else
                {
                    string errorMessage = "Failed to retrieve sales reports: ";
                    if (response.Data.TryGetValue("message", out var message))
                    {
                        errorMessage += message;
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Sales Reports Retrieval Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return salesReports;
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("RESPONSE", "Invalid response format received for sales reports");
                return salesReports;
            }
        }
    }
}
