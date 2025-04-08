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

            foreach (var product in products)
            {
                bool isProductActive = (product.isActive > 0) ? true : false;
                if (isProductActive)
                {
                    var productCard = CreateProductCard(product);
                    flowPanel.Controls.Add(productCard);
                }
            }

            Controls.Add(flowPanel);
        }

        private Panel CreateProductCard(Product product)
        {
            var cardPanel = new Panel
            {
                Width = 160,
                Height = 180,
                BackColor = Color.FromArgb(232, 232, 232),
                Margin = new Padding(4),
                BorderStyle = BorderStyle.None
            };

            var pricePanel = new Panel
            {
                Height = 30,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(232, 232, 232)
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var picProductImage = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

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
                Logger.Write("PRODUCT DISPLAY", $"Error loading image for product {product.productId}: {ex.Message}");
                picProductImage.Image = Properties.Resources.Add_Image;
            }

            var productPanel = new Panel
            {
                Height = 30,
                BackColor = Color.FromArgb(232, 232, 232),
                Dock = DockStyle.Top
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            productPanel.Controls.Add(lblProductName);
            pricePanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(pricePanel);
            cardPanel.Controls.Add(picProductImage);
            cardPanel.Controls.Add(productPanel);

            productPanel.SendToBack();
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

                //MessageBox.Show($"Adding {product.productName} to cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            Logger.Write("BASE64 LENGTH", $"Base64 string length: {base64String.Length}");
            Logger.Write("BASE64 END", $"Base64 string end: {base64String.Substring(Math.Max(0, base64String.Length - 50))}");

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
                Logger.Write("IMAGE CONVERSION", $"Error converting base64 to image: {ex.Message}");
                return null;
            }
        }
    }
}
