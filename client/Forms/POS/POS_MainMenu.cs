using client.Forms.POS.POSUserControl;
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
using client.Services.Auth;
using client.Models;
using client.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using client.Forms.Order;

namespace client.Forms.POS
{
    public partial class POS_MainMenu : Form
    {
        private Point dragOffset;
        private bool isDragging = false;

        public POS_MainMenu()
        {
            InitializeComponent();
        }

        private void POS_MainMenu_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;

            AddUserControl(new UC_Pos());
            ActiveButton(1);

            if (!CurrentUser.IsLoggedIn)
            {
                Application.Exit();
            }

            if (!CurrentUser.IsAdmin)
            {
                btnProducts.Visible = false;
            }
            else
            {
                btnProducts.Visible = true;
            }

        }

        public void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(form);
            form.Show();
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ActiveButton(int btn)
        {
            var buttons = new[]
            {
                (1, btnPos),
                (2, btnOrders),
                (3, btnProducts)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new OrderEntryForm());
            ActiveButton(1);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_Orders());
            ActiveButton(2);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_Products());
            ActiveButton(3);
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newLocation.X - dragOffset.X, newLocation.Y - dragOffset.Y);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
