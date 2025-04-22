using client.Services;
using client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.Order
{
    public partial class ApplyDiscount : Form
    {
        public ApplyDiscount()
        {
            InitializeComponent();
            LoadCart();
            this.KeyPreview = true;
            this.KeyDown += ApplyDiscount_KeyDown;

            AppliedDiscount.OnDiscountAppliedSuccess += DiscountAppliedSuccess;
        }

        private void ApplyDiscount_Load(object sender, EventArgs e)
        {
            LoadDiscountState();
        }

        private void DiscountAppliedSuccess()
        {
            this.Dispose();
        }

        public void LoadCart()
        {
            dgvCartItem.Rows.Clear();
            dgvCartItem.Columns["checkBoxColumn"].ReadOnly = false;

            foreach (var item in CurrentCart.Items)
            {
                dgvCartItem.Rows.Add(
                    false,
                    item.productId,
                    item.productName,
                    item.Quantity,
                    $"{item.productPrice:C}",
                    $"{item.productPrice * item.Quantity:C}"
                );
            }

            dgvCartItem.ClearSelection();
        }

        private void ApplyDiscount_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void dgvCartItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ApplyDiscount_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
        private void btnConfirmPayment_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmPayment.BackColor = Color.FromArgb(109, 76, 65);
        }

        private void btnConfirmPayment_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmPayment.BackColor = Color.FromArgb(141, 110, 99);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(161, 136, 127);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(141, 110, 99);
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            bool isAnyCheckboxChecked = dgvCartItem.Rows.Cast<DataGridViewRow>()
            .Any(row =>
            {
                var cellValue = row.Cells["checkBoxColumn"].Value;

                return cellValue != null && (cellValue is bool boolValue ? boolValue : cellValue.ToString() == "True");
            });

            if (!isAnyCheckboxChecked)
            {
                MessageBox.Show("Please select at least one item before proceeding.",
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var paymentFrm = new DiscountForm(0))
            {
                paymentFrm.ShowDialog();
            }
        }

        private void LoadDiscountState()
        {
            if (dgvCartItem.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dgvCartItem.Rows)
            {
                if (row.Cells["id"].Value == null) continue;

                if (!int.TryParse(row.Cells["id"].Value.ToString(), out int productId)) continue;

                bool hasDiscount = AppliedDiscount.DiscountedItems.TryGetValue(productId, out _);

                row.Cells["checkBoxColumn"].Value = hasDiscount;
            }
        }

        private void dgvCartItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCartItem.Columns[e.ColumnIndex].Name != "checkBoxColumn")
                return;

            bool isChecked = Convert.ToBoolean(dgvCartItem.Rows[e.RowIndex].Cells["checkBoxColumn"].Value);

            ProcessDiscount(e.RowIndex, isChecked);
        }

        private void dgvCartItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(dgvCartItem.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn))
                return;

            var cell = dgvCartItem.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell == null) return;

            bool newCheckedState = !(cell.Value is bool currentState && currentState);
            cell.Value = newCheckedState;

            ProcessDiscount(e.RowIndex, newCheckedState);

            dgvCartItem.Refresh();
        }

        private void ProcessDiscount(int rowIndex, bool isChecked)
        {
            if (rowIndex < 0 || rowIndex >= dgvCartItem.Rows.Count)
                return;

            var row = dgvCartItem.Rows[rowIndex];

            if (!int.TryParse(row.Cells["id"].Value?.ToString(), out int productId))
                return;

            if (!int.TryParse(row.Cells["quantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                quantity = 1;

            string priceText = row.Cells["unitprice"].Value?.ToString() ?? "0.00";
            priceText = new string(priceText.Where(c => Char.IsDigit(c) || c == '.').ToArray());

            if (!decimal.TryParse(priceText, out decimal unitPrice))
            {
                MessageBox.Show("Error: Total Price is not in a valid format.");
                return;
            }

            if (isChecked)
            {
                if (!AppliedDiscount.DiscountedItems.ContainsKey(productId))
                {
                    AppliedDiscount.AddDiscount(productId, unitPrice, quantity);
                }
            }
            else
            {
                AppliedDiscount.RemoveDiscount(productId);
            }
        }


        private void CancelAllDiscounts()
        {
            foreach (DataGridViewRow row in dgvCartItem.Rows)
            {
                if (row.Cells["checkBoxColumn"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = false;
                }

                if (row.Cells["id"].Value != null && int.TryParse(row.Cells["id"].Value.ToString(), out int productId))
                {
                    AppliedDiscount.RemoveDiscount(productId);
                }
            }

            AppliedDiscount.Clear();

            dgvCartItem.Refresh();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelAllDiscounts();
            this.Dispose();
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveDraft_MouseEnter(object sender, EventArgs e)
        {
            btnSaveDraft.BackColor = Color.FromArgb(109, 76, 65);
        }

        private void btnSaveDraft_MouseLeave(object sender, EventArgs e)
        {
            btnSaveDraft.BackColor = Color.FromArgb(141, 110, 99);
        }
    }
}