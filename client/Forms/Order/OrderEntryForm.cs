using client.Controllers;
using client.Controls.Products;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.Order
{
    public partial class OrderEntryForm : Form
    {
        private FlowLayoutPanel cartContainerPanel;

        public OrderEntryForm()
        {
            InitializeComponent();
            LoadProducts();
            this.Name = "OrderEntryForm";

            cartContainerPanel = cartPanel as FlowLayoutPanel;

            if (cartContainerPanel == null)
            {
                cartContainerPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                cartPanel.Controls.Add(cartContainerPanel);
            }
        }

        private void OrderEntryForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private async void LoadProducts()
        {
            var productController = new ProductController();
            if (await productController.Get())
            {
                pnlContainer.Controls.Clear();

                var productDisplay = new Display(CurrentProduct.AllProduct)
                {
                    Dock = DockStyle.Fill
                };
                pnlContainer.Controls.Add(productDisplay);
            }
        }

        public void AddCartItem(Product product)
        {
            if (cartContainerPanel == null)
            {
                MessageBox.Show("Cart panel is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cartItem = new Panel
            {
                Width = cartContainerPanel.Width - 30,
                Height = 80,
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };

            var picProductImage = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 60,
                Height = 60,
                Dock = DockStyle.Left,
                Margin = new Padding(5),
                Image = product.ProductImageObject ?? Properties.Resources.Add_Image
            };

            var detailsPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                AutoSize = false,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                AutoSize = false,
                Dock = DockStyle.Bottom,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Green,
                TextAlign = ContentAlignment.MiddleLeft
            };

            detailsPanel.Controls.Add(lblProductName, 0, 0);
            detailsPanel.Controls.Add(lblPrice, 0, 1);

            var btnRemove = new Button
            {
                Text = "X",
                Width = 30,
                Height = 30,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Right,
                Margin = new Padding(5)
            };

            btnRemove.Click += (s, e) =>
            {
                cartContainerPanel.Controls.Remove(cartItem);
                MessageBox.Show($"Removed Tag: {product.productId}");
            };

            cartItem.Controls.Add(lblProductName);
            cartItem.Controls.Add(btnRemove);
            cartItem.Controls.Add(lblPrice);
            cartItem.Controls.Add(picProductImage);

            cartContainerPanel.Controls.Add(cartItem);
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {

        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("hh:mm:ss tt").ToUpper()}";
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }
    }
}
