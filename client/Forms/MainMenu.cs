using client.Controllers;
using client.Forms.Loading;
using client.Forms.POS;
using client.Forms.UserControll;
using client.Helpers;
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

namespace client.Forms
{
    public partial class MainMenu : Form
    {
        private readonly AuthController _authController;

        public MainMenu()
        {
            InitializeComponent();
            InitializeToolTip();
            _authController = new AuthController();
            this.Shown += MainMenu_Shown;
        }

        private void InitializeToolTip()
        {
            toolTip1.SetToolTip(btnMinimizeWindow, "Minimize the application");
            toolTip1.SetToolTip(btnMaximizeWindow, "Maximize the application");
            toolTip1.SetToolTip(btnCloseWindow, "Close the application");
            toolTip1.SetToolTip(btnDashboard, "Home");
            toolTip1.SetToolTip(btnPos, "POS");
            toolTip1.SetToolTip(btnNotification, "Notification");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            UC_DashBoard uc = new UC_DashBoard();
            AddUserControl(uc);
        }

        private void MainMenu_Shown(object? sender, EventArgs e)
        {
            if (!CurrentUser.IsLoggedIn)
            {
                MessageBox.Show("Please log in to continue.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _authController.RedirectToLogin();
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            bgwDashboard.RunWorkerAsync();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new POS_MainMenu().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            UC_Inventory uc = new UC_Inventory();
            AddUserControl(uc);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            UC_Reservation uc = new UC_Reservation();
            AddUserControl(uc);
        }

        private void bgwDashboard_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = true;
        }

        private void bgwDashboard_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UC_DashBoard uc = new UC_DashBoard();
            AddUserControl(uc);
        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void tsLogout_Click(object sender, EventArgs e)
        {
            _authController.Logout();
        }

        private void tsSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            AddUserControl(uc);
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            if (MessageBox.Show("Are you sure you want to close application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizeWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeWindow.Image = Properties.Resources.Full_Screen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeWindow.Image = Properties.Resources.Normal_Screen;
            }
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }
    }
}
