using client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Models;

namespace client.Forms.POS.POSUserControl
{
    public partial class UC_Pos : UserControl
    {
        private FlowLayoutPanel cartContainerPanel;

        public UC_Pos()
        {
            InitializeComponent();
            cartContainerPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            cartPanel.Controls.Add(cartContainerPanel);
        }

        private void UC_Pos_Load(object sender, EventArgs e)
        {
            ActiveButton(1);
            timer1.Start();
        }

        public void AddCartItem(client.Models.Product product)
        {
            if (cartContainerPanel == null) return;

            var cartItem = new Panel
            {
                Width = cartContainerPanel.Width - 10,
                Height = 60,
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                AutoSize = false,
                Width = cartItem.Width - 70, 
                Height = 30,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var btnRemove = new Button
            {
                Text = "X",
                Width = 40,
                Height = 40,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(cartItem.Width - 45, 5)
            };

            btnRemove.Click += (s, e) =>
            {
                cartContainerPanel.Controls.Remove(cartItem);
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                AutoSize = false,
                Width = 60,
                Height = 30,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Right
            };

            cartItem.Controls.Add(lblProductName);
            cartItem.Controls.Add(btnRemove);
            cartItem.Controls.Add(lblPrice);

            cartContainerPanel.Controls.Add(cartItem);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            ActiveButton(1);
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            ActiveButton(2);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            ActiveButton(3);
        }

        private void ActiveButton(int btn)
        {
            var buttons = new[]
            {
                (1, btnBeverages),
                (2, btnMainCourse),
                (3, btnFastFood)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("hh:mm:ss tt").ToUpper()}";
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }
    }
}
