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
using client.Services;
using static System.Windows.Forms.DataFormats;
using client.Services.Auth;

namespace client.Forms.POS.POSUserControl
{
    public partial class UC_Products : UserControl
    {
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        private readonly SubCategoryController _subCategoryController;
        private string _productName = string.Empty;
        private int _selectedCategory = 0;

        public UC_Products()
        {
            InitializeComponent();
            txtPrice.KeyPress += txtPrice_KeyPress;
            _productController = new ProductController();
            _categoryController = new CategoryController();
            _subCategoryController = new SubCategoryController();
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
        }

        private async void UC_Products_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AddUserControl(new UC_Beverages());
            ActiveButton(1);

            bool response = await _categoryController.Get();
            if (response)
            {
                GetCategory();
            }
        }

        public void RefreshCategories()
        {
            GetCategory();
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
            string image = Convert.ToBase64String(GetPhoto());
            string price = txtPrice.Text.Trim();
            string description = txtName.Text.Trim();

            try
            {
                if (!ValidateRequiredFields(name, price, description)) return;

                if (CurrentCategory.Current == null)
                {
                    MessageBox.Show("Select a category.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleButton(true);
                    return;
                }

                int categoryId = CurrentCategory.Current.Id; 
                if (categoryId == 0)
                {
                    MessageBox.Show("Invalid category selected.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleButton(true);
                    return;
                }

                string categoryName = CurrentCategory.Current.Name;
                if (CurrentSubCategory.Current == null)
                {
                    MessageBox.Show("Select a subcategory.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleButton(true);
                    return;
                }

                int subCategoryId = CurrentSubCategory.Current.catId;
                string? subCategoryName = CurrentSubCategory.Current.scName;

                // TODO:
                // Create a logic for create and update.

                bool response = await _productController.Create(name, image, price, description, categoryName, subCategoryName);

                if (response)
                {
                    Logger.Write("RESPONSE", $"Received response: {response}");
                    ResetForm();
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
            }
        }

        private bool ValidateRequiredFields(string name, string price, string description)
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

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }

            if (cboSubCategory.Items.Count > 0)
            {
                cboSubCategory.SelectedIndex = 0;
            }

            _selectedCategory = 0;
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

        private void UC_Products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void GetCategory()
        {
            cboCategory.Items.Clear();

            cboCategory.Items.Add("Select Category");

            var categories = CurrentCategory.AllCategories;
            if (categories != null && categories.Count > 0)
            {
                foreach (var category in categories)
                {
                    cboCategory.Items.Add(category.Name);
                }
            }

            cboCategory.Items.Add("+ Add Category");

            cboCategory.SelectedIndex = 0;
        }

        private async void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0)
            {
                CurrentCategory.SetCurrentCategory(null);
                return;
            }

            if (cboCategory.SelectedIndex == cboCategory.Items.Count - 1)
            {
                NewCategory newCategory = new NewCategory("Create Category", "Category", "Enter category name", this);
                newCategory.ShowDialog();
                cboCategory.SelectedIndex = 0;
                return;
            }

            if (cboCategory.SelectedIndex > 0 &&
                CurrentCategory.AllCategories != null &&
                (cboCategory.SelectedIndex - 1) < CurrentCategory.AllCategories.Count)
            {
                try
                {
                    var selectedCategory = CurrentCategory.AllCategories[cboCategory.SelectedIndex - 1];
                    if (selectedCategory != null && selectedCategory.Id > 0)
                    {
                        CurrentCategory.SetCurrentCategory(selectedCategory);
                        bool subCategory = await _subCategoryController.Get(selectedCategory.Id);
                        if (subCategory)
                        {
                            GetSubCategory();
                        }
                    }
                    else
                    {
                        Logger.Write("CATEGORY", "Selected category is null or has invalid ID");
                        MessageBox.Show("Invalid category selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboCategory.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting category: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboCategory.SelectedIndex = 0;
                }
            }
            else
            {
                cboCategory.SelectedIndex = 0;
            }
        }

        private void GetSubCategory()
        {
            cboSubCategory.Items.Clear();

            cboSubCategory.Items.Add("Select SubCategory");

            var subcategories = CurrentSubCategory.AllSubCategories;
            if (subcategories != null && subcategories.Count > 0)
            {
                foreach (var subcategory in subcategories)
                {
                    if (subcategory != null && !string.IsNullOrEmpty(subcategory.scName))
                    {
                        cboSubCategory.Items.Add(subcategory.scName);
                    }
                    else
                    {
                        Logger.Write("SUBCATEGORY", "Skipped adding null or empty subcategory name");
                    }
                }
            }

            cboSubCategory.Items.Add("+ Add SubCategory");

            cboSubCategory.SelectedIndex = 0;
        }

        private void cboSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubCategory.SelectedIndex == 0)
            {
                return;
            }

            if (cboSubCategory.SelectedIndex == cboSubCategory.Items.Count - 1)
            {
                if (CurrentCategory.Current?.Id == null)
                {
                    MessageBox.Show("Select category to add sub category", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NewCategory newCategory = new NewCategory("Create SubCategory", "SubCategory", "Enter subcategory name", this);
                    newCategory.ShowDialog();
                    cboSubCategory.SelectedIndex = 0;
                }
                return;
            }

            if (cboSubCategory.SelectedIndex > 0 &&
                CurrentSubCategory.AllSubCategories != null && 
                (cboSubCategory.SelectedIndex - 1) < CurrentSubCategory.AllSubCategories.Count)
            {
                try
                {
                    var selectedSubCategory = CurrentSubCategory.AllSubCategories[cboSubCategory.SelectedIndex - 1]; 
                    CurrentSubCategory.SetCurrentSubCategory(selectedSubCategory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting subcategory: " + ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboSubCategory.SelectedIndex = 0;
                }
            }
            else
            {
                cboSubCategory.SelectedIndex = 0;
            }
        }
    }
}
