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
    public partial class CardDisplay: UserControl
    {
        private readonly FlowLayoutPanel flowPanel;
        private readonly Guna2VScrollBar gunaScrollBar;

        public CardDisplay(List<Product> products)
        {
            InitializeComponent();

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

            //Controls.Add(gunaScrollBar);
            Controls.Add(flowPanel);
        }

        private Panel CreateProductCard(Product product)
        {
            var cardPanel = new Panel
            {
                Width = 200,
                Height = 220,
                BackColor = Color.White,
                Margin = new Padding(3),
                BorderStyle = BorderStyle.None
            };

            var picProductImage = new PictureBox
            {
                Width = 140,
                Height = 115,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            picProductImage.Location = new Point(
                (cardPanel.ClientSize.Width - picProductImage.Width) / 2,
                (cardPanel.ClientSize.Height - picProductImage.Height) / 2 - 20 
            );

            try
            {
                if (!string.IsNullOrEmpty(product.productImage))
                {
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

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(73, 54, 40),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleRight
            };

            lblPrice.Location = new Point(
                cardPanel.ClientSize.Width - lblPrice.PreferredWidth - 15,
                10
            );

            var bottomPanel = new Panel
            {
                Height = 40,
                BackColor = Color.FromArgb(214, 192, 179),
                Dock = DockStyle.Bottom
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(73, 54, 40),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            bottomPanel.Controls.Add(lblProductName);
            cardPanel.Controls.Add(picProductImage);
            cardPanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(bottomPanel);

            bottomPanel.SendToBack();
            picProductImage.BringToFront();
            lblPrice.BringToFront();
            lblProductName.BringToFront();

            ApplyHover(cardPanel);
            ApplyHover(picProductImage);
            ApplyHover(lblProductName);
            ApplyHover(lblPrice);

            cardPanel.Tag = product;
            picProductImage.Tag = product;
            lblProductName.Tag = product;
            lblPrice.Tag = product;

            AttachClickEvent(cardPanel);
            AttachClickEvent(picProductImage);
            AttachClickEvent(lblProductName);
            AttachClickEvent(lblPrice);

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
            if (OrderEntryForm.Instance != null)
            {
                if (!string.IsNullOrEmpty(product.productImage))
                {
                    product.ProductImageObject = ConvertBase64ToImage(product.productImage);
                }

                OrderEntryForm.Instance.AddCartItem(product);
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
