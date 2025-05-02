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
    public partial class ViewBatches : Form
    {
        InventoryController _inventoryController = new InventoryController();

        private System.Windows.Forms.Timer _typingTimer = new System.Windows.Forms.Timer();
        private const int TypingDelay = 500;
        private int _currentPage = 1;
        private int _pageSize = 20;

        private string? _itemId = string.Empty;
        private string? _batchId = string.Empty;
        private string? _batchNumber = string.Empty;
        private DateTime _purchaseDate = DateTime.Now;
        private DateTime _expiryDate = DateTime.Now;
        private decimal _initialQuantity = 0.00m;
        private decimal _currentQuantity = 0.00m;
        private decimal _unitCost = 0.00m;
        private string? _supplierId = string.Empty;
        private string? _supplierName = string.Empty;
        private string? _status = string.Empty;

        private Form _parent;
        private InventoryItem _item;
        private int _selectedItemId;

        private List<InventoryBatch> _allBatches = new List<InventoryBatch>();
        private List<Dictionary<string, object>> _allBatchesFromDb = new();

        public ViewBatches(InventoryItem item, int selectedItemId, Form parent)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ShowInTaskbar = false;
            this._parent = parent;
            this._item = item;
            this._selectedItemId = selectedItemId;

            this.txtCurrentPage.Enter += new EventHandler(this.txtCurrentPage_Enter);
            this.txtItemsPerPage.Enter += new EventHandler(this.txtItemsPerPage_Enter);
        }

        private void ViewBatches_Load(object sender, EventArgs e)
        {
            DisplayText();
            DisplayBatches();
            InitializeTimer();
            dgvBatches.Focus();
        }

        private void InitializeTimer()
        {
            _typingTimer = new System.Windows.Forms.Timer();
            _typingTimer.Interval = TypingDelay;
            _typingTimer.Tick += TypingTimer_Tick;
        }

        public async void RefreshBatches(string? itemId)
        {
            try
            {
                dgvBatches.Rows.Clear();
                _allBatchesFromDb.Clear();

                if (string.IsNullOrWhiteSpace(itemId))
                {
                    MessageBox.Show("Item ID cannot be empty.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var batches = await _inventoryController.GetBatch(itemId);

                if (batches == null || !batches.Any())
                {
                    Logger.Write("INVENTORY REFRESH", "No batches found for the provided item ID.");
                    MessageBox.Show("No batches found.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _allBatchesFromDb = batches;
                    DisplayBatchesFromDatabase();
                    Logger.Write("INVENTORY REFRESH", $"Successfully refreshed inventory. Loaded {batches.Count} batches.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing inventory: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.Write("INVENTORY REFRESH", $"Error occurred during inventory refresh: {ex.Message}");
            }
        }

        private void DisplayBatchesFromDatabase()
        {
            try
            {
                dgvBatches.Rows.Clear();
                if (_allBatchesFromDb == null || !_allBatchesFromDb.Any())
                {
                    return;
                }

                int totalBatches = _allBatchesFromDb.Count;
                int totalPages = (int)Math.Ceiling((double)totalBatches / _pageSize);

                if (_currentPage < 1) _currentPage = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;

                var batchesToShow = _allBatchesFromDb
                    .Skip((_currentPage - 1) * _pageSize)
                    .Take(_pageSize)
                    .ToList();

                foreach (var batch in batchesToShow)
                {
                    foreach (var key in batch.Keys)
                    {
                        Logger.Write("BATCHES_DEBUG", $"Key: {key}, Value Type: {batch[key]?.GetType()}, Value: {batch[key]}");
                    }

                    var batchId = batch.ContainsKey("batch_id") ? batch["batch_id"] : "Unknown";
                    var batchNumber = batch.ContainsKey("batch_number") ? batch["batch_number"]?.ToString() : "Unknown";
                    var purchaseDate = batch.ContainsKey("purchase_date") && batch["purchase_date"] != null
                        ? Convert.ToDateTime(batch["purchase_date"]).ToString("yyyy-MM-dd")
                        : "Unknown";
                    var expiryDate = batch.ContainsKey("expiration_date") && batch["expiration_date"] != null
                        ? Convert.ToDateTime(batch["expiration_date"]).ToString("yyyy-MM-dd")
                        : "Unknown";
                    var initialQuantity = batch.ContainsKey("initial_quantity") ? batch["initial_quantity"] : 0;
                    var currentQuantity = batch.ContainsKey("current_quantity") ? batch["current_quantity"] : 0;
                    var unitCost = batch.ContainsKey("unit_cost") ? batch["unit_cost"] : 0;
                    var supplierName = batch.ContainsKey("supplier_name") ? batch["supplier_name"]?.ToString() : "Unknown";

                    string status = "Unknown";

                    if (batch.ContainsKey("expiration_date") && batch["expiration_date"] != null)
                    {
                        if (DateTime.TryParse(batch["expiration_date"].ToString(), out DateTime expDate))
                        {
                            var now = DateTime.Now;
                            var daysUntilExpiry = (expDate - now).TotalDays;

                            int warningThreshold = _item.ExpiryWarningDays;

                            if (daysUntilExpiry < 0)
                            {
                                status = "Expired";
                            }
                            else if (daysUntilExpiry <= warningThreshold)
                            {
                                status = "Expiring Soon";
                            }
                            else
                            {
                                status = "Active";
                            }
                        }
                    }

                    dgvBatches.Rows.Add(
                        batchId,
                        batchNumber,
                        purchaseDate,
                        expiryDate,
                        initialQuantity,
                        currentQuantity,
                        unitCost,
                        supplierName,
                        status,
                        Properties.Resources.menu_vertical_24
                    );

                    int rowIndex = dgvBatches.Rows.Count - 1;
                    var row = dgvBatches.Rows[rowIndex];

                    if (status == "Expired")
                    {
                        row.Cells["status"].Style.ForeColor = Color.Red;
                        row.Cells["expirydate"].Style.ForeColor = Color.Red;
                    }
                    else if (status == "Expiring Soon")
                    {
                        row.Cells["status"].Style.ForeColor = Color.DarkOrange;
                        row.Cells["expirydate"].Style.ForeColor = Color.DarkOrange;
                    }
                    else if (status == "Active")
                    {
                        row.Cells["status"].Style.ForeColor = Color.Black;
                    }
                }

                int start = ((_currentPage - 1) * _pageSize) + 1;
                int end = start + batchesToShow.Count - 1;
                txtItemsPerPage.Text = _pageSize.ToString();
                lblPageInfo.Text = $"Showing {start}-{end} of {totalBatches} batches";

                txtCurrentPage.Text = _currentPage.ToString();
                lblTotalPage.Text = $"/{totalPages}";
                btnPrev.Enabled = _currentPage > 1;
                btnNext.Enabled = _currentPage < totalPages;
                txtCurrentPage.Enabled = totalPages > 1;

                decimal maxStock = _item.MaxStockLevel;
                decimal currentStock = 0;

                foreach (DataGridViewRow row in dgvBatches.Rows)
                {
                    if (row.Cells["currentquantity"].Value != null)
                    {
                        currentStock += Convert.ToDecimal(row.Cells["currentquantity"].Value);
                    }
                }
                lblDescription.Text = $"Category: {_item.CategoryName} | Current Stock: {currentStock}/{maxStock}";

                dgvBatches.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading batch items: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayBatches()
        {
            try
            {
                dgvBatches.Rows.Clear();
                if (_item == null || _item.Batches == null || !_item.Batches.Any())
                {
                    return;
                }

                _allBatches = _item.Batches;

                int totalBatches = _allBatches.Count;
                int totalPages = (int)Math.Ceiling((double)totalBatches / _pageSize);

                if (_currentPage < 1) _currentPage = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;

                var batchesToShow = _allBatches
                    .Skip((_currentPage - 1) * _pageSize)
                    .Take(_pageSize)
                    .ToList();

                foreach (var batch in batchesToShow)
                {
                    string purchaseDate = batch.PurchaseDate?.ToString("yyyy-MM-dd") ?? "Unknown";
                    string expiryDate = batch.ExpirationDate?.ToString("yyyy-MM-dd") ?? "Unknown";

                    string status = "Unknown";
                    if (batch.ExpirationDate != null)
                    {
                        var now = DateTime.Now;
                        var daysUntilExpiry = (batch.ExpirationDate.Value - now).TotalDays;
                        int threshold = _item.ExpiryWarningDays;

                        if (daysUntilExpiry < 0)
                        {
                            status = "Expired";
                        }
                        else if (daysUntilExpiry <= threshold)
                        {
                            status = "Expiring Soon";
                        }
                        else
                        {
                            status = "Active";
                        }
                    }

                    dgvBatches.Rows.Add(
                        batch.BatchId,
                        batch.BatchNumber ?? "Unknown",
                        purchaseDate,
                        expiryDate,
                        batch.InitialQuantity,
                        batch.CurrentQuantity,
                        batch.UnitCost,
                        batch.SupplierName ?? "Unknown",
                        status,
                        Properties.Resources.menu_vertical_24
                    );

                    int rowIndex = dgvBatches.Rows.Count - 1;
                    var row = dgvBatches.Rows[rowIndex];

                    if (status == "Expired")
                    {
                        row.Cells["status"].Style.ForeColor = Color.Red;
                        row.Cells["expirydate"].Style.ForeColor = Color.Red;
                    }
                    else if (status == "Expiring Soon")
                    {
                        row.Cells["status"].Style.ForeColor = Color.DarkOrange;
                        row.Cells["expirydate"].Style.ForeColor = Color.DarkOrange;
                    }
                    else if (status == "Active")
                    {
                        row.Cells["status"].Style.ForeColor = Color.Black;
                    }
                }

                int start = ((_currentPage - 1) * _pageSize) + 1;
                int end = start + batchesToShow.Count - 1;
                txtItemsPerPage.Text = _pageSize.ToString();
                lblPageInfo.Text = $"Showing {start}-{end} of {totalBatches} batches";

                txtCurrentPage.Text = _currentPage.ToString();
                lblTotalPage.Text = $"/{totalPages}";
                btnPrev.Enabled = _currentPage > 1;
                btnNext.Enabled = _currentPage < totalPages;
                txtCurrentPage.Enabled = totalPages > 1;

                dgvBatches.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading batch items: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayText()
        {
            decimal currentStock = _item.Batches?.Sum(b => b.CurrentQuantity) ?? 0;
            decimal maxStock = _item.MaxStockLevel;
            string supplier = _item.Batches?.FirstOrDefault()?.SupplierName ?? "N/A";

            lblHeader.Text = $"View Batches - {_item.ItemName}";
            lblTitle.Text = $"{_item.ItemName} Batches";
            lblDescription.Text = $"Category: {_item.CategoryName} | Current Stock: {currentStock}/{maxStock}";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            DisplayBatches();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            DisplayBatches();
        }

        private void TypingTimer_Tick(object? sender, EventArgs e)
        {
            _typingTimer.Stop();

            if (int.TryParse(txtCurrentPage.Text, out int pageNumber))
            {
                int totalPages = (int)Math.Ceiling((double)_allBatches.Count / _pageSize);
                if (pageNumber < 1)
                {
                    _currentPage = 1;
                }
                else if (pageNumber > totalPages)
                {
                    _currentPage = totalPages;
                }
                else
                {
                    _currentPage = pageNumber;
                }

                DisplayBatches();
            }
            else
            {
                txtCurrentPage.Text = _currentPage.ToString();
            }
        }

        private void txtCurrentPage_TextChanged(object sender, EventArgs e)
        {
            _typingTimer.Stop();
            _typingTimer.Start();
        }

        private void txtItemsPerPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemsPerPage.Text) || _pageSize < 1)
            {
                return;
            }

            _pageSize = int.Parse(txtItemsPerPage.Text.Trim());

            if (_pageSize > 100)
            {
                _pageSize = 100;
                txtItemsPerPage.Text = "100";
            }
            _typingTimer.Stop();
            _typingTimer.Start();
        }

        private void txtCurrentPage_Enter(object? sender, EventArgs e)
        {
            txtCurrentPage.SelectAll();
        }

        private void txtCurrentPage_GotFocus(object sender, EventArgs e)
        {
            txtCurrentPage.SelectAll();
        }

        private void txtItemsPerPage_Enter(object? sender, EventArgs e)
        {
            txtItemsPerPage.SelectAll();
        }

        private void txtItemsPerPage_GotFocus(object sender, EventArgs e)
        {
            txtCurrentPage.SelectAll();
        }

        private void ViewBatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnPrev.PerformClick();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnNext.PerformClick();
            }
        }

        private void dgvBatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvBatches.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var clickedImage = dgvBatches.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Image;

                _batchId = dgvBatches.Rows[e.RowIndex].Cells["id"].Value.ToString();
                _batchNumber = dgvBatches.Rows[e.RowIndex].Cells["batchnumber"].Value.ToString();
                _purchaseDate = DateTime.TryParse(dgvBatches.Rows[e.RowIndex].Cells["purchasedate"].Value.ToString(), out DateTime purchaseDate) ? purchaseDate : DateTime.Now;
                _expiryDate = DateTime.TryParse(dgvBatches.Rows[e.RowIndex].Cells["expirydate"].Value.ToString(), out DateTime expiryDate) ? expiryDate : DateTime.Now;
                _initialQuantity = decimal.TryParse(dgvBatches.Rows[e.RowIndex].Cells["initialquantity"].Value.ToString(), out decimal initialQuantity) ? initialQuantity : 0.00m;
                _currentQuantity = decimal.TryParse(dgvBatches.Rows[e.RowIndex].Cells["currentquantity"].Value.ToString(), out decimal currentQuantity) ? currentQuantity : 0.00m;
                _unitCost = decimal.TryParse(dgvBatches.Rows[e.RowIndex].Cells["unitcost"].Value.ToString(), out decimal unitCost) ? unitCost : 0.00m;
                var batch = _item.Batches?.FirstOrDefault(b => b.BatchId == Convert.ToInt32(_batchId));
                _supplierId = batch?.SupplierId.ToString() ?? "0";
                _supplierName = dgvBatches.Rows[e.RowIndex].Cells["supplier"].Value.ToString();
                _status = dgvBatches.Rows[e.RowIndex].Cells["status"].Value.ToString();

                if (e.RowIndex >= 0)
                {
                    dgvBatches.ClearSelection();
                    dgvBatches.Rows[e.RowIndex].Selected = true;

                    cmsOptions.Show(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                }
            }
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            using (var editBatch = new EditBatch(_batchId, _selectedItemId, _batchNumber, _purchaseDate,
                _expiryDate, _initialQuantity, _currentQuantity, _unitCost, _supplierId, _supplierName,
                _status, this))
            {
                editBatch.ShowDialog(this);
            }
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
