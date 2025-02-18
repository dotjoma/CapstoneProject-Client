using client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Controls.Manage;
using client.Forms.POS.POSUserControl.ProductFoodCategory;
using client.Controllers;
using System.Drawing.Imaging;
using client.Helpers;
using Microsoft.VisualBasic;
using System.Globalization;

namespace client.Forms.POS.POSUserControl
{
    public partial class UC_Products : UserControl
    {
        private readonly ProductController _productController;
        private string _productName = string.Empty;
        private int _selectedCategory = 0;

        public UC_Products()
        {
            InitializeComponent();
            txtPrice.KeyPress += txtPrice_KeyPress;
            _productController = new ProductController();
        }

        private void UC_Products_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AddUserControl(new UC_Beverages());
            ActiveButton(1);
        }

        private void AddUserControl(UserControl userControl)
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
                (1, btnBeverages),
                (2, btnMainCourse),
                (3, btnFastFood)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == btn);
        }

        private void CategorySelected(int categoryId)
        {
            _selectedCategory = categoryId;

            switch (_selectedCategory)
            {
                case 1:
                    _productName = "Beverages";
                    break;
                case 2:
                    _productName = "MainCourse";
                    break;
                case 3:
                    _productName = "FastFood";
                    break;
                default:
                    _productName = string.Empty;
                    break;
            }

            var buttons = new[]
            {
                (1, btnBeveragesCateg),
                (2, btnMainCourseCateg),
                (3, btnFastFoodCateg)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = b.Item1 == categoryId);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("hh:mm:ss tt").ToUpper()}";
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_Beverages());
            ActiveButton(1);
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_MainCourse());
            ActiveButton(2);
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_FastFood());
            ActiveButton(3);
        }

        private ImageCodecInfo? GetEncoder(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }

        private byte[] GetPhoto()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Image resizedImage = ResizeImage(pbImage.Image, 1024, 1024);

                ImageCodecInfo? jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                EncoderParameters encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 75L);

                if (jpgEncoder != null)
                {
                    resizedImage.Save(stream, jpgEncoder, encoderParameters);
                }
                else
                {
                    resizedImage.Save(stream, ImageFormat.Jpeg);
                }

                return stream.ToArray();
            }
        }

        private Image ResizeImage(Image img, int maxWidth, int maxHeight)
        {
            if (img.Width <= maxWidth && img.Height <= maxHeight)
                return img;

            int newWidth = maxWidth;
            int newHeight = maxHeight;
            if (newHeight > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)((double)img.Width / img.Height * maxHeight);
            }

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            await Task.Delay(1);

            string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.Trim().ToLower());
            //string image = SaveImageAndGetPath(pbImage.Image); v.1
            string image = Convert.ToBase64String(GetPhoto());
            string price = txtPrice.Text.Trim();
            string description = txtName.Text.Trim();
            string category = _productName;

            try
            {
                if (!ValidateRequiredFields(name, price, description, category)) return;

                // TODO:
                // Create a logic for create and update.

                bool response = await _productController.Create(name, image, price, description, category);

                if (response)
                {
                    Logger.Write("RESPONSE", $"Received response: {response}");
                }
                else
                {
                    Logger.Write("RESPONSE", $"No any response from the server.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleButton(true);
                ResetForm();
            }
        }

        private bool ValidateRequiredFields(string name, string price, string description, string category)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Product name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Price is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(price, out decimal priceValue) || priceValue <= 0)
            {
                MessageBox.Show("Price must be a valid positive number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(category)) 
            {
                MessageBox.Show("Please select a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (IsDefaultImage(pbImage.Image))
            {
                MessageBox.Show("Please select an image.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            string text = (tog) ? "Save" : "Loading...";
            btnSave.Text = text;
        }

        private void btnBeveragesCateg_Click(object sender, EventArgs e)
        {
            CategorySelected(1);
        }

        private void btnMainCourseCateg_Click(object sender, EventArgs e)
        {
            CategorySelected(2);
        }

        private void btnFastFoodCateg_Click(object sender, EventArgs e)
        {
            CategorySelected(3);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                if (MessageBox.Show(
                    "You have unsaved changes. Do you want to continue?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetForm();
                }
            }
        }

        private bool IsDefaultImage(Image currentImage)
        {
            return AreImagesEqual(currentImage, Properties.Resources.Add_Image);
        }

        private bool AreImagesEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
                return false;

            using (MemoryStream ms1 = new MemoryStream(), ms2 = new MemoryStream())
            {
                img1.Save(ms1, img1.RawFormat);
                img2.Save(ms2, img2.RawFormat);
                return ms1.ToArray().SequenceEqual(ms2.ToArray());
            }
        }

        private bool ValidateForm()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) ||
                !string.IsNullOrWhiteSpace(txtPrice.Text) ||
                !string.IsNullOrWhiteSpace(rtbDescription.Text) ||
                !IsDefaultImage(pbImage.Image) ||
                !string.IsNullOrEmpty(_productName) ||
                _selectedCategory != 0)
            {
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtName.Text = string.Empty;
            pbImage.Image = Properties.Resources.Add_Image;
            txtPrice.Text = string.Empty;
            rtbDescription.Clear();
            _productName = string.Empty;
            _selectedCategory = 0;

            var buttons = new[]
            {
                (1, btnBeveragesCateg),
                (2, btnMainCourseCateg),
                (3, btnFastFoodCateg)
            };

            buttons.ToList().ForEach(b => b.Item2.Checked = false);
        }

        private void txtPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txtPrice.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnPickImage_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void PickImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
