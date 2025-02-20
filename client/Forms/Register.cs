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
using client.Controllers;

namespace client.Forms
{
    public partial class Register : Form
    {
        private readonly AuthController _authController;

        private Point dragOffset;
        private bool isDragging = false;

        private bool isPassHidden = true;

        public Register()
        {
            InitializeComponent();
            _authController = new AuthController();
            this.KeyPreview = true;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            ToggleButton(false);
            await Task.Delay(1);

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPass = txtConfirmPass.Text.Trim();

            try
            {
                bool response = await _authController.Register(username, password, confirmPass);

                if (response)
                {
                    var loginForm = new Login();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSignUp.Enabled = tog;
            string text = (tog) ? "Sign Up" : "Registering...";
            btnSignUp.Text = text;
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

        private void btnSignUp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignUp.PerformClick();
            }
        }
    }
}
