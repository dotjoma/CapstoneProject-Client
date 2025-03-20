using client.Controllers;
using client.Forms.POS.POSUserControl.ProductFoodCategory;
using client.Helpers;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.ProductManagement
{
    public partial class AddProduct : Form
    {
        private readonly ProductController _productController = new ProductController();
        private readonly UnitController _unitController = new UnitController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();

        private int _selectedId = 0;

        public AddProduct(int selectedId)
        {
            InitializeComponent();
            _selectedId = selectedId;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentProduct.SetCurrentProduct(null);
            this.Dispose();
            new ProductHome().ShowDialog();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            //this.ShowInTaskbar = false;
            try
            {
                InitializeComboboxes();
                LoggerHelper.Write("INIT COMBOBOXES DATA", "Comboboxes initialized successfully.");

                if (_selectedId > 0)
                {
                    var selectedProduct = CurrentProduct.GetProductById(_selectedId);
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("Product not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    CurrentProduct.SetCurrentProduct(selectedProduct);
                    LoadProductDetails(selectedProduct);
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("EDIT PRODUCT", $"Error loading product: {ex.Message}");
                MessageBox.Show("Failed to load product details.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadProductDetails(Product product)
        {
            txtName.Text = product.productName;
            txtPrice.Text = product.productPrice.ToString("F");

            if (cboCategory.Items.Count > 0)
            {
                int categoryIndex = cboCategory.Items.Cast<string>()
                    .ToList()
                    .FindIndex(item => item == CurrentCategory.GetCategoryById(product.categoryId)?.Name);
                if (categoryIndex >= 0)
                {
                    cboCategory.SelectedIndex = categoryIndex;
                }
            }

            //GetSubCategory();
            if (cboSubCategory.Items.Count > 0)
            {
                var subCategoryName = CurrentSubCategory.GetSubategoryById(product.subcategoryId)?.scName;

                var subCategory = CurrentSubCategory.GetSubategoryById(product.subcategoryId);
                if (subCategory == null)
                {
                    LoggerHelper.Write("SUBCATEGORY", $"No subcategory found for ID: {product.subcategoryId}");
                }
                else
                {
                    subCategoryName = subCategory.scName;
                }

                if (!string.IsNullOrEmpty(subCategoryName))
                {
                    int subCategoryIndex = cboSubCategory.Items.Cast<string>()
                    .ToList()
                    .FindIndex(item => string.Equals(item.Trim(),
                        subCategoryName?.Trim(),
                        StringComparison.OrdinalIgnoreCase));

                    if (subCategoryIndex >= 0)
                    {
                        cboSubCategory.SelectedIndex = subCategoryIndex;
                    }
                    else
                    {
                        LoggerHelper.Write("SUBCATEGORY", $"Subcategory '{subCategoryName}' not found in ComboBox items.");
                    }
                }
                else
                {
                    LoggerHelper.Write("SUBCATEGORY", "Subcategory name is null or empty.");
                }
            }

            if (cboUnit.Items.Count > 0)
            {
                int unitIndex = cboUnit.Items.Cast<string>()
                    .ToList()
                    .FindIndex(item => item == CurrentUnit.GetUnitById(product.unitId)?.unitName);

                if (unitIndex >= 0)
                {
                    cboUnit.SelectedIndex = unitIndex;
                }
            }

            Image? convertedImage = ConvertBase64ToImage(product.productImage);
            product.ProductImageObject = convertedImage;
            pbImage.Image = convertedImage ?? Properties.Resources.Add_Image;

            cbIsActive.Checked = product.isActive > 0;
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

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void InitializeComboboxes()
        {
            try
            {
                GetUnit();
                GetCategory();
                GetSubCategory();
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("INIT ERROR", $"Failed to initialize comboboxes: {ex.Message}");
                return;
            }
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

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            string text = (tog) ? "Save" : "Loading...";
            btnSave.Text = text;
        }

        private bool ValidateRequiredFields(string name, string price)
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

        private bool IsDefaultImage(Image currentImage)
        {
            return AreImagesEqual(currentImage, Properties.Resources.ImageFileAdd);
        }

        private bool AreImagesEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
                return false;

            try
            {
                using (Bitmap bmp1 = new Bitmap(img1))
                using (Bitmap bmp2 = new Bitmap(img2))
                using (MemoryStream ms1 = new MemoryStream())
                using (MemoryStream ms2 = new MemoryStream())
                {
                    bmp1.Save(ms1, ImageFormat.Png);
                    bmp2.Save(ms2, ImageFormat.Png);

                    if (ms1.Length != ms2.Length)
                        return false;

                    ms1.Position = 0;
                    ms2.Position = 0;

                    return ms1.ToArray().SequenceEqual(ms2.ToArray());
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("IMAGE EQUAL", $"Error comparing images: {ex.Message}");
                return false;
            }
        }

        private string ConvertImageToBase64(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Clone the image to avoid GDI+ lock issues
                    using (Bitmap clone = new Bitmap(image))
                    {
                        clone.Save(ms, ImageFormat.Png); // PNG format is more stable
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("IMAGE CONVERSION", $"Error converting image to base64: {ex.Message}");
                return string.Empty;
            }
        }


        private void pbImage_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            PickImage();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            ShowLoading("Saving product...");

            string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtName.Text.Trim().ToLower());
            //string image = pbImage.Image != null ? ConvertImageToBase64(pbImage.Image) : "";

            string image = (pbImage.Image != null) ? ConvertImageToBase64(new Bitmap(pbImage.Image)) : string.Empty;

            string price = txtPrice.Text.Trim();
            int isActive = (cbIsActive.CheckState == CheckState.Checked) ? 1 : 0;

            if (!ValidateFormInputs(out int categoryId, out int subCategoryId, out int unitId))
            {
                ToggleButton(true);
                HideLoading();
                return;
            }

            try
            {
                if (_selectedId > 0)
                {
                    bool response = await _productController.Update(_selectedId, name, image, price, categoryId, subCategoryId, unitId, isActive);
                    HandleResponse(response);
                }
                else
                {
                    bool response = await _productController.Create(name, image, price, categoryId, subCategoryId, unitId, isActive);
                    HandleResponse(response);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
            finally
            {
                ToggleButton(true);
                HideLoading();
            }
        }

        private bool ValidateFormInputs(out int categoryId, out int subCategoryId, out int unitId)
        {
            categoryId = subCategoryId = unitId = 0;

            if (!ValidateRequiredFields(txtName.Text, txtPrice.Text))
            {
                return false;
            }

            if (CurrentCategory.Current == null)
            {
                ShowValidationMessage("Select a category.");
                return false;
            }
            categoryId = CurrentCategory.Current.Id;
            if (categoryId == 0)
            {
                ShowValidationMessage("Invalid category selected.");
                return false;
            }

            if (cboSubCategory.SelectedIndex > 0)
            {
                string? selectedSubCategory = cboSubCategory.SelectedItem as string;

                if (!string.IsNullOrEmpty(selectedSubCategory))
                {
                    var subCategory = CurrentSubCategory.AllSubCategories
                        .FirstOrDefault(sc => sc.scName == selectedSubCategory);

                    if (subCategory != null)
                    {
                        subCategoryId = subCategory.scId;
                    }
                    else
                    {
                        ShowValidationMessage($"Invalid subcategory selected: {selectedSubCategory}");
                        return false;
                    }
                }
                else
                {
                    ShowValidationMessage("Select a subcategory.");
                    return false;
                }
            }

            if (CurrentUnit.Current == null)
            {
                ShowValidationMessage("Select a unit.");
                return false;
            }
            unitId = CurrentUnit.Current.unitId;

            return true;
        }

        private void HandleResponse(bool response)
        {
            if (response)
            {
                ProductHome.Instance?.RefreshDisplay();
                CleanForm();
                LoggerHelper.Write("RESPONSE", $"Received response: {response}");
            }
        }

        private void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CleanForm()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cboCategory.SelectedIndex = 0;
            cboSubCategory.SelectedIndex = 0;
            cboUnit.SelectedIndex = 0;
            pbImage.Image = null;
            pbImage.Image = Properties.Resources.AddImage100x100_w;
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

        public void GetSubCategory()
        {
            LoggerHelper.Write("SUBCATEGORY DEBUG", "Starting GetSubCategory method");

            cboSubCategory.Items.Clear();
            cboSubCategory.Items.Add("Select SubCategory");

            int selectedCategoryId = CurrentCategory.Current?.Id ?? 0;
            LoggerHelper.Write("SUBCATEGORY DEBUG", $"Selected Category ID: {selectedCategoryId}");

            LoggerHelper.Write("SUBCATEGORY DEBUG",
                $"Total subcategories in AllSubCategories: {CurrentSubCategory.AllSubCategories.Count}");

            var subcategories = CurrentSubCategory.AllSubCategories
                .Where(sc => sc.catId == selectedCategoryId)
                .ToList();

            LoggerHelper.Write("SUBCATEGORY DEBUG",
                $"Found {subcategories.Count} subcategories for category {selectedCategoryId}");

            foreach (var sc in CurrentSubCategory.AllSubCategories)
            {
                LoggerHelper.Write("SUBCATEGORY DEBUG",
                    $"Subcategory - ID: {sc.scId}, CategoryID: {sc.catId}, Name: {sc.scName}");
            }

            foreach (var subcategory in subcategories)
            {
                if (subcategory != null && !string.IsNullOrEmpty(subcategory.scName))
                {
                    cboSubCategory.Items.Add(subcategory.scName);
                    LoggerHelper.Write("SUBCATEGORY DEBUG", $"Added subcategory: {subcategory.scName}");
                }
            }

            cboSubCategory.Items.Add("+ Add SubCategory");
            cboSubCategory.SelectedIndex = 0;

            LoggerHelper.Write("SUBCATEGORY DEBUG",
                $"Final combobox items count: {cboSubCategory.Items.Count}");
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoggerHelper.Write("CATEGORY DEBUG", $"Category selection changed. Index: {cboCategory.SelectedIndex}");

            if (cboCategory.SelectedIndex == 0)
            {
                CurrentCategory.SetCurrentCategory(null);
                CurrentSubCategory.SetCurrentSubCategory(null);
                GetSubCategory();
                return;
            }

            if (cboCategory.SelectedIndex == cboCategory.Items.Count - 1)
            {
                //CurrentCategory.Clear();
                NewCategory newCategory = new NewCategory("Create Category", "Category", "Enter category name", this);
                newCategory.StartPosition = FormStartPosition.Manual;
                newCategory.StartPosition = FormStartPosition.CenterParent;
                newCategory.ShowDialog(this);

                //cboCategory.SelectedIndex = 0;
                return;
            }

            if (cboCategory.SelectedIndex > 0 &&
                CurrentCategory.AllCategories != null &&
                (cboCategory.SelectedIndex - 1) < CurrentCategory.AllCategories.Count)
            {
                try
                {
                    var selectedCategory = CurrentCategory.AllCategories[cboCategory.SelectedIndex - 1];
                    LoggerHelper.Write("CATEGORY DEBUG",
                        $"Selected category object - Name: {selectedCategory?.Name}, ID: {selectedCategory?.Id}");

                    if (selectedCategory != null && selectedCategory.Id > 0)
                    {
                        CurrentCategory.SetCurrentCategory(selectedCategory);
                        LoggerHelper.Write("CATEGORY DEBUG",
                            $"Set current category: {selectedCategory.Name} (ID: {selectedCategory.Id})");
                        GetSubCategory();
                    }
                    else
                    {
                        LoggerHelper.Write("CATEGORY DEBUG", "Selected category is null or has invalid ID");
                        MessageBox.Show("Invalid category selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboCategory.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    LoggerHelper.Write("CATEGORY ERROR", $"Error selecting category: {ex.Message}");
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
                    NewCategory newCategory = new NewCategory("Create SubCategory", "Category", "Enter subcategory name", this);
                    newCategory.StartPosition = FormStartPosition.Manual;
                    newCategory.StartPosition = FormStartPosition.CenterParent;
                    newCategory.ShowDialog(this);
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
                        LoggerHelper.Write("UNIT", "Skipped adding null or empty unit name");
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
                NewUnit newUnit = new NewUnit(this);
                newUnit.StartPosition = FormStartPosition.Manual;
                newUnit.StartPosition = FormStartPosition.CenterParent;
                newUnit.ShowDialog(this);
                cboUnit.SelectedIndex = 0;
                return;
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
                        LoggerHelper.Write("UNIT", "Selected unit is null or has invalid ID");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddProduct_Activated(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox)
            {
                e.Handled = true;
                return;
            }

            bool isNumber = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == (char)Keys.Back;
            bool isDecimalPoint = e.KeyChar == '.';
            bool hasDecimalPoint = textBox.Text.Contains(".");

            e.Handled = !isNumber && !isBackspace && !(isDecimalPoint && !hasDecimalPoint);
        }

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private Label messageLabel = new Label();

        private void InitializeLoadingControls()
        {
            loadingPanel.BackColor = Color.White;
            loadingPanel.BorderStyle = BorderStyle.None;
            loadingPanel.Size = new Size(300, 150);
            loadingPanel.Location = new Point(
                (this.ClientSize.Width - loadingPanel.Width) / 2,
                (this.ClientSize.Height - loadingPanel.Height) / 2
            );

            panelBox.Size = new Size(64, 64);
            panelBox.Location = new Point(
                (loadingPanel.Width - panelBox.Width) / 2,
                20
            );
            panelBox.BorderStyle = BorderStyle.None;
            panelBox.BackColor = Color.White;

            pictureBox.Size = new Size(24, 24);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(
                (panelBox.Width - pictureBox.Width) / 2,
                (panelBox.Height - pictureBox.Height) / 2
            );

            try
            {
                pictureBox.Image = Properties.Resources.loading_gif;
            }
            catch
            {
                pictureBox.BackColor = Color.LightGray;
            }

            messageLabel.AutoSize = false;
            messageLabel.Size = new Size(280, 30);
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Location = new Point(
                (loadingPanel.Width - messageLabel.Width) / 2,
                panelBox.Bottom + 8
            );
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            panelBox.Controls.Add(pictureBox);
            loadingPanel.Controls.Add(panelBox);
            loadingPanel.Controls.Add(messageLabel);
            this.Controls.Add(loadingPanel);
        }

        private void ShowLoading(string message)
        {
            if (!this.Controls.Contains(loadingPanel))
            {
                InitializeLoadingControls();
            }

            messageLabel.Text = message;
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;
            Application.DoEvents();
        }

        private void HideLoading()
        {
            if (loadingPanel != null)
            {
                loadingPanel.Visible = false;
            }
        }
    }
}
