using client.Controllers;
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

namespace client.Forms.InventoryManagement
{
    public partial class InventoryHome : Form
    {
        private InventoryController _inventoryController = new InventoryController();
        public InventoryHome()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (var addnewfrm = new AddInventoryItem())
            {
                addnewfrm.ShowDialog();
            }
        }

        private void InventoryHome_Load(object sender, EventArgs e)
        {
            DisplayInventoryItems();
        }

        public void DisplayInventoryItems()
        {
            try
            {
                dgvInventory.Rows.Clear();

                var items = CurrentInventoryItem.AllItems;

                foreach (var item in items)
                {
                    string categoryName = item.CategoryName ?? "Unknown";
                    string unitTypeName = item.UnitTypeName ?? "N/A";
                    string measureName = item.UnitMeasureName ?? "N/A";

                    decimal currentStock = item.Batches?.Sum(b => b.CurrentQuantity) ?? 0;
                    decimal maxStock = item.MaxStockLevel;
                    string stockStatus = (currentStock <= item.MinStockLevel) ? "Low Stock" : "Sufficient Stock";

                    dgvInventory.Rows.Add(
                        item.ItemName,
                        categoryName,
                        $"{unitTypeName}/{measureName}",
                        $"{currentStock}/{maxStock}",
                        item.MinStockLevel,
                        item.ReorderPoint,
                        item.Batches?.Count ?? 0,
                        GetUnitCost(item),
                        GetExpirationDates(item),
                        stockStatus,
                        GetSupplierNames(item),
                        "Add Batch",
                        "View Batches"
                    );
                }

                dgvInventory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory items: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void RefreshInventory()
        {
            try
            {
                CurrentInventoryItem.Clear();

                await _inventoryController.GetAllInventoryItems();

                if (CurrentInventoryItem.AllItems == null)
                {
                    Logger.Write("INVENTORY REFRESH", "Failed to refresh inventory from the database or no items found.");
                }
                else
                {
                    DisplayInventoryItems();
                    Logger.Write("INVENTORY REFRESH", $"Successfully refreshed inventory from the database. Loaded {CurrentInventoryItem.AllItems.Count} items.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing inventory: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Write("INVENTORY REFRESH", $"Error occurred during inventory refresh: {ex.Message}");
            }
        }

        private string GetExpirationDates(InventoryItem item)
        {
            if (item.Batches == null || item.Batches.Count == 0)
                return "N/A";

            return string.Join(", ", item.Batches
                .Where(b => b.ExpirationDate.HasValue)
                .Select(b => b.ExpirationDate!.Value.ToString("yyyy-MM-dd")));
        }

        private string GetSupplierNames(InventoryItem item)
        {
            if (item.Batches == null || item.Batches.Count == 0)
                return "N/A";

            var suppliers = item.Batches
                .Select(b => b.SupplierName?.Trim())
                .Where(name => !string.IsNullOrWhiteSpace(name))
                .Distinct();

            return suppliers.Any() ? string.Join(", ", suppliers) : "N/A";
        }

        private decimal GetUnitCost(InventoryItem item)
        {
            if (item.Batches == null || item.Batches.Count == 0)
                return 0;

            return item.Batches.FirstOrDefault()?.UnitCost ?? 0;
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string? cellValue = dgvInventory[e.ColumnIndex, e.RowIndex].Value?.ToString();

            var selectedItem = CurrentInventoryItem.AllItems[e.RowIndex];

            if (cellValue == "Add Batch")
            {
                using (var abfrm = new AddBatch(selectedItem, this))
                {
                    abfrm.StartPosition = FormStartPosition.Manual;
                    abfrm.StartPosition = FormStartPosition.CenterParent;
                    abfrm.ShowDialog(this);
                }
            }
            else if (cellValue == "View Batches")
            {
                using (var vbfrm = new ViewBatches(selectedItem, this))
                {
                    vbfrm.StartPosition = FormStartPosition.Manual;
                    vbfrm.StartPosition = FormStartPosition.CenterParent;
                    vbfrm.ShowDialog(this);
                }
            }
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            RefreshInventory();
        }
    }
}
