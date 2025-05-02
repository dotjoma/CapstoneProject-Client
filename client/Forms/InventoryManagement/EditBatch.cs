using client.Controllers;
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
    public partial class EditBatch : Form
    {
        InventoryController _inventoryController = new InventoryController();

        private Form _parentForm;
        private string? _batchId;
        private int _itemId;
        private string? _batchNumber;
        private DateTime _purchaseDate;
        private DateTime _expiryDate;
        private decimal _initialQuantity;
        private decimal _currentQuantity;
        private decimal _unitCost;
        private string? _supplierId;
        private string? _supplierName;
        private string? _status;

        public static event Action? RefreshInventory;

        public EditBatch(string? batchId, int itemId, string? batchNumber, DateTime purchaseDate,
            DateTime expiryDate, decimal initQuantity, decimal curQuantity, decimal unitCost,
            string? supplierId, string? supplierName, string? status, Form parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.KeyPreview = true;
            this._parentForm = parent;
            this._batchId = batchId;
            this._itemId = itemId;
            this._batchNumber = batchNumber;
            this._purchaseDate = purchaseDate;
            this._expiryDate = expiryDate;
            this._initialQuantity = initQuantity;
            this._currentQuantity = curQuantity;
            this._unitCost = unitCost;
            this._supplierId = supplierId;
            this._supplierName = supplierName;
            this._status = status;
        }

        private void EditBatch_Load(object sender, EventArgs e)
        {
            dtpPurchase.Value = _purchaseDate;
            dtExpiration.Value = _expiryDate;
            txtInitialQuantity.Text = _initialQuantity.ToString();
            txtCurrentQuantity.Text = _currentQuantity.ToString();
            txtUnitCost.Text = _unitCost.ToString();

            GetInventorySupplier();
            cboSupplier.SelectedItem = _supplierName;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateBatch();
        }

        private async void UpdateBatch()
        {
            string? itemId = _itemId.ToString();
            string? batchId = _batchId;
            string? batchNumber = _batchNumber;
            DateTime purchaseDate = dtpPurchase.Value;
            DateTime expirationDate = dtExpiration.Value;
            decimal initialQuantity = decimal.Parse(txtInitialQuantity.Text.Trim());
            decimal currentQuantity = decimal.Parse(txtCurrentQuantity.Text.Trim());
            decimal unitCost = decimal.Parse(txtUnitCost.Text.Trim());
            string? supplierId = CurrentSupplier.Current?.Id.ToString() ?? _supplierId;
            string? supplierName = CurrentSupplier.Current?.SupplierName ?? _supplierName;
            bool isActive = cbIsActive.Checked;

            Dictionary<string, object> batchUpdateData = new Dictionary<string, object>
            {
                { "OldBatchId", _batchId ?? "" },
                { "OldItemId", _itemId.ToString() ?? "" },
                { "OldBatchNumber", _batchNumber ?? "" },
                { "OldPurchaseDate", _purchaseDate },
                { "OldExpirationDate", _expiryDate },
                { "OldInitialQuantity", _initialQuantity },
                { "OldCurrentQuantity", _currentQuantity },
                { "OldUnitCost", _unitCost },
                { "OldSupplierId", _supplierId ?? "0" },
                { "OldSupplierName", _supplierName ?? ""},

                { "NewBatchId", batchId ?? "0" },
                { "NewItemId", itemId ?? "0" },
                { "NewBatchNumber", batchNumber ?? "" },
                { "NewPurchaseDate", purchaseDate },
                { "NewExpirationDate", expirationDate },
                { "NewInitialQuantity", initialQuantity },
                { "NewCurrentQuantity", currentQuantity },
                { "NewUnitCost", unitCost },
                { "NewSupplierId", supplierId ?? "0" },
                { "NewSupplierName", supplierName ?? "" },
                { "NewIsActive", isActive }
            };

            try
            {
                bool result = await _inventoryController.UpdateBatch(batchUpdateData);
                if (result)
                {
                    RefreshInventory?.Invoke();
                    if (_parentForm is ViewBatches vbfrm)
                    {
                        vbfrm.RefreshBatches(itemId);
                    }
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating batch: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void dtExpiration_ValueChanged(object sender, EventArgs e)
        {
            if (dtExpiration.Value < _purchaseDate)
            {
                MessageBox.Show(
                    $"Expiration date must be on or after {_purchaseDate:MM/dd/yyyy}.",
                    "Invalid Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtExpiration.Value = DateTime.Today;

                return;
            }
        }
    }
}
