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
    public partial class AddBatch : Form
    {
        InventoryController _inventoryController = new InventoryController();

        private readonly InventoryHome _parentForm;
        private InventoryItem _item;

        public AddBatch(InventoryItem item, InventoryHome parent)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ShowInTaskbar = false;
            this._parentForm = parent;
            this._item = item;
        }

        private void AddBatch_Load(object sender, EventArgs e)
        {
            GetInventorySupplier();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string? GetNextBatchNumber(InventoryItem item)
        {
            if (item.Batches == null || item.Batches.Count == 0)
                return null;

            int maxSuffix = 0;
            string prefix = "";

            foreach (var batch in item.Batches)
            {
                if (string.IsNullOrEmpty(batch.BatchNumber))
                    continue;

                var parts = batch.BatchNumber.Split('-');

                if (parts.Length == 3)
                {
                    prefix = parts[0] + "-" + parts[1];

                    if (int.TryParse(parts[2], out int suffix))
                    {
                        if (suffix > maxSuffix)
                        {
                            maxSuffix = suffix;
                        }
                    }
                }
            }

            return $"{prefix}-{(maxSuffix + 1):D3}";
        }

        public void GetInventorySupplier()
        {
            cboSupplier.Items.Clear();
            cboSupplier.Items.Add("Select Supplier");

            var suppliers = CurrentSupplier.AllSuppliers;

            if (suppliers != null && suppliers.Count > 0)
            {
                foreach (var sup in suppliers)
                {
                    if (!string.IsNullOrEmpty(sup.SupplierName))
                    {
                        cboSupplier.Items.Add($"{sup.SupplierName}");
                    }
                    else
                    {
                        Logger.Write("SUPPLIER_WARNING", "Supplier name is null or empty, skipping.");
                    }
                }
            }
            else
            {
                Logger.Write("SUPPLIER_WARNING", "No suppliers found.");
            }

            cboSupplier.Items.Add("+ Add Supplier");
            cboSupplier.SelectedIndex = 0;
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex == 0)
            {
                CurrentSupplier.SetCurrentSupplier(null);
                return;
            }

            if (cboSupplier.SelectedIndex == cboSupplier.Items.Count - 1)
            {
                using (var newsuppfrm = new NewSupplier(this))
                {
                    newsuppfrm.StartPosition = FormStartPosition.Manual;
                    newsuppfrm.StartPosition = FormStartPosition.CenterParent;
                    newsuppfrm.ShowDialog(this);
                }

                return;
            }

            if (cboSupplier.SelectedIndex > 0 &&
                CurrentSupplier.AllSuppliers != null &&
                (cboSupplier.SelectedIndex - 1) < CurrentSupplier.AllSuppliers.Count)
            {
                try
                {
                    var selectedSupplier = CurrentSupplier.AllSuppliers[cboSupplier.SelectedIndex - 1];

                    if (selectedSupplier != null && selectedSupplier.Id > 0)
                    {
                        CurrentSupplier.SetCurrentSupplier(selectedSupplier);
                    }
                    else
                    {
                        MessageBox.Show("Invalid supplier selected", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        cboSupplier.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting supplier: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cboSupplier.SelectedIndex = 0;
                }
            }
            else
            {
                cboSupplier.SelectedIndex = 0;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddNewBatch();
        }

        private async Task AddNewBatch()
        {
            if (!ValidateBatchInputs(out decimal quantity, out decimal unitCost))
                return;

            DateTime purchaseDate = dtpPurchase.Value.Date;
            DateTime expirationDate = dtExpiration.Value.Date;
            int? supplierId = CurrentSupplier.Current?.Id;
            bool isActive = cbIsActive.Checked;

            try
            {
                bool result = await _inventoryController.CreateBatch(
                    _item.ItemId, GetNextBatchNumber(_item), purchaseDate.ToString("yyyy-MM-dd"),
                    expirationDate.ToString("yyyy-MM-dd"), quantity, unitCost, supplierId, isActive);
                if (result)
                {
                    _parentForm.RefreshInventory();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating batch: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateBatchInputs(out decimal quantity, out decimal unitCost)
        {
            quantity = 0;
            unitCost = 0;

            if (!decimal.TryParse(txtQuantity.Text.Trim(), out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitCost.Text.Trim(), out unitCost) || unitCost < 0)
            {
                MessageBox.Show("Please enter a valid unit cost (0 or greater).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitCost.Focus();
                return false;
            }

            if (CurrentSupplier.Current == null)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtExpiration.Value.Date <= dtpPurchase.Value.Date)
            {
                MessageBox.Show("Expiration date must be later than the purchase date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void dtExpiration_ValueChanged(object sender, EventArgs e)
        {
            if (dtExpiration.Value < DateTime.Today)
            {
                MessageBox.Show("Expiration date cannot be in the past.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtExpiration.Value = DateTime.Today;

                return;
            }
        }

        private void AddBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
