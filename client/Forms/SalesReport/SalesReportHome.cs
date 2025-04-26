using client.Controllers;
using client.Forms.Order;
using client.Helpers;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.SalesReport
{
    public partial class SalesReportHome : Form
    {
        SalesReportController _salesReportController = new SalesReportController();
        public SalesReportHome()
        {
            InitializeComponent();

            PaymentForm.OnSalesReportUpdated += FetchAndDisplay;
        }

        private void SalesReportHome_Shown(object sender, EventArgs e)
        {
            var salesReportCount = CurrentSalesReport.AllSalesReports.Count;
            
            if (salesReportCount > 0)
            {
                DisplaySalesReport();
            }
            else
            {
                FetchAndDisplay();
            }
        }

        private void SalesReportHome_Load(object sender, EventArgs e)
        {
            
        }

        public async void FetchAndDisplay()
        {
            await FetchSalesReport();
            DisplaySalesReport();
        }

        private async Task FetchSalesReport()
        {
            try
            {
                ShowLoading("Fetching salesreport, please wait...");
                await _salesReportController.GetAllSalesReports();
            }
            catch(Exception ex)
            {
                HideLoading();
                Logger.Write("FETCH_SALESREPORT", $"Failed to fetch salesreport: {ex.Message}");
                MessageBox.Show($"Error fetching salesreport: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideLoading();
            }
        }

        private void DisplaySalesReport()
        {
            ShowLoading("Displaying sales report, please wait...");

            try
            {
                var salesReport = CurrentSalesReport.AllSalesReports;

                if (salesReport != null && salesReport.Any())
                {
                    Logger.Write("SALES_REPORT_DEBUG", $"Processing {salesReport.Count} sales reports...");
                    int processedCount = 0;

                    foreach (var salesreport in salesReport)
                    {
                        try
                        {
                            string transNo = salesreport?.TransactionNo ?? string.Empty;
                            string cashierFullName = $"{CapitalizeFirstLetter(salesreport?.CashierFName)} {CapitalizeFirstLetter(salesreport?.CashierLName)}";

                            string orderTime = string.Empty;
                            string orderDate = string.Empty;

                            if (salesreport != null)
                            {
                                try
                                {
                                    orderTime = salesreport.OrderTime != default
                                        ? salesreport.OrderTime.ToString("hh:mm:ss tt").ToUpper()
                                        : string.Empty;
                                }
                                catch (Exception timeEx)
                                {
                                    Logger.Write("SALES_REPORT_DEBUG_ERROR", $"Error formatting OrderTime: {timeEx.Message}");
                                    orderTime = "Invalid Time";
                                }

                                try
                                {
                                    orderDate = salesreport.OrderDate != default
                                        ? salesreport.OrderDate.ToString("MM/dd/yyyy")
                                        : string.Empty;
                                }
                                catch (Exception dateEx)
                                {
                                    Logger.Write("SALES_REPORT_DEBUG_ERROR", $"Error formatting OrderDate: {dateEx.Message}");
                                    orderDate = "Invalid Date";
                                }
                            }

                            dgvOrders.Rows.Add(
                                salesreport?.Id,
                                transNo,
                                cashierFullName,
                                $"{salesreport?.Price ?? 0.00m:C}",
                                salesreport?.Quantity.ToString() ?? "0",
                                $"{salesreport?.Discount ?? 0.00m:C}",
                                $"{salesreport?.TotalPrice ?? 0.00m:C}",
                                orderTime,
                                orderDate
                            );

                            processedCount++;
                        }
                        catch (Exception rowEx)
                        {
                            Logger.Write("SALES_REPORT_ROW_ERROR",
                                $"Error processing row {processedCount + 1}. " +
                                $"Error: {rowEx.Message}. " +
                                $"StackTrace: {rowEx.StackTrace}");

                            continue;
                        }
                    }

                    dgvOrders.ClearSelection();
                    HideLoading();
                }
                else
                {
                    HideLoading();
                    Logger.Write("SALES_REPORT_DEBUG", "No sales reports to display.");
                    MessageBox.Show("No sales reports found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HideLoading();
                Logger.Write("SALES_REPORT_ERROR",
                    $"Critical error: {ex.Message}. " +
                    $"Stack Trace: {ex.StackTrace}");

                MessageBox.Show($"Error loading sales reports: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string CapitalizeFirstLetter(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private Label messageLabel = new Label();

        private void InitializeLoadingControls()
        {
            loadingPanel.BackColor = Color.White;
            loadingPanel.BorderStyle = BorderStyle.None;
            loadingPanel.Size = new Size(300, 150);
            loadingPanel.Location = new Point(
                (this.ClientSize.Width - loadingPanel.Width) / 2,
                (this.ClientSize.Height - loadingPanel.Height) / 2
            );

            panelBox.Size = new Size(64, 64);
            panelBox.Location = new Point(
                (loadingPanel.Width - panelBox.Width) / 2,
                20
            );
            panelBox.BorderStyle = BorderStyle.None;
            panelBox.BackColor = Color.White;

            pictureBox.Size = new Size(24, 24);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(
                (panelBox.Width - pictureBox.Width) / 2,
                (panelBox.Height - pictureBox.Height) / 2
            );

            try
            {
                pictureBox.Image = Properties.Resources.loading_gif;
            }
            catch
            {
                pictureBox.BackColor = Color.LightGray;
            }

            messageLabel.AutoSize = false;
            messageLabel.Size = new Size(280, 30);
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Location = new Point(
                (loadingPanel.Width - messageLabel.Width) / 2,
                panelBox.Bottom + 8
            );
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            panelBox.Controls.Add(pictureBox);
            loadingPanel.Controls.Add(panelBox);
            loadingPanel.Controls.Add(messageLabel);
            this.Controls.Add(loadingPanel);
        }

        private void ShowLoading(string message)
        {
            if (!this.Controls.Contains(loadingPanel))
            {
                InitializeLoadingControls();
            }

            messageLabel.Text = message;
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;
            Application.DoEvents();
        }

        private void HideLoading()
        {
            if (loadingPanel != null)
            {
                loadingPanel.Visible = false;
            }
        }
    }
}
