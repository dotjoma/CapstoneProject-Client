using client.Controllers;
using client.Models.Audit;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.BackupControl
{
    public partial class RestoreBackupForm : Form
    {
        private string _defaultBackupPath = string.Empty;
        private string _selectedBackupPath = string.Empty;
        private string? _selectedBackupFile = string.Empty;

        private ToolTip toolTip = new ToolTip();

        BackupController _backupController = new BackupController();

        public string AuthPassword { get; set; } = string.Empty;
        public string AuthStatus { get; set; } = string.Empty;

        public RestoreBackupForm(string defaultBackupPath)
        {
            InitializeComponent();
            flpAvailableBackups.Resize += flpAvailableBackups_Resize;
            _defaultBackupPath = defaultBackupPath;
        }

        private void RestoreBackupForm_Load(object sender, EventArgs e)
        {
            LoadBackupFiles();
            btnRestore.Enabled = false;
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
        }

        private void LoadBackupFiles()
        {
            flpAvailableBackups.Controls.Clear();

            if (Directory.Exists(_defaultBackupPath))
            {
                // Get all .sql and .zip files regardless of name
                var backupFiles = Directory.GetFiles(_defaultBackupPath, "*.sql")
                                 .Concat(Directory.GetFiles(_defaultBackupPath, "*.zip"))
                                 .OrderByDescending(f => new FileInfo(f).CreationTime) // Newest first
                                 .ToArray();

                flpAvailableBackups.SuspendLayout();

                foreach (string file in backupFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string fileNameWithExtension = fileInfo.Name; // Full filename with extension
                    string filePath = fileInfo.FullName;
                    string fileSize = (fileInfo.Length / 1024.0 / 1024.0).ToString("0.00") + " MB"; // Now in MB
                    string fileType = fileInfo.Extension.ToUpper().TrimStart('.'); // Shows "SQL" or "ZIP"

                    int panelWidth = flpAvailableBackups.ClientSize.Width - 10;

                    Panel filePanel = new Panel
                    {
                        Width = panelWidth,
                        Height = 50, // Slightly taller
                        BackColor = Color.FromArgb(240, 240, 240), // Light gray
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(5),
                        Margin = new Padding(3, 3, 3, 10), // More bottom margin
                        Tag = filePath,
                        Cursor = Cursors.Hand // Hand cursor on hover
                    };

                    // File name label (now shows full filename with extension)
                    Label lblFileName = new Label
                    {
                        Text = fileNameWithExtension,
                        Width = (int)(panelWidth * 0.60),
                        Location = new Point(5, 15),
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true,
                        Font = new Font("Segoe UI", 9, FontStyle.Regular)
                    };

                    // File type label
                    Label lblFileType = new Label
                    {
                        Text = fileType,
                        Width = 50,
                        Location = new Point((int)(panelWidth * 0.60) + 10, 15),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = fileType == "SQL" ? Color.DarkGreen : Color.DarkBlue,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold)
                    };

                    // File size label
                    Label lblFileSize = new Label
                    {
                        Text = fileSize,
                        Width = (int)(panelWidth * 0.20),
                        Location = new Point((int)(panelWidth * 0.80) - 10, 15),
                        TextAlign = ContentAlignment.MiddleRight,
                        Font = new Font("Segoe UI", 9, FontStyle.Regular)
                    };

                    filePanel.Controls.Add(lblFileName);
                    filePanel.Controls.Add(lblFileType);
                    filePanel.Controls.Add(lblFileSize);

                    // Add hover effects
                    filePanel.MouseEnter += (s, e) => filePanel.BackColor = Color.FromArgb(220, 220, 220);
                    filePanel.MouseLeave += (s, e) => filePanel.BackColor = Color.FromArgb(240, 240, 240);

                    // Click events
                    filePanel.Click += FilePanel_Click;
                    lblFileName.Click += FilePanel_Click;
                    lblFileType.Click += FilePanel_Click;
                    lblFileSize.Click += FilePanel_Click;

                    flpAvailableBackups.Controls.Add(filePanel);
                }

                flpAvailableBackups.ResumeLayout();
            }
            else
            {
                Label noFilesLabel = new Label
                {
                    Text = "No backup files found",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    ForeColor = Color.Gray
                };
                flpAvailableBackups.Controls.Add(noFilesLabel);
            }
        }

        private void FilePanel_Click(object? sender, EventArgs e)
        {
            Panel? clickedPanel = sender as Panel;

            if (clickedPanel == null && sender is Label label)
            {
                clickedPanel = label.Parent as Panel;
            }

            if (clickedPanel == null) return;

            foreach (Panel panel in flpAvailableBackups.Controls.OfType<Panel>())
            {
                panel.BorderStyle = BorderStyle.None;
            }

            clickedPanel.BorderStyle = BorderStyle.FixedSingle;

            _selectedBackupFile = clickedPanel.Tag?.ToString();

            btnRestore.Enabled = true;
        }

        private void flpAvailableBackups_Resize(object? sender, EventArgs e)
        {
            foreach (Panel panel in flpAvailableBackups.Controls.OfType<Panel>())
            {
                panel.Width = flpAvailableBackups.ClientSize.Width - 15;
            }
        }

        private void btnRemoveBrowsed_Click(object sender, EventArgs e)
        {
            btnRemoveBrowsed.Visible = false;
            lblSelectedPath.Visible = false;
            _selectedBackupPath = string.Empty;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files (*.zip;*.enc)|*.zip;*.enc|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedBackupPath = openFileDialog.FileName;
                    lblSelectedPath.Text = _selectedBackupPath;
                }
                if (!(string.IsNullOrEmpty(_selectedBackupPath)))
                {
                    lblSelectedPath.Visible = true;
                    btnRemoveBrowsed.Visible = true;
                    toolTip.SetToolTip(lblSelectedPath, _selectedBackupPath);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        AuditService _auditService = new AuditService();
        private async void btnRestore_Click(object sender, EventArgs e)
        {
            var authform = new AuthForm(null!, this);
            authform.ShowDialog();

            if (!(AuthStatus == "authenticated"))
                return;

            if (string.IsNullOrEmpty(_selectedBackupFile))
            {
                MessageBox.Show("Please select a backup file from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = await _backupController.RestoreBackupAsync(_selectedBackupFile);

            if (success)
            {
                //MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await _auditService.Log(new AuditRecord
                {
                    UserId = CurrentUser.Current!.UserId,
                    Action = AuditActionType.RestoreBackup,
                    Description = "Database restoration completed successfully",
                    OldValue = $"",
                    NewValue = $"Restored from backup: {_selectedBackupFile}",
                    EntityType = AuditEntityType.Restore,
                    EntityId = ""
                });
            }

            this.Dispose();
        }
    }
}
