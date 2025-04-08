using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using client.Controllers;
using client.Helpers;
using client.Models.Audit;
using client.Services.Auth;
using client.Services;

namespace client.Forms.BackupControl
{
    public partial class BackupPanel : Form
    {
        private string backupFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Elicias", "Backup");
        public string AuthPassword { get; set; } = string.Empty;
        public string AuthStatus { get; set; } = string.Empty;
        public List<string> SelectedTables { get; set; } = new List<string>();

        BackupController _backupController = new BackupController();

        AuditService _auditService = new AuditService();

        public BackupPanel()
        {
            InitializeComponent();
            EnsureBackupFolderExists();
        }

        private void BackupPanel_Load(object sender, EventArgs e)
        {
            cbAutoBackup.Enabled = true;
            cbAutoBackup.Text = "Auto Backup Enabled";
        }

        private void rbFullBackup_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbFullBackup.Checked)
            {
                rbSelectedBackup.Checked = false;
            }
        }

        private void rbSelectedBackup_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbSelectedBackup.Checked)
            {
                rbFullBackup.Checked = false;
            }

            var selectedDataForm = new SelectedDataForm(this);
            selectedDataForm.ShowDialog();
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Authentication
                var authform = new AuthForm(this, null!);
                authform.ShowDialog();

                if (!(AuthStatus == "authenticated"))
                    return;

                panel4.Location = new Point(214, 221);
                panel4.Visible = true;
                progressBar.Value = 10;
                lblDescription.Text = "Preparing backup... Do not close this window.";

                // Validation
                if (!IsFullBackup() && SelectedTables.Count <= 0)
                {
                    MessageBox.Show("Please select data to backup.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panel4.Visible = false;

                    var selectedDataForm = new SelectedDataForm(this);
                    selectedDataForm.ShowDialog();
                    return;
                }

                if (IsEmailNotificationEnabled() && string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Please provide an email first.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    panel4.Visible = false;
                    return;
                }

                progressBar.Value = 20;
                lblDescription.Text = "Creating database dump...";

                // Generate backup file name
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupFileName = $"Backup_{timestamp}.sql";
                string backupPath = Path.Combine(backupFolder, backupFileName);

                // Get backup from server (encrypted if enabled)
                string? backupFilePath = await _backupController.GetBackupDataAsync(
                    IsFullBackup(),
                    SelectedTables,
                    AuthPassword);

                progressBar.Value = 50;

                if (string.IsNullOrEmpty(backupFilePath) || !File.Exists(backupFilePath))
                {
                    MessageBox.Show("Backup creation failed!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel4.Visible = false;
                    return;
                }

                lblDescription.Text = "Compressing backup file...";
                progressBar.Value = 60;

                // Compress the SQL file
                string zipFileName = $"Backup_{timestamp}.zip";
                string zipPath = Path.Combine(backupFolder, zipFileName);

                using (FileStream zipStream = File.Create(zipPath))
                using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(backupFilePath, backupFileName);
                }
                File.Delete(backupFilePath);

                progressBar.Value = 70;
                lblDescription.Text = "Uploading to cloud storage...";

                // Upload to Google Drive
                string googleDriveFolderId = "1staa1CCbL4g5bR7u2zaGnBhfjSg8mRcC";
                bool uploadSuccess = await _backupController.UploadToGoogleDriveAsync(
                    filePath: zipPath,
                    folderId: googleDriveFolderId);

                progressBar.Value = 90;

                if (uploadSuccess)
                {
                    progressBar.Value = 100;
                    lblDescription.Text = "Backup completed successfully!";
                    await Task.Delay(500);

                    MessageBox.Show($"Backup saved to:\n{zipPath}\n\n" +
                                  $"And uploaded to Google Drive",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Backup saved locally but Google Drive upload failed:\n{zipPath}",
                                  "Partial Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                }

                await _auditService.Log(new AuditRecord
                {
                    UserId = CurrentUser.Current!.UserId,
                    Action = AuditActionType.CreateBackup,
                    Description = "Database backup completed successfully",
                    OldValue = "No recent backup",
                    NewValue = $"Backup created: {zipPath}",
                    EntityType = AuditEntityType.Backup,
                    EntityId = ""
                });
            }
            catch (Exception ex)
            {
                Logger.Write("Backup failed", ex.Message);
                MessageBox.Show($"Backup failed: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            finally
            {
                panel4.Visible = false;
                progressBar.Value = 0;
                lblDescription.Text = string.Empty;
            }
        }

        private void EnsureBackupFolderExists()
        {
            if (!Directory.Exists(backupFolder))
                Directory.CreateDirectory(backupFolder);
        }

        private byte[] GenerateKey(string password, out byte[] salt)
        {
            salt = new byte[16];
            RandomNumberGenerator.Fill(salt); // Generate a secure random salt

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                return deriveBytes.GetBytes(32); // Generate a 256-bit key
            }
        }

        private void EncryptFile(string inputFile, string outputFile, byte[] key, byte[] salt)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV(); // Generate a new IV for each encryption

                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                {
                    fsOutput.Write(salt, 0, salt.Length); // Store salt at the beginning
                    fsOutput.Write(aes.IV, 0, aes.IV.Length); // Store IV next

                    using (CryptoStream cryptoStream = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    {
                        fsInput.CopyTo(cryptoStream);
                    }
                }
            }
        }

        private void cboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRestoreLocal_Click(object sender, EventArgs e)
        {
            var restoreForm = new RestoreBackupForm(backupFolder);
            restoreForm.ShowDialog();
        }

        private bool IsEmailNotificationEnabled()
        {
            return cbEmailNotif.Checked;
        }

        private bool IsEncryptionEnabled()
        {
            return cbEncrypt.Checked;
        }

        private bool IsFullBackup()
        {
            return rbFullBackup.Checked;
        }

        private void cbAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoBackup.Checked)
            {
                cbAutoBackup.Text = "Auto Backup Enabled";
            }
            else
            {
                cbAutoBackup.Text = "Auto Backup Disabled";
            }
        }
    }
}
