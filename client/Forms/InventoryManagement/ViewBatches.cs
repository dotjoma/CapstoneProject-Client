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
        private System.Windows.Forms.Timer _typingTimer = new System.Windows.Forms.Timer();
        private const int TypingDelay = 500;
        private int _currentPage = 1;
        private int _pageSize = 20;

        private Form _parent;
        private InventoryItem _item;


        private List<InventoryBatch> _allBatches = new List<InventoryBatch>();

        public ViewBatches(InventoryItem item, Form parent)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this._parent = parent;
            this._item = item;

            this.txtCurrentPage.Enter += new System.EventHandler(this.txtCurrentPage_Enter);
            this.txtItemsPerPage.Enter += new System.EventHandler(this.txtItemsPerPage_Enter);
        }

        private void ViewBatches_Load(object sender, EventArgs e)
        {
            DisplayText();
            DisplayBatches();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _typingTimer = new System.Windows.Forms.Timer();
            _typingTimer.Interval = TypingDelay;
            _typingTimer.Tick += TypingTimer_Tick;
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

                    dgvBatches.Rows.Add(
                        batch.BatchNumber ?? "Unknown",
                        purchaseDate,
                        expiryDate,
                        batch.InitialQuantity,
                        batch.CurrentQuantity,
                        batch.UnitCost,
                        batch.SupplierName ?? "Unknown",
                        batch.Status ?? "Unknown"
                    );
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
                MessageBox.Show($"Error loading inventory items: {ex.Message}", "Error",
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
            lblDescription.Text = $"Category: {_item.CategoryName} | Current Stock: {currentStock}/{maxStock} | Supplier: {supplier}";
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
            if(string.IsNullOrEmpty(txtItemsPerPage.Text) || _pageSize < 1)
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
    }
}
