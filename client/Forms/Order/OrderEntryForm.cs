﻿using client.Controllers;
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

        public static OrderEntryForm? Instance { get; private set; }

        public OrderEntryForm()
        {
            InitializeComponent();
            Instance = this;
            this.FormClosed += OrderEntryForm_FormClosed;
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

            foreach (Control control in cartContainerPanel.Controls)
            {
                if (control is Panel existingCartItem && existingCartItem.Tag is Product existingProduct)
                {
                    if (existingProduct.productId == product.productId)
                    {
                        Label? quantityLabel = existingCartItem.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblQuantity");

                        if (quantityLabel != null)
                        {
                            int currentQuantity = int.Parse(quantityLabel.Text.Replace("Qty: ", ""));
                            quantityLabel.Text = $"Qty: {(currentQuantity + 1)}";
                        }
                        return;
                    }
                }
            }

            var cartItem = new Panel
            {
                Width = cartContainerPanel.Width - 30,
                Height = 80,
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.None,
                Tag = product
            };

            var picProductImage = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 60,
                Height = 60,
                Location = new Point(5, 5),
                Image = product.ProductImageObject ?? Properties.Resources.Add_Image
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                AutoSize = true,
                Location = new Point(75, 5),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                AutoSize = true,
                Location = new Point(75, 25),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Green,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblQuantity = new Label
            {
                Name = "lblQuantity",
                Text = "Qty: 1",
                AutoSize = true,
                Location = new Point(95, 45),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var btnMinus = new Button
            {
                Name = "btnMinus",
                Text = "−", // Unicode minus sign for better alignment
                Width = 24,
                Height = 24,
                Location = new Point(70, 42),
                Font = new Font("Segoe UI", 10, FontStyle.Bold), // Slightly bigger font for clarity
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(214, 192, 179),
                Cursor = Cursors.Hand // Changes cursor to hand when hovered
            };

            // Prevents resizing on click
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 170, 160); // Slightly darker when clicked
            btnMinus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 204, 192); // Lighter on hover

            var btnPlus = new Button
            {
                Name = "btnPlus",
                Text = "+",
                Width = 24,
                Height = 24,
                Location = new Point(150, 42),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(214, 192, 179),
                Cursor = Cursors.Hand
            };

            // Prevents resizing on click
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 170, 160);
            btnPlus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 204, 192);

            btnPlus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                lblQuantity.Text = $"Qty: {currentQuantity + 1}";
            };

            btnMinus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                if (currentQuantity > 1)
                {
                    lblQuantity.Text = $"Qty: {currentQuantity - 1}";
                }
            };

            var btnRemove = new Button
            {
                Name = "btnRemove",
                Text = "X",
                Width = 25,
                Height = 25,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0 }
            };

            btnRemove.Location = new Point(cartItem.Width - btnRemove.Width - 5, 5);
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnRemove.Click += (s, e) => cartContainerPanel.Controls.Remove(cartItem);

            cartItem.Controls.Add(picProductImage);
            cartItem.Controls.Add(lblProductName);
            cartItem.Controls.Add(lblPrice);
            cartItem.Controls.Add(lblQuantity);
            cartItem.Controls.Add(btnMinus);
            cartItem.Controls.Add(btnPlus);
            cartItem.Controls.Add(btnRemove);

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

        private void OrderEntryForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Instance = null;
        }
    }
}
