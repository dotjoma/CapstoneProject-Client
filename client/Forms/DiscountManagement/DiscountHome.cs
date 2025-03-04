using client.Forms.ProductManagement;
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

namespace client.Forms.DiscountManagement
{
    public partial class DiscountHome : Form
    {
        DataLoadingService _dataLoadingService = new DataLoadingService();
        public static DiscountHome? Instance { get; private set; }

        public DiscountHome()
        {
            InitializeComponent();
            Instance = this;
        }

        private void DiscountHome_Load(object sender, EventArgs e)
        {
            DisplayDiscounts();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddDiscount addDiscount = new AddDiscount();
            addDiscount.StartPosition = FormStartPosition.Manual;
            addDiscount.StartPosition = FormStartPosition.CenterParent;
            addDiscount.ShowDialog(this);
        }

        public void DisplayDiscounts()
        {
            try
            {
                dgvDiscount.Rows.Clear();

                var discounts = CurrentDiscount.AllDiscount;

                foreach (var discount in discounts)
                {
                    int id = discount.Id;
                    string name = discount.Name;
                    string type = discount.Type;
                    decimal value = discount.Value;
                    string vatExempt = (discount.VatExempt) > 0 ? "Yes" : "No";

                    string applicableTo = discount.ApplicableTo;
                    string[] categoryIds = applicableTo.Split(',').Select(id => id.Trim()).ToArray();
                    string categoryNames = string.Empty;

                    foreach (string categoryId in categoryIds)
                    {
                        if (int.TryParse(categoryId, out int Id))
                        {
                            var category = CurrentCategory.GetCategoryById(Id);
                            string categoryName = category?.Name ?? "Unknown";
                            categoryNames += categoryName + ", ";

                        }
                    }
                    string status = (discount.Status) > 0 ? "Active" : "Inactive";

                    dgvDiscount.Rows.Add(
                        id,
                        name,
                        type,
                        value,
                        vatExempt,
                        categoryNames,
                        status
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading discounts: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void RefreshDisplay()
        {
            await _dataLoadingService.RefreshDataOf("discount", DisplayDiscounts);
        }

        private void DiscountHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Instance = null;
        }

        private void btnRefreshh_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void btnRefreshh_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            btnRefresh.BackColor = Color.Gray;
        }

        private void btnRefreshh_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            btnRefresh.BackColor = Color.White;
        }

        private void dgvDiscount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle == null) return;

            if (dgvDiscount.Columns[e.ColumnIndex].Name == "status")
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
    }
}
