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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace client.Forms.InventoryManagement
{
    public partial class AddInventoryItem : Form
    {
        SubCategoryController _subCategoryController = new SubCategoryController();
        UnitController _unitController = new UnitController();

        public AddInventoryItem()
        {
            InitializeComponent();
        }
        private void AddInventoryItem_Load(object sender, EventArgs e)
        {
            LoadDatabase();
            InitializeComboboxes();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInventoryItem();
        }

        private bool ValidateInputs(out string errorMessage, out Control? errorControl)
        {
            errorMessage = string.Empty;
            errorControl = null;

            // Required field validations
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                errorMessage = "Item name is required";
                errorControl = txtItemName;
                return false;
            }

            if (cboCategory.SelectedItem == null)
            {
                errorMessage = "Category is required";
                errorControl = cboCategory;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBatchNumber.Text))
            {
                errorMessage = "Batch number is required";
                errorControl = txtBatchNumber;
                return false;
            }

            // Date validation
            if (dtpExpiration.Value <= dtpPurchase.Value)
            {
                errorMessage = "Expiration date must be after purchase date";
                errorControl = dtpExpiration;
                return false;
            }

            // Numeric field validations
            if (!ValidateNumericField(txtBatchQuantity, "Batch quantity", out errorMessage))
            {
                errorControl = txtBatchQuantity;
                return false;
            }

            if (!ValidateNumericField(txtMinimumStock, "Minimum stock level", out errorMessage))
            {
                errorControl = txtMinimumStock;
                return false;
            }

            if (!ValidateNumericField(txtUnitCost, "Unit cost", out errorMessage))
            {
                errorControl = txtUnitCost;
                return false;
            }

            // Dropdown validations
            if (cboUnitType.SelectedItem == null)
            {
                errorMessage = "Unit type is required";
                errorControl = cboUnitType;
                return false;
            }

            return true;
        }

        private bool ValidateNumericField(TextBox textBox, string fieldName, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!decimal.TryParse(textBox.Text, out decimal value) || value <= 0)
            {
                errorMessage = $"Valid {fieldName} is required (must be positive number)";
                return false;
            }

            return true;
        }


        private async void LoadDatabase()
        {
            var subCategoriesTask = _subCategoryController.GetAllInventorySubcategory();


            await Task.WhenAll(subCategoriesTask);

            if (CurrentInventoryCategory.AllInventoryCategories == null)
            {
                Logger.Write("INVENTORY_SUBCATEGORY", "Failed to load inventory subcategories");
            }
            else
            {
                Logger.Write("INVENTORY_SUBCATEGORY", $"Successfully loaded {CurrentInventoryCategory.AllInventoryCategories.Count} inventory subcategories");
            }
        }

        private void InitializeComboboxes()
        {
            try
            {
                GetInventoryCategory();
                GetInventorySubCategory();
                GetInventoryUnitType();
                GetInventoryUnitMeasure();
            }
            catch (Exception ex)
            {
                Logger.Write("INIT ERROR", $"Failed to initialize comboboxes: {ex.Message}");
                return;
            }
        }

        private void SaveInventoryItem()
        {
            if (!ValidateInputs(out string errorMessage, out Control? errorControl))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorControl?.Focus();
                return;
            }

            string itemName = txtItemName.Text.Trim();
            string? category = cboCategory.SelectedItem?.ToString();
            string? subCategory = cboSubcategory.SelectedItem?.ToString();
            string batchNumber = txtBatchNumber.Text.Trim();
            DateTime purchaseDate = dtpPurchase.Value;
            DateTime expirationDate = dtpExpiration.Value;
            decimal batchQuantity = decimal.Parse(txtBatchQuantity.Text.Trim());
            string? unitType = cboUnitType.SelectedItem?.ToString();
            string? unitMeasure = cboUnitMeasure.SelectedItem?.ToString();
            decimal minStockLevel = decimal.Parse(txtMinimumStock.Text.Trim());
            decimal maxStockLevel = decimal.Parse(txtMaximumStock.Text.Trim());
            decimal reorderPoint = decimal.Parse(txtRestorePoint.Text.Trim());
            int leadeTimeDays = int.Parse(txtLeadTime.Text.Trim());
            int targetTurnoverDays = int.Parse(txtTargetTurnover.Text.Trim());
            decimal unitCost = decimal.Parse(txtUnitCost.Text.Trim());
            string? supplier = cboSupplier.SelectedItem?.ToString();
            bool enableLowStockAlert = cbLowStockAlerts.Checked;

            try
            {
                // TODO:
                // implement the actual inserting of inventory items here.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("INVENTORY_EXCEPTION", $"Error adding new item: {ex.Message}");
            }
        }

        public void GetInventoryCategory()
        {
            Logger.Write("INVENTORY_CATEGORY_DEBUG", "Starting GetInventoryCategory method");

            cboCategory.Items.Clear();
            cboCategory.Items.Add("Select Category");

            var categories = CurrentInventoryCategory.AllInventoryCategories;

            Logger.Write("INVENTORY_CATEGORY_DEBUG", $"Retrieved {categories.Count} categories from CurrentInventoryCategory.");
            Logger.Write("GET ALL INVENTORY CATEGORIES", $"Categories after setting: {string.Join(", ", categories.Select(c => c.Name))}");

            if (categories != null && categories.Count > 0)
            {
                foreach (var category in categories)
                {
                    Logger.Write("INVENTORY_CATEGORY_DEBUG", $"Category ID: {category.Id}, Name: {category.Name}");

                    if (!string.IsNullOrEmpty(category.Name))
                    {
                        cboCategory.Items.Add(category.Name);
                        Logger.Write("INVENTORY_CATEGORY_DEBUG", $"Added category: {category.Name}");
                    }
                    else
                    {
                        Logger.Write("CATEGORY WARNING", "Category name is null or empty, skipping.");
                    }
                }
            }
            else
            {
                Logger.Write("CATEGORY WARNING", "No categories found.");
            }

            cboCategory.Items.Add("+ Add Category");
            cboCategory.SelectedIndex = 0;

            Logger.Write("INVENTORY_CATEGORY_DEBUG", $"Final combobox items count: {cboCategory.Items.Count}");
        }

        public void GetInventorySubCategory()
        {
            Logger.Write("SUBCATEGORY DEBUG", "Starting GetSubCategory method");

            cboSubcategory.Items.Clear();
            cboSubcategory.Items.Add("Select SubCategory");

            int selectedCategoryId = CurrentInventoryCategory.Current?.Id ?? 0;
            Logger.Write("SUBCATEGORY DEBUG", $"Selected Category ID: {selectedCategoryId}");

            Logger.Write("SUBCATEGORY DEBUG",
                $"Total subcategories in AllInventorySubCategories: {CurrentInventorySubCategory.AllInventorySubCategories.Count}");

            var subcategories = CurrentInventorySubCategory.AllInventorySubCategories
                .Where(sc => sc.catId == selectedCategoryId)
                .ToList();

            Logger.Write("SUBCATEGORY DEBUG",
                $"Found {subcategories.Count} subcategories for category {selectedCategoryId}");

            foreach (var sc in CurrentInventorySubCategory.AllInventorySubCategories)
            {
                Logger.Write("SUBCATEGORY DEBUG",
                    $"Subcategory - ID: {sc.scId}, CategoryID: {sc.catId}, Name: {sc.scName}");
            }

            foreach (var subcategory in subcategories)
            {
                if (subcategory != null && !string.IsNullOrEmpty(subcategory.scName))
                {
                    cboSubcategory.Items.Add(subcategory.scName);
                    Logger.Write("SUBCATEGORY DEBUG", $"Added subcategory: {subcategory.scName}");
                }
            }

            cboSubcategory.Items.Add("+ Add SubCategory");
            cboSubcategory.SelectedIndex = 0;

            Logger.Write("SUBCATEGORY DEBUG",
                $"Final combobox items count: {cboSubcategory.Items.Count}");
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Write("CATEGORY DEBUG", $"Category selection changed. Index: {cboCategory.SelectedIndex}");

            if (cboCategory.SelectedIndex == 0)
            {
                CurrentInventoryCategory.SetCurrenInventorytCategory(null);
                CurrentInventorySubCategory.SetCurrentInventorySubCategory(null);
                GetInventorySubCategory();
                return;
            }

            if (cboCategory.SelectedIndex == cboCategory.Items.Count - 1)
            {
                using (var newcatfrm = new NewInventoryCategory("Create Category", "Category", "Enter category name", this))
                {
                    newcatfrm.StartPosition = FormStartPosition.Manual;
                    newcatfrm.StartPosition = FormStartPosition.CenterParent;
                    newcatfrm.ShowDialog(this);
                }

                return;
            }

            if (cboCategory.SelectedIndex > 0 &&
                CurrentInventoryCategory.AllInventoryCategories != null &&
                (cboCategory.SelectedIndex - 1) < CurrentInventoryCategory.AllInventoryCategories.Count)
            {
                try
                {
                    var selectedCategory = CurrentInventoryCategory.AllInventoryCategories[cboCategory.SelectedIndex - 1];

                    if (selectedCategory != null && selectedCategory.Id > 0)
                    {
                        CurrentInventoryCategory.SetCurrenInventorytCategory(selectedCategory);
                        GetInventorySubCategory();
                    }
                    else
                    {
                        MessageBox.Show("Invalid category selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboCategory.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Write("CATEGORY ERROR", $"Error selecting category: {ex.Message}");
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

        private void cboSubcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubcategory.SelectedIndex == 0)
            {
                return;
            }

            if (cboSubcategory.SelectedIndex == cboSubcategory.Items.Count - 1)
            {
                if (CurrentInventoryCategory.Current?.Id == null)
                {
                    MessageBox.Show("Select category to add sub category", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (var newsubfrm = new NewInventoryCategory("Create SubCategory", "Subcategory", "Enter subcategory name", this))
                    {
                        newsubfrm.StartPosition = FormStartPosition.Manual;
                        newsubfrm.StartPosition = FormStartPosition.CenterParent;
                        newsubfrm.ShowDialog(this);
                    }

                    cboSubcategory.SelectedIndex = 0;
                }
                return;
            }

            if (cboSubcategory.SelectedIndex > 0 &&
                CurrentInventorySubCategory.AllInventorySubCategories != null &&
                (cboSubcategory.SelectedIndex - 1) < CurrentInventorySubCategory.AllInventorySubCategories.Count)
            {
                try
                {
                    var selectedSubCategory = CurrentInventorySubCategory.AllInventorySubCategories[cboSubcategory.SelectedIndex - 1];
                    CurrentInventorySubCategory.SetCurrentInventorySubCategory(selectedSubCategory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting subcategory: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboSubcategory.SelectedIndex = 0;
                }
            }
            else
            {
                cboSubcategory.SelectedIndex = 0;
            }
        }

        public void GetInventoryUnitType()
        {
            cboUnitType.Items.Clear();
            cboUnitType.Items.Add("Select UnitType");

            var unitTypes = CurrentInventoryUnitType.AllUnitTypes;

            if (unitTypes != null && unitTypes.Count > 0)
            {
                foreach (var ut in unitTypes)
                {
                    if (!string.IsNullOrEmpty(ut.UnitName))
                    {
                        //cboUnitType.Items.Add($"{ut.UnitName} ({ut.UnitSymbol})");
                        cboUnitType.Items.Add(ut.UnitName);
                    }
                    else
                    {
                        Logger.Write("UNIT_TYPE_WARNING", "UnitType name is null or empty, skipping.");
                    }
                }
            }
            else
            {
                Logger.Write("UNIT_TYPE_WARNING", "No unittypes found.");
            }

            cboUnitType.Items.Add("+ Add UnitType");
            cboUnitType.SelectedIndex = 0;
        }

        private void cboUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnitType.SelectedIndex == 0)
            {
                CurrentInventoryUnitType.SetCurrentUnitType(null);
                return;
            }

            if (cboUnitType.SelectedIndex == cboUnitType.Items.Count - 1)
            {
                using (var newunitfrm = new NewUnit("Create Unit Type", "UnitType", "Enter unit type name", this))
                {
                    newunitfrm.StartPosition = FormStartPosition.Manual;
                    newunitfrm.StartPosition = FormStartPosition.CenterParent;
                    newunitfrm.ShowDialog(this);
                }

                return;
            }

            if (cboUnitType.SelectedIndex > 0 &&
                CurrentInventoryUnitType.AllUnitTypes != null &&
                (cboUnitType.SelectedIndex - 1) < CurrentInventoryUnitType.AllUnitTypes.Count)
            {
                try
                {
                    var selectedUnitType = CurrentInventoryUnitType.AllUnitTypes[cboUnitType.SelectedIndex - 1];

                    if (selectedUnitType != null && selectedUnitType.Id > 0)
                    {
                        CurrentInventoryUnitType.SetCurrentUnitType(selectedUnitType);
                    }
                    else
                    {
                        MessageBox.Show("Invalid unit type selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboUnitType.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting unittype: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboUnitType.SelectedIndex = 0;
                }
            }
            else
            {
                cboUnitType.SelectedIndex = 0;
            }
        }

        public void GetInventoryUnitMeasure()
        {
            cboUnitMeasure.Items.Clear();
            cboUnitMeasure.Items.Add("Select UnitMeasure");

            var unitMeasures = CurrentInventoryUnitMeasure.AllUnitMeasures;

            if (unitMeasures != null && unitMeasures.Count > 0)
            {
                foreach (var um in unitMeasures)
                {
                    if (!string.IsNullOrEmpty(um.measureName))
                    {

                        if (!string.IsNullOrEmpty(um.measureSymbol))
                        {
                            cboUnitMeasure.Items.Add($"{um.measureName} ({um.measureSymbol})");
                        }
                        else
                        {
                            cboUnitMeasure.Items.Add($"{um.measureName}");
                        }
                    }
                    else
                    {
                        Logger.Write("UNIT_MEASURE_WARNING", "UnitMeasure name is null or empty, skipping.");
                    }
                }
            }
            else
            {
                Logger.Write("UNIT_MEASURE_WARNING", "No unit measures found.");
            }

            cboUnitMeasure.Items.Add("+ Add UnitMeasure");
            cboUnitMeasure.SelectedIndex = 0;
        }

        private void cboUnitMeasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnitMeasure.SelectedIndex == 0)
            {
                CurrentInventoryUnitMeasure.SetCurrentUnitMeasure(null);
                return;
            }

            if (cboUnitMeasure.SelectedIndex == cboUnitMeasure.Items.Count - 1)
            {
                using (var newunitfrm = new NewUnit("Create Unit Measure", "UnitMeasure", "Enter unit measure name", this))
                {
                    newunitfrm.StartPosition = FormStartPosition.Manual;
                    newunitfrm.StartPosition = FormStartPosition.CenterParent;
                    newunitfrm.ShowDialog(this);
                }

                return;
            }

            if (cboUnitMeasure.SelectedIndex > 0 &&
                CurrentInventoryUnitMeasure.AllUnitMeasures != null &&
                (cboUnitMeasure.SelectedIndex - 1) < CurrentInventoryUnitMeasure.AllUnitMeasures.Count)
            {
                try
                {
                    var selectedUnitMeasure = CurrentInventoryUnitMeasure.AllUnitMeasures[cboUnitMeasure.SelectedIndex - 1];

                    if (selectedUnitMeasure != null && selectedUnitMeasure.Id > 0)
                    {
                        CurrentInventoryUnitMeasure.SetCurrentUnitMeasure(selectedUnitMeasure);
                    }
                    else
                    {
                        MessageBox.Show("Invalid unit measure selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboUnitMeasure.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting unit measure: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboUnitMeasure.SelectedIndex = 0;
                }
            }
            else
            {
                cboUnitMeasure.SelectedIndex = 0;
            }
        }
    }
}
