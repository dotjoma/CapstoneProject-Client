using client.Controllers;
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
    public partial class AuthForm : Form
    {
        AuthController _authController = new AuthController();
        private BackupPanel _backupPanel;
        private RestoreBackupForm _restoreForm;
        public AuthForm(BackupPanel backupPanel, RestoreBackupForm restore)
        {
            InitializeComponent();
            _backupPanel = backupPanel;
            _restoreForm = restore;
        }

        private async void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input password", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            bool loggedIn = await _authController.EncryptDecryptAuth(password);

            if (!loggedIn)
            {
                return;
            }

            if (_backupPanel != null)
            {
                _backupPanel.AuthPassword = password;
                _backupPanel.AuthStatus = "authenticated";
            }
            if (_restoreForm != null)
            {
                _restoreForm.AuthPassword = password;
                _restoreForm.AuthStatus = "authenticated";
            }

            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}
