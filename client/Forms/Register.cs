using client.Network;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System;
using System.Windows.Forms;

namespace client.Forms
{
    public partial class Register : Form
    {
        private Point dragOffset;
        private bool isDragging = false;

        private bool isPassHidden = true;

        public Register()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DisconnectClient();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            DisconnectClient();
            Application.Exit();
        }

        private void DisconnectClient()
        {
            try
            {
                // Send logout packet before disconnecting
                if (Client.Instance.IsConnected)
                {
                    var packet = new Packet
                    {
                        Type = PacketType.Logout,
                        Data = new Dictionary<string, string>()
                    };
                    Client.Instance.SendToServer(packet);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error during disconnect: {ex.Message}");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            timer1.Start();

            isPassHidden = true;
            txtPassword.PasswordChar = '●';
            txtPassword.UseSystemPasswordChar = false;

            txtConfirmPass.PasswordChar = '●';
            txtConfirmPass.UseSystemPasswordChar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .4;
        }

        private void txtConfirmPass_IconRightClick(object sender, EventArgs e)
        {
            isPassHidden = !isPassHidden;
            if (isPassHidden)
            {
                txtPassword.PasswordChar = '●';
                txtConfirmPass.PasswordChar = '●';
                txtConfirmPass.IconRight = Properties.Resources.Eye;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
                txtConfirmPass.IconRight = Properties.Resources.Hide;
            }
        }

        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logfrm = new Login();
            logfrm.Show();
        }

        private void btnLoginHere_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnLoginHere_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
            btnSignUp.Text = "Registering...";
            await Task.Delay(1);

            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPass = txtConfirmPass.Text;

                if (!ValidateFields(username, password, confirmPass))
                {
                    return;
                }

                var registerPacket = new Packet
                {
                    Type = PacketType.Register,
                    Data = new Dictionary<string, string>
                    {
                        { "username", username },
                        { "password", password }
                    }
                };

                var response = await Task.Run(() => Client.Instance.SendToServerAndWaitResponse(registerPacket));

                if (response == null)
                {
                    MessageBox.Show("No response received from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if response.Data contains "success" key and its value
                if (response.Data != null && response.Data.ContainsKey("success"))
                {
                    if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Registration successful! Please login.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var loginForm = new Login();
                        loginForm.Show();
                        this.Close();
                    }
                    else
                    {
                        string errorMessage = "Registration failed: ";

                        // Get error message from response
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
                    }
                }
                else
                {
                    MessageBox.Show("Invalid response format from server", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSignUp.Enabled = true;
                btnSignUp.Text = "Sign Up";
            }
        }

        private bool ValidateFields(string username, string password, string confirmpass)
        {
            // Username validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Password must contain at least:\n" +
                              "- One uppercase letter\n" +
                              "- One lowercase letter\n" +
                              "- One number\n" +
                              "- One special character",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Confirm password validation
            if (string.IsNullOrWhiteSpace(confirmpass))
            {
                MessageBox.Show("Please confirm your password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newLocation.X - dragOffset.X, newLocation.Y - dragOffset.Y);
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
