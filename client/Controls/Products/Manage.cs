using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace client.Controls.Manage
{
    public class Manage : UserControl
    {
        private readonly FlowLayoutPanel flowPanel;
        private readonly Guna2VScrollBar gunaScrollBar;

        public Manage(List<Product> products)
        {
            flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10),
                Margin = new Padding(0)
            };

            gunaScrollBar = new Guna2VScrollBar
            {
                Dock = DockStyle.Right,
                FillColor = Color.LightGray,
                ThumbColor = Color.DarkGray,
                BorderRadius = 5,
                Width = 2
            };

            gunaScrollBar.BindingContainer = flowPanel;

            // Add product cards to the FlowLayoutPanel
            foreach (var product in products)
            {
                var productCard = CreateProductCard(product);
                flowPanel.Controls.Add(productCard);
            }

            Controls.Add(gunaScrollBar);
            Controls.Add(flowPanel);
        }

        private Panel CreateProductCard(Product product)
        {
            // Card config
            var cardPanel = new Panel
            {
                Width = 220,
                Height = 270,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            // PictureBox for product image
            var picProductImage = new PictureBox
            {
                Image = string.IsNullOrEmpty(product.productImage)
                    ? Properties.Resources.Add_Image
                    : Image.FromStream(new MemoryStream(Convert.FromBase64String(product.productImage))),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 140,
                Height = 90,
                Location = new Point(40, 15)
            };

            // Label for product name
            var lblProductName = new Label
            {
                Text = product.productName,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 150,
                Top = 120,
                Left = 5
            };

            // Label for product price
            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(73, 54, 40),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 150,
                Top = 190,
                Left = 5
            };

            // Button for "Add to Cart"
            var btnAddToCart = new Guna2Button
            {
                Text = "Add to Cart",
                Dock = DockStyle.Bottom,
                FillColor = Color.FromArgb(214, 192, 179),
                Image = Properties.Resources.ShoppingBagBR,
                Tag = product
            };
            btnAddToCart.HoverState.FillColor = Color.FromArgb(73, 54, 40);
            btnAddToCart.Click += (sender, e) =>
            {
                if (sender is Guna2Button clickedButton &&
                    clickedButton.Tag is Product selectedProduct)
                {
                    HandleAddToCart(selectedProduct);
                }
            };

            var pnlBackground = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.FromArgb(214, 192, 179)
            };

            // Add controls to the card panel
            cardPanel.Controls.Add(picProductImage);
            cardPanel.Controls.Add(lblProductName);
            cardPanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(btnAddToCart);
            cardPanel.Controls.Add(pnlBackground);

            return cardPanel;
        }

        private void HandleAddToCart(Product product)
        {
            MessageBox.Show($"Added Id:{product.productId} Name:{product.productName} Price:{product.productPrice} to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
