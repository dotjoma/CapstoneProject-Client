using client.Controllers;
using client.Helpers;
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

namespace client.Forms.AuditTrail
{
    public partial class AuditHome : Form
    {
        AuditTrailController _auditTrailController = new AuditTrailController();
        public AuditHome()
        {
            InitializeComponent();
        }

        private void AuditHome_Load(object sender, EventArgs e)
        {

        }

        public async void FetchAndDisplay()
        {
            await FetchAuditLogs();
            DisplayAuditLogs();
        }

        private async Task FetchAuditLogs()
        {
            try
            {
                ShowLoading("Fetching salesreport, please wait...");
                await _auditTrailController.GetAllAudits();
            }
            catch (Exception ex)
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

        private void DisplayAuditLogs()
        {
            ShowLoading("Displaying audit logs, please wait...");
            Logger.Write("AUDIT_LOG_DEBUG", "Starting audit log display...");

            try
            {
                var auditLogs = CurrentAudit.AllAudits;
                Logger.Write("AUDIT_LOG_DEBUG", $"Retrieved audit logs. Count: {auditLogs?.Count ?? 0}");

                if (auditLogs != null && auditLogs.Any())
                {
                    Logger.Write("AUDIT_LOG_DEBUG", $"Processing {auditLogs.Count} audit logs...");
                    int processedCount = 0;

                    // Clear existing rows first
                    dgvAudit.Rows.Clear();

                    foreach (var audit in auditLogs)
                    {
                        try
                        {
                            string formattedDate = string.Empty;
                            if (audit != null && audit.Date != default)
                            {
                                try
                                {
                                    formattedDate = audit.Date.ToString("MM/dd/yyyy HH:mm:ss");
                                }
                                catch (Exception dateEx)
                                {
                                    Logger.Write("AUDIT_LOG_DATE_ERROR", $"Error formatting Date: {dateEx.Message}");
                                    formattedDate = "Invalid Date";
                                }
                            }

                            dgvAudit.Rows.Add(
                                formattedDate,
                                audit?.Name,
                                audit?.Action,
                                audit?.Description,
                                audit?.PrevValue,
                                audit?.NewValue,
                                audit?.Entity,
                                audit?.EntityId
                            );

                            processedCount++;
                        }
                        catch (Exception rowEx)
                        {
                            Logger.Write("AUDIT_LOG_ROW_ERROR",
                                $"Error processing row {processedCount + 1}. " +
                                $"Error: {rowEx.Message}. " +
                                $"StackTrace: {rowEx.StackTrace}");

                            continue;
                        }
                    }

                    HideLoading();
                }
                else
                {
                    HideLoading();
                    Logger.Write("AUDIT_LOG_DEBUG", "No audit logs to display.");
                    MessageBox.Show("No audit logs found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HideLoading();
                Logger.Write("AUDIT_LOG_ERROR",
                    $"Critical error: {ex.Message}. " +
                    $"Stack Trace: {ex.StackTrace}");

                MessageBox.Show($"Error loading audit logs: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuditHome_Shown(object sender, EventArgs e)
        {
            FetchAndDisplay();
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
