using client.Forms.Loading;
using client.Forms.POS;
using client.Forms.UserControll;
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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            UC_DashBoard uc = new UC_DashBoard();
            AddUserControl(uc);
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
            ActiveButton(1);
            bgwDashboard.RunWorkerAsync();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            ActiveButton(2);
            this.Hide();
            new POS_MainMenu().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ActiveButton(3);
            UC_Inventory uc = new UC_Inventory();
            AddUserControl(uc);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ActiveButton(4);
            UC_Reservation uc = new UC_Reservation();
            AddUserControl(uc);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(5);
            UC_Settings uc = new UC_Settings();
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

        private void ActiveButton(int btn)
        {
            var buttons = new[]
            {
                (1, btnDashboard),
                (2, btnPos),
                (3, btnInventory),
                (4, btnReservation),
                (5, btnSettings)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }
    }
}
