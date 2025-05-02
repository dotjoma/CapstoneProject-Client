using client.Forms.InventoryManagement;
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

namespace client.Forms.ProductManagement
{
    public partial class AddIngredientToRecipe : Form
    {
        private System.Threading.Timer? _searchTimer;
        private string _lastSearchText = string.Empty;
        private Form _parentForm;

        public AddIngredientToRecipe(Form parentForm)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            _parentForm = parentForm;
        }

        private void AddIngredientToRecipe_Load(object sender, EventArgs e)
        {
            GetInventoryItems();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            dgvIngredients.Rows.Clear();

            if (RecipeBuilder.SelectedIngredients.Count == 0)
            {
                //MessageBox.Show("No saved recipe ingredients found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logger.Write("ITEMS_WARNING", "No saved recipe ingredients found.");
                return;
            }

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var item = entry.Value.item;
                var quantity = entry.Value.quantity;

                dgvIngredients.Rows.Add(
                    item.ItemName,
                    quantity,
                    Properties.Resources.trash_red_20
                );
            }

            dgvIngredients.ClearSelection();
        }

        public void GetInventoryItems()
        {
            cboIngredient.Items.Clear();

            cboIngredient.Items.Add("– Select ingredient –");

            var items = CurrentInventoryItem.AllItems;

            if (items != null && items.Count > 0)
            {
                foreach (var ut in items)
                {
                    if (!string.IsNullOrEmpty(ut.ItemName))
                    {
                        cboIngredient.Items.Add(ut.ItemName);
                    }
                    else
                    {
                        Logger.Write("ITEMS_WARNING", "Item name is null or empty, skipping.");
                    }
                }

                cboIngredient.SelectedIndex = 0;
            }
            else
            {
                Logger.Write("ITEMS_WARNING", "No items found.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RecipeBuilder.SelectedIngredients.Clear();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RecipeBuilder.SelectedIngredients.Count == 0)
            {
                MessageBox.Show("No ingredients added.", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string recipeSummary = "Recipe Saved:\n\n";

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var item = entry.Value.item;
                var quantity = entry.Value.quantity;
                recipeSummary += $"- {item.ItemName} (ID: {item.ItemId}) x{quantity}\n";
            }

            if (_parentForm is AddProduct addprodfrm)
            {
                addprodfrm.DisplayIngredientsSummary();
            }

            this.Dispose();

            //MessageBox.Show(recipeSummary, "Recipe Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SetSelectedIngredient(string? itemName)
        {
            if (!string.IsNullOrEmpty(itemName))
            {
                cboIngredient.SelectedItem = itemName;
            }
        }

        private void cboIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIngredient.SelectedIndex == 0)
            {
                CurrentInventoryItem.SetCurrentItem(null);
                return;
            }

            if (cboIngredient.SelectedIndex > 0 &&
                CurrentInventoryItem.AllItems != null &&
                (cboIngredient.SelectedIndex - 1) < CurrentInventoryItem.AllItems.Count)
            {
                try
                {
                    var selectedItem = CurrentInventoryItem.AllItems[cboIngredient.SelectedIndex - 1];

                    if (selectedItem != null && selectedItem.ItemId > 0)
                    {
                        CurrentInventoryItem.SetCurrentItem(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Invalid item selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboIngredient.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting item: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboIngredient.SelectedIndex = 0;
                }
            }
            else
            {
                cboIngredient.SelectedIndex = 0;
            }
        }

        private void cboIngredient_TextChanged(object sender, EventArgs e)
        {
            //string searchText = cboIngredient.Text.ToLower();

            //if (searchText == _lastSearchText)
            //    return;

            //_lastSearchText = searchText;

            //_searchTimer?.Dispose();

            //_searchTimer = new System.Threading.Timer(_ =>
            //{
            //    cboIngredient.Invoke((MethodInvoker)delegate
            //    {
            //        if (string.IsNullOrWhiteSpace(searchText))
            //        {
            //            cboIngredient.DroppedDown = false;
            //            return;
            //        }

            //        int originalSelectionStart = cboIngredient.SelectionStart;
            //        int originalSelectionLength = cboIngredient.SelectionLength;
            //        string originalText = cboIngredient.Text;

            //        bool found = false;
            //        for (int i = 0; i < cboIngredient.Items.Count; i++)
            //        {
            //            string? itemText = cboIngredient.Items[i]?.ToString()?.ToLower();
            //            if (!string.IsNullOrEmpty(itemText) && itemText.Contains(searchText))
            //            {
            //                found = true;
            //                break;
            //            }
            //        }

            //        if (found)
            //        {
            //            cboIngredient.DroppedDown = true;
            //            cboIngredient.Text = originalText;
            //            cboIngredient.SelectionStart = originalSelectionStart;
            //            cboIngredient.SelectionLength = originalSelectionLength;
            //        }
            //        else
            //        {
            //            cboIngredient.DroppedDown = false;
            //        }
            //    });
            //}, null, 300, Timeout.Infinite);
        }

        private void AddIngredientToRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            _searchTimer?.Dispose();
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            using (var searchIngredients = new SearchIngredients(this))
            {
                this.Hide();
                searchIngredients.StartPosition = FormStartPosition.Manual;
                searchIngredients.StartPosition = FormStartPosition.CenterParent;
                searchIngredients.ShowDialog(this);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CurrentInventoryItem.Current == null)
            {
                MessageBox.Show("Please select an ingredient first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtQuantity.Text) || !decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = CurrentInventoryItem.Current;

            if (RecipeBuilder.SelectedIngredients.TryGetValue(item.ItemId, out var existing))
            {
                RecipeBuilder.SelectedIngredients[item.ItemId] = (item, existing.quantity + quantity, item.UnitMeasureSymbol);
            }
            else
            {
                RecipeBuilder.SelectedIngredients[item.ItemId] = (item, quantity, item.UnitMeasureSymbol);
            }

            dgvIngredients.Rows.Clear();

            foreach (var entry in RecipeBuilder.SelectedIngredients)
            {
                var i = entry.Value.item;
                var q = entry.Value.quantity;

                dgvIngredients.Rows.Add(
                    i.ItemName, 
                    q,
                    Properties.Resources.trash_red_20
                );
            }

            dgvIngredients.ClearSelection();

            ResetForm();
        }

        private void ResetForm()
        {
            cboIngredient.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
        }

        private void dgvIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvIngredients.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                dgvIngredients.ClearSelection();

                var row = dgvIngredients.Rows[e.RowIndex];
                string? ingredientName = row.Cells["ingredient"].Value?.ToString();
                string? quantityText = row.Cells["quantity"].Value?.ToString();

                if (decimal.TryParse(quantityText, out decimal quantity))
                {
                    var entryToRemove = RecipeBuilder.SelectedIngredients
                        .FirstOrDefault(kvp => kvp.Value.item.ItemName == ingredientName && kvp.Value.quantity == quantity);

                    if (!entryToRemove.Equals(default(KeyValuePair<int, (InventoryItem item, decimal quantity)>)))
                    {
                        RecipeBuilder.SelectedIngredients.Remove(entryToRemove.Key);
                    }
                }

                dgvIngredients.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
