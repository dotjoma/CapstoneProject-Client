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
        private readonly UnitController _unitController;
        private readonly CategoryController _categoryController;
        private readonly SubCategoryController _subCategoryController;

        private string _productName = string.Empty;
        private int _selectedCategory = 0;

        public UC_Products()
        {
            InitializeComponent();
            txtPrice.KeyPress += txtPrice_KeyPress;
            _productController = new ProductController();
            _unitController = new UnitController();
            _categoryController = new CategoryController();
            _subCategoryController = new SubCategoryController();
        }

        private async void UC_Products_Load(object sender, EventArgs e)
        {
            timer1.Start();

            bool isInitialized = await InitializeComboboxes();
            if (!isInitialized)
            {
                Logger.Write("INIT COMBOBOXES DATA", "Failed to initialize comboboxes.");
            }
            Logger.Write("INIT COMBOBOXES DATA", "Comboboxes initialized successfully.");
        }

        private async Task<bool> InitializeComboboxes()
        {
            bool unitInitialized = await _unitController.Get();
            if (unitInitialized) GetUnit();

            bool categoryInitialized = await _categoryController.Get();
            if (categoryInitialized) GetCategory();

            bool subCategoryInitialized = await _subCategoryController.Get(CurrentCategory.Current?.Id ?? 0);
            if (subCategoryInitialized) GetCategory();

            return categoryInitialized && unitInitialized && subCategoryInitialized;
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

        private string ConvertImageToBase64(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert Image to byte[]
                    image.Save(ms, ImageFormat.Jpeg); // or use other format like PNG
                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to base64 string
                    return Convert.ToBase64String(imageBytes);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("IMAGE CONVERSION", $"Error converting image to base64: {ex.Message}");
                return string.Empty;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            await Task.Delay(1);

            string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.Trim().ToLower());
            string image = ConvertImageToBase64(pbImage.Image);
            string price = txtPrice.Text.Trim();
            string description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rtbDescription.Text.Trim()); 

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

                if (CurrentSubCategory.Current == null)
                {
                    MessageBox.Show("Select a subcategory.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleButton(true);
                    return;
                }
                int subCategoryId = CurrentSubCategory.Current.catId;

                if (CurrentUnit.Current == null)
                {
                    MessageBox.Show("Select a unit.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleButton(true);
                    return;
                }
                int unitId = CurrentUnit.Current.unitId;

                // TODO:
                // Create a logic for create and update.

                bool response = await _productController.Create(name, image, price, categoryId, subCategoryId, unitId, 1);

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

            if (cboUnit.Items.Count > 0)
            {
                cboUnit.SelectedIndex = 0;
            }

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

        public void GetCategory()
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
                CurrentSubCategory.SetCurrentSubCategory(null);
                return;
            }

            if (cboCategory.SelectedIndex == cboCategory.Items.Count - 1)
            {
                //CurrentCategory.Clear();
                //NewCategory newCategory = new NewCategory("Create Category", "Category", "Enter category name", this);
                //newCategory.ShowDialog();
                //cboCategory.SelectedIndex = 0;
                //return;
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

        public void GetSubCategory()
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
                    //NewCategory newCategory = new NewCategory("Create SubCategory", "SubCategory", "Enter subcategory name", this);
                    //newCategory.ShowDialog();
                    //cboSubCategory.SelectedIndex = 0;
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

        public void GetUnit()
        {
            cboUnit.Items.Clear();

            cboUnit.Items.Add("Select Unit");

            var units = CurrentUnit.AllUnit;
            if (units != null && units.Count > 0)
            {
                foreach (var unit in units)
                {
                    if (unit != null && unit.unitName != null)
                    {
                        cboUnit.Items.Add(unit.unitName);
                    }
                    else
                    {
                        Logger.Write("UNIT", "Skipped adding null or empty unit name");
                    }
                }
            }

            cboUnit.Items.Add("+ Add Unit");

            cboUnit.SelectedIndex = 0;
        }


        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnit.SelectedIndex == 0)
            {
                CurrentUnit.SetCurrentUnit(null);
                return;
            }

            if (cboUnit.SelectedIndex == cboUnit.Items.Count - 1)
            {
                //NewCategory newUnit = new NewCategory("Create Unit", "Unit", "Enter unit name", this);
                //newUnit.ShowDialog();
                //cboUnit.SelectedIndex = 0;
                //return;
            }

            if (cboUnit.SelectedIndex > 0 &&
                CurrentUnit.AllUnit != null &&
                (cboUnit.SelectedIndex - 1) < CurrentUnit.AllUnit.Count)
            {
                try
                {
                    var selectedUnit = CurrentUnit.AllUnit[cboUnit.SelectedIndex - 1];
                    if (selectedUnit != null && selectedUnit.unitId > 0) 
                    {
                        CurrentUnit.SetCurrentUnit(selectedUnit);
                    }
                    else
                    {
                        Logger.Write("UNIT", "Selected unit is null or has invalid ID");
                        MessageBox.Show("Invalid unit selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboUnit.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting unit: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboUnit.SelectedIndex = 0; 
                }
            }
            else
            {
                cboUnit.SelectedIndex = 0; 
            }
        }
    }
}
