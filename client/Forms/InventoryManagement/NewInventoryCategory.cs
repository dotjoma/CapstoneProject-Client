using client.Controllers;
using client.Forms.ProductManagement;
using client.Helpers;
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

namespace client.Forms.InventoryManagement
{
    public partial class NewInventoryCategory : Form
    {
        CategoryController _categoryController = new CategoryController();
        SubCategoryController _subCategoryController = new SubCategoryController();

        private int? selectedCategoryId = CurrentInventoryCategory.Current?.Id;

        private string _title = string.Empty;
        private string _name = string.Empty;
        private string _label = string.Empty;

        private readonly AddInventoryItem _parentForm;
        public NewInventoryCategory(string title, string label, string name, AddInventoryItem parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this._title = title;
            this._name = name;
            this._label = label;
            if (_label == "Category") selectedCategoryId = null;

            _parentForm = parent;
        }

        private void NewInventoryCategory_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _title;
            txtName.PlaceholderText = _name;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //ToggleButton(false);
            //ShowLoading("Creating new category...");
            await Task.Delay(50);

            string name = txtName.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (_label)
                {
                    case "Category":
                        HandleCategory(name);
                        break;
                    case "Subcategory":
                        HandleCategory(name);
                        break;
                    case "Unit":
                        //HandleUnit(name);
                        break;
                    default:
                        Logger.Write("CREATE UNIT/CATEGORY", "Unknown data received!");
                        break;
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
                //ToggleButton(true);
            }
        }

        private async void HandleCategory(string categoryName)
        {
            if (selectedCategoryId == null)
            {
                bool response = await _categoryController.CreateInventoryCategory(categoryName);
                if (response)
                {
                    this.Dispose();

                    bool getCategories = await _categoryController.GetInventoryCategory();
                    if (getCategories)
                    {
                        _parentForm.GetInventoryCategory();
                    }
                }
                else
                {
                    //ToggleButton(true);
                }
            }
            else // Create sub category
            {
                bool response = await _subCategoryController.CreateInventorySubCategory(categoryName, (int)selectedCategoryId);
                if (response)
                {
                    CurrentInventorySubCategory.SetCurrentInventorySubCategory(null);

                    this.Dispose();

                    var getCategories = await _subCategoryController.GetAllInventorySubcategory();
                    if (getCategories.Any())
                    {
                        _parentForm.GetInventorySubCategory();
                    }
                }
                else
                {
                    //HideLoading();
                    //ToggleButton(true);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
