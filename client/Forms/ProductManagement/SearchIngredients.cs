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
    public partial class SearchIngredients : Form
    {
        private Form _parentForm;
        private string? _selectedItemName;

        public SearchIngredients(Form parentForm)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            _parentForm = parentForm;
        }

        private void SearchIngredients_Load(object sender, EventArgs e)
        {
            DisplayIngredientsInListbox();
        }

        private void DisplayIngredientsInListbox()
        {
            var items = CurrentInventoryItem.AllItems
            .Where(ut => !string.IsNullOrEmpty(ut.ItemName))
            .ToList();

            if (items == null || items.Count == 0)
            {
                Logger.Write("ITEMS_WARNING", "No valid items found.");
                lbIngredients.DataSource = null;
                return;
            }

            lbIngredients.DisplayMember = "ItemName";
            lbIngredients.ValueMember = "ItemId";
            lbIngredients.DataSource = items;
            lbIngredients.ClearSelected();
        }

        private void lbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lbIngredients.SelectedItem == null) return;
            //var selectedItem = (InventoryItem)lbIngredients.SelectedItem;
            //MessageBox.Show(Text + " " + selectedItem.ItemId.ToString() + " " + selectedItem.ItemName, "Item Selected",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_parentForm is AddIngredientToRecipe addIngredientToRecipe)
            {
                addIngredientToRecipe.SetSelectedIngredient(string.Empty);
                addIngredientToRecipe.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Parent form is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbIngredients_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lbIngredients.IndexFromPoint(e.Location);

            if (index != ListBox.NoMatches)
            {
                var clickedItem = (InventoryItem)lbIngredients.Items[index];
                if (clickedItem != null)
                {
                    _selectedItemName = clickedItem.ItemName;
                    //MessageBox.Show($"Mouse clicked on: {clickedItem.ItemId} {clickedItem.ItemName}");
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbIngredients.SelectedItem is InventoryItem selectedItem)
                {
                    if (_parentForm is AddIngredientToRecipe addIngredientToRecipe)
                    {
                        addIngredientToRecipe.SetSelectedIngredient(_selectedItemName);
                        addIngredientToRecipe.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Parent form is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an ingredient from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
