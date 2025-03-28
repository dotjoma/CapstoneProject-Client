using client.Controllers;
using client.Forms.POS;
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
using client.Forms.Order;
using client.Models;
using System.Globalization;
using System.Xml.Linq;
using client.Forms.POS.POSUserControl;
using client.Forms.ProductManagement;
using client.Forms.POS.POSUserControl.ProductFoodCategory;
using client.Forms.DiscountManagement;
using client.Forms.InventoryManagement;
using client.Forms.AuditTrail;
using client.Forms.SalesReport;
using client.Forms.BestSelling;
using client.Forms.UserManagement;

namespace client.Forms
{
    public partial class MainMenu : Form
    {
        private readonly AuthController _authController = new AuthController();

        public MainMenu()
        {
            InitializeComponent();
            this.Shown += MainMenu_Shown;
            this.Load += MainMenu_Load;
        }

        private void MainMenu_Load(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            AddFormToPanel(new Dashboard());

            string? username = CurrentUser.Current?.Username;
            string role = (CurrentUser.Current?.Role) == "admin" ? "Administrator" : "Cashier";
            lblUser.Text = $"{char.ToUpper(username![0]) + username.Substring(1)} ({role})";
        }

        private void MainMenu_Shown(object? sender, EventArgs e)
        {
            if (CurrentUser.Current?.Role == "staff")
            {
                this.Hide();
                new OrderEntryForm().Show();
            }
        }

        private void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderEntryForm().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {

        }

        private void bgwDashboard_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = true;
        }

        private void bgwDashboard_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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

        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            if (MessageBox.Show("Are you sure you want to close application?",
                "Close Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void addEditDeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tlbDashboard_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new Dashboard());
        }

        private void tsbTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderEntryForm().Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to close application?",
                    "Close Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void discountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountHome discountHome = new DiscountHome();
            discountHome.StartPosition = FormStartPosition.Manual;
            discountHome.StartPosition = FormStartPosition.CenterParent;
            discountHome.ShowDialog(this);
        }

        private void tsbManageMenu_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new ProductHome());
        }

        private void tsbManageInventory_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new InventoryHome());
        }

        private void tsbSalesReport_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new SalesReportHome());
        }

        private void tsbBestSelling_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new BestSellingHome());
        }

        private void tsbAuditTrial_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new AuditHome());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new UserHome());
        }
    }
}
