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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace client.Forms.ProductManagement
{
    public partial class ProductHome : Form
    {
        ProductController _productController = new ProductController();

        private System.Windows.Forms.Timer _typingTimer = new System.Windows.Forms.Timer();
        private const int TypingDelay = 500;
        private int _currentPage = 1;
        private int _pageSize = 20;

        public static ProductHome? Instance { get; private set; }
        private readonly DataLoadingService _dataLoadingService;
        private int _selectedId = 0;

        public ProductHome()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Instance = this;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            //this.ShowInTaskbar = false;

            _dataLoadingService = new DataLoadingService(this);

            this.Load += ProductHome_Load;

            toolTip1.SetToolTip(btnRefresh, "Refresh Records");
        }

        private void ProductHome_Load(object? sender, EventArgs e)
        {
            timer1.Start();
            DisplayProducts();
            InitializeTimer();
            dgvProducts.Focus();
        }

        private void InitializeTimer()
        {
            _typingTimer = new System.Windows.Forms.Timer();
            _typingTimer.Interval = TypingDelay;
            _typingTimer.Tick += TypingTimer_Tick;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Instance = null;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddProduct(_selectedId).ShowDialog();
        }

        public async Task RefreshDisplay()
        {
            ShowLoading("Refreshing products...");

            try
            {
                await _dataLoadingService.RefreshDataAsync(() => DisplayProducts());
            }
            finally
            {
                HideLoading();
            }
        }

        private void DisplayProducts()
        {
            try
            {
                dgvProducts.Rows.Clear();

                var products = CurrentProduct.AllProduct;

                if (products == null || products.Count == 0)
                    return;

                int totalProducts = products.Count;
                int totalPages = (int)Math.Ceiling((double)totalProducts / _pageSize);

                if (_currentPage < 1) _currentPage = 1;
                if (_currentPage > totalPages) _currentPage = totalPages;

                var productsToShow = products
                    .Skip((_currentPage - 1) * _pageSize)
                    .Take(_pageSize)
                    .ToList();

                foreach (var product in productsToShow)
                {
                    var category = CurrentCategory.GetCategoryById(product.categoryId);
                    var productCategory = category?.Name ?? "Unknown";

                    var subcategory = CurrentSubCategory.GetSubategoryById(product.subcategoryId);
                    string productSubCategory = subcategory?.scName ?? "N/A";

                    var unit = CurrentUnit.GetUnitById(product.unitId);
                    string productUnit = unit?.unitName ?? "N/A";

                    string status = (product.isActive) > 0 ? "Active" : "Inactive";

                    dgvProducts.Rows.Add(
                        product.productId,
                        productCategory,
                        productSubCategory,
                        product.productName,
                        productUnit,
                        product.productPrice,
                        status,
                        Properties.Resources.menu_vertical_24
                    );
                }

                int start = ((_currentPage - 1) * _pageSize) + 1;
                int end = start + productsToShow.Count - 1;
                lblPageInfo.Text = $"Showing {start}-{end} of {totalProducts} products";

                txtItemsPerPage.Text = _pageSize.ToString();
                txtCurrentPage.Text = _currentPage.ToString();
                lblTotalPage.Text = $"/{totalPages}";

                btnPrev.Enabled = _currentPage > 1;
                btnNext.Enabled = _currentPage < totalPages;
                txtCurrentPage.Enabled = totalPages > 1;

                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .4;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                string columnName = dgvProducts.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "edit":
                        _selectedId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productId"].Value);
                        HandleEdit();
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("PRODUCT ACTION", $"Error performing {dgvProducts.Columns[e.ColumnIndex].Name} action: {ex.Message}");
                MessageBox.Show("An error occurred while processing your request.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleEdit()
        {
            var addProductForm = new AddProduct(_selectedId);
            addProductForm.ShowDialog();
        }

        private void dgvProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle == null) return;

            if (dgvProducts.Columns[e.ColumnIndex].Name == "productStatus" && e.Value != null)
            {
                string status = e.Value.ToString() ?? string.Empty;
                e.FormattingApplied = true;

                if (status == "Active")
                {
                    e.CellStyle.SelectionBackColor = Color.White;
                    e.Value = Properties.Resources.check_24;
                }
                else if (status == "Inactive")
                {
                    e.CellStyle.SelectionBackColor = Color.White;
                    e.Value = Properties.Resources.icons8_x_24;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _selectedId = 0;
            AddProduct product = new AddProduct(_selectedId);
            product.StartPosition = FormStartPosition.Manual;
            product.StartPosition = FormStartPosition.CenterParent;
            product.ShowDialog(this);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await RefreshDisplay();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnRefresh.BackColor = Color.FromArgb(232, 232, 232);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                EditProduct(_selectedId);
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditProduct(int selectedId)
        {
            AddProduct product = new AddProduct(selectedId);
            product.StartPosition = FormStartPosition.Manual;
            product.StartPosition = FormStartPosition.CenterParent;
            product.ShowDialog(this);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                DeleteProduct(_selectedId);
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteProduct(int _selectedId)
        {
            var confirmDelete = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    ShowLoading("Deleting product...");

                    bool success = await _productController.Destroy(_selectedId);
                    if (success)
                    {
                        HideLoading();
                        await RefreshDisplay();

                        //MessageBox.Show("Product deleted successfully", "Success",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    HideLoading();
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    HideLoading();
                }
            }
        }

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private Label messageLabel = new Label();

        private void InitializeLoadingControls()
        {
            loadingPanel.BackColor = Color.White;
            loadingPanel.BorderStyle = BorderStyle.None;
            loadingPanel.Size = new Size(300, 150);
            loadingPanel.Location = new Point(
                (this.ClientSize.Width - loadingPanel.Width) / 2,
                (this.ClientSize.Height - loadingPanel.Height) / 2
            );

            panelBox.Size = new Size(64, 64);
            panelBox.Location = new Point(
                (loadingPanel.Width - panelBox.Width) / 2,
                20
            );
            panelBox.BorderStyle = BorderStyle.None;
            panelBox.BackColor = Color.White;

            pictureBox.Size = new Size(24, 24);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(
                (panelBox.Width - pictureBox.Width) / 2,
                (panelBox.Height - pictureBox.Height) / 2
            );

            try
            {
                pictureBox.Image = Properties.Resources.loading_gif;
            }
            catch
            {
                pictureBox.BackColor = Color.LightGray;
            }

            messageLabel.AutoSize = false;
            messageLabel.Size = new Size(280, 30);
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Location = new Point(
                (loadingPanel.Width - messageLabel.Width) / 2,
                panelBox.Bottom + 8
            );
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

            panelBox.Controls.Add(pictureBox);
            loadingPanel.Controls.Add(panelBox);
            loadingPanel.Controls.Add(messageLabel);
            this.Controls.Add(loadingPanel);
        }

        private void ShowLoading(string message)
        {
            if (!this.Controls.Contains(loadingPanel))
            {
                InitializeLoadingControls();
            }

            messageLabel.Text = message;
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;
            Application.DoEvents();
        }

        private void HideLoading()
        {
            if (loadingPanel != null)
            {
                loadingPanel.Visible = false;
            }
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvProducts.ClearSelection();
                    dgvProducts.Rows[e.RowIndex].Selected = true;

                    cmsOptions.Show(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

            int selecteRowId = Convert.ToInt32(selectedRow.Cells["id"].Value);

            EditProduct(selecteRowId);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

            int selectedRowId = Convert.ToInt32(selectedRow.Cells["id"].Value);

            DeleteProduct(selectedRowId);
        }

        private void TypingTimer_Tick(object? sender, EventArgs e)
        {
            _typingTimer.Stop();

            if (string.IsNullOrEmpty(txtCurrentPage.Text))
            {
                return;
            }

            if (int.TryParse(txtCurrentPage.Text, out int pageNumber))
            {

                var products = CurrentProduct.AllProduct;

                int totalPages = (int)Math.Ceiling((double)products.Count / _pageSize);

                if (pageNumber > totalPages)
                {
                    _currentPage = totalPages;
                }
                else
                {
                    _currentPage = pageNumber;
                }

                DisplayProducts();
            }
            else
            {
                txtCurrentPage.Text = _currentPage.ToString();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            DisplayProducts();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            DisplayProducts();
        }

        private void txtCurrentPage_TextChanged(object sender, EventArgs e)
        {
            _typingTimer.Stop();
            _typingTimer.Start();
        }

        private void txtItemsPerPage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemsPerPage.Text))
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

        private void ProductHome_KeyDown(object? sender, KeyEventArgs e)
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

        private void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvProducts.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var clickedImage = dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as Image;

                //_batchId = dgvProducts.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (e.RowIndex >= 0)
                {
                    dgvProducts.ClearSelection();
                    dgvProducts.Rows[e.RowIndex].Selected = true;

                    cmsOptions.Show(Cursor.Position.X + 10, Cursor.Position.Y + 10);
                }
            }
        }
    }
}
