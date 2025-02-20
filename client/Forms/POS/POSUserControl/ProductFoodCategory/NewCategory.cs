using client.Controllers;
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
using static System.Windows.Forms.DataFormats;

namespace client.Forms.POS.POSUserControl.ProductFoodCategory
{
    public partial class NewCategory : Form
    {
        private readonly CategoryController _categoryController;
        private readonly SubCategoryController _subCategoryController;

        private int? selectedCategoryId = CurrentCategory.Current?.Id;
        private string title = string.Empty;
        private string label = string.Empty;
        private string name = string.Empty;

        private UC_Products _ucProducts;

        public NewCategory(string title, string label, string name, UC_Products uc_Prod)
        {
            InitializeComponent();
            this.title = title;
            this.label = label;
            this.name = name;
            _categoryController = new CategoryController();
            _subCategoryController = new SubCategoryController();

            _ucProducts = uc_Prod;
            lblSelectedId.Text = selectedCategoryId.ToString();
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            txtTitle.Text = title;
            lblLabel.Text = label;
            txtName.PlaceholderText = name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtName.Text.Length) > 0)
            {
                if (MessageBox.Show("Discard changes?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }
        
        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            await Task.Delay(1);

            string categoryName = txtName.Text.Trim();

            try
            {
                if (selectedCategoryId == null) // Create new category.
                {
                    bool response = await _categoryController.Create(categoryName);
                    if (response)
                    {
                        MessageBox.Show($"Category '{categoryName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();

                        bool getCategories = await _categoryController.Get();
                        if (getCategories)
                        {
                            _ucProducts.RefreshCategories();
                        }
                    }
                    else
                    {
                        ToggleButton(true);
                    }
                }
                else // Create sub category
                {
                    bool response = await _subCategoryController.Create(categoryName, (int)selectedCategoryId);
                    if (response)
                    {
                        MessageBox.Show($"Subcategory '{categoryName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();

                        bool getCategories = await _subCategoryController.Get((int)selectedCategoryId);
                        if (getCategories)
                        {
                            _ucProducts.RefreshCategories();
                        }
                    }
                    else
                    {
                        ToggleButton(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), 
                    "Error", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            string message = (tog) ? "Save" : "Saving...";
            btnSave.Text = message;
        }
    }
}
