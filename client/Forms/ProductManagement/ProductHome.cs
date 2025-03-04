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
        public static ProductHome? Instance { get; private set; }
        private readonly DataLoadingService _dataLoadingService;
        private int _selectedId = 0;

        public ProductHome()
        {
            InitializeComponent();
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

        public async void RefreshDisplay()
        {
            await _dataLoadingService.RefreshDataAsync(() => DisplayProducts());
        }

        public void DisplayProducts()
        {
            try
            {
                dgvProducts.Rows.Clear();

                var products = CurrentProduct.AllProduct;

                foreach (var product in products)
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
                        status
                    );
                }
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
                LoggerHelper.Write("PRODUCT ACTION", $"Error performing {dgvProducts.Columns[e.ColumnIndex].Name} action: {ex.Message}");
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

            if (dgvProducts.Columns[e.ColumnIndex].Name == "productStatus")
            {
                if (e.Value != null)
                {
                    string status = e.Value?.ToString() ?? string.Empty;
                    if (status == "Active")
                    {
                        e.CellStyle.SelectionBackColor = Color.Green;
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (status == "Inactive")
                    {
                        e.CellStyle.SelectionBackColor = Color.Red;
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductHome.Instance?.RefreshDisplay();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnRefresh.BackColor = Color.Gray;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnRefresh.BackColor = Color.White;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedId > 0)
            {
                AddProduct product = new AddProduct(_selectedId);
                product.StartPosition = FormStartPosition.Manual;
                product.StartPosition = FormStartPosition.CenterParent;
                product.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
