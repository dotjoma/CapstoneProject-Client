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
using client.Controls.Products;
using client.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using client.Forms.POS.POSUserControl;
using client.Forms.Order;
using System.Reflection;

namespace client.Controls.Products
{
    public class Display : UserControl
    {
        private readonly FlowLayoutPanel flowPanel;
        private readonly Guna2VScrollBar gunaScrollBar;

        public Display(List<Product> products)
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
            var cardPanel = new Panel
            {
                Width = 220,
                Height = 240,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(10),
            };

            var picProductImage = new PictureBox
            {
                Width = 140,
                Height = 90,
                Location = new Point(40, 15),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                if (!string.IsNullOrEmpty(product.productImage))
                {
                    LoggerHelper.Write("IMAGE CONVERSION", $"Original string start: {product.productImage.Substring(0, Math.Min(100, product.productImage.Length))}");

                    Image? convertedImage = ConvertBase64ToImage(product.productImage);
                    product.ProductImageObject = convertedImage;
                    picProductImage.Image = convertedImage ?? Properties.Resources.Add_Image;
                }
                else
                {
                    picProductImage.Image = Properties.Resources.Add_Image;
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("PRODUCT DISPLAY", $"Error loading image for product {product.productId}: {ex.Message}");
                picProductImage.Image = Properties.Resources.Add_Image;
            }

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

            var lblDescription = new Label
            {
                Text = product.productDesc,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                AutoSize = false,
                Height = 40,
                Width = 150,
                TextAlign = ContentAlignment.MiddleLeft,
                Top = 150,
                Left = 6
            };

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

            var pnlBackground = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = Color.FromArgb(214, 192, 179)
            };

            cardPanel.Controls.Add(picProductImage);
            cardPanel.Controls.Add(lblProductName);
            cardPanel.Controls.Add(lblDescription);
            cardPanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(pnlBackground);

            ApplyHover(cardPanel);
            ApplyHover(picProductImage);
            ApplyHover(lblProductName);
            ApplyHover(lblDescription);
            ApplyHover(lblPrice);
            ApplyHover(pnlBackground);

            cardPanel.Tag = product;
            picProductImage.Tag = product;
            lblProductName.Tag = product;
            lblDescription.Tag = product;
            lblPrice.Tag = product;
            pnlBackground.Tag = product;

            AttachClickEvent(cardPanel);
            AttachClickEvent(picProductImage);
            AttachClickEvent(lblProductName);
            AttachClickEvent(lblDescription);
            AttachClickEvent(lblPrice);
            AttachClickEvent(pnlBackground);

            pnlBackground.SendToBack();

            return cardPanel;
        }

        void ApplyHover(Control control)
        {
            control.MouseEnter += (o, e) => Cursor = Cursors.Hand;
            control.MouseLeave += (o, e) => Cursor = Cursors.Default;
        }

        void AttachClickEvent(Control control)
        {
            control.Click += (sender, e) =>
            {
                if (sender is Control clickedControl && clickedControl.Tag is Product selectedProduct)
                {
                    HandleAddToCart(selectedProduct);
                }
            };
        }

        private void HandleAddToCart(Product product)
        {
            var orderEntryForm = Application.OpenForms["OrderEntryForm"] as OrderEntryForm;

            if (orderEntryForm != null)
            {
                if (!string.IsNullOrEmpty(product.productImage))
                {
                    product.ProductImageObject = ConvertBase64ToImage(product.productImage);
                }

                orderEntryForm.AddCartItem(product);
            }
            else
            {
                MessageBox.Show("Order Entry Form is not open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private Image? ConvertBase64ToImage(string? base64String)
        {
            if (string.IsNullOrEmpty(base64String))
                return null;

            LoggerHelper.Write("BASE64 LENGTH", $"Base64 string length: {base64String.Length}");
            LoggerHelper.Write("BASE64 END", $"Base64 string end: {base64String.Substring(Math.Max(0, base64String.Length - 50))}");

            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (var ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("IMAGE CONVERSION", $"Error converting base64 to image: {ex.Message}");
                return null;
            }
        }
    }
}
