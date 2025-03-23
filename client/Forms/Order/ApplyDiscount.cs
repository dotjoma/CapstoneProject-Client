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
            //LoadCheckBox();
            this.KeyPreview = true;
            this.KeyDown += ApplyDiscount_KeyDown;
            dgvCartItem.CellPainting += new DataGridViewCellPaintingEventHandler(dgvCartItem_CellPainting);
            dgvCartItem.ColumnHeaderMouseClick += dgvCartItem_ColumnHeaderMouseClick;
        }

        private void ApplyDiscount_Load(object sender, EventArgs e)
        {
            LoadDiscountState();
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
        }

        private void ApplyDiscount_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dgvCartItem_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Point point = e.CellBounds.Location;
                int offset = (e.CellBounds.Width - 14) / 2;
                point.X += offset;
                point.Y += (e.CellBounds.Height - 14) / 2;

                CheckBox checkBox = new CheckBox();
                checkBox.BackColor = Color.FromArgb(121, 85, 72);
                checkBox.Size = new Size(14, 14);
                checkBox.Location = point;
                checkBox.CheckedChanged += new EventHandler(HeaderCheckBox_CheckedChanged);
                dgvCartItem.Controls.Add(checkBox);

                e.Handled = true;
            }
        }

        private void HeaderCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox? headerCheckBox = sender as CheckBox;
            if (headerCheckBox == null) return;  // Early exit if the header checkbox is null

            // Iterate through all rows in the DataGridView
            foreach (DataGridViewRow row in dgvCartItem.Rows)
            {
                DataGridViewCheckBoxCell? checkBoxCell = row.Cells["checkBoxColumn"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)  // Only proceed if the checkbox cell exists
                {
                    checkBoxCell.Value = headerCheckBox.Checked;  // Set the checkbox state based on the header checkbox
                }
            }

            // Refresh the DataGridView to reflect the changes visually
            dgvCartItem.Refresh();
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
            var discountFrm = new DiscountForm();
            discountFrm.ShowDialog();
        }
        private void LoadDiscountState()
        {
            bool allChecked = true;

            foreach (DataGridViewRow row in dgvCartItem.Rows)
            {
                if (row.Cells["id"].Value == null) continue;

                int productId = Convert.ToInt32(row.Cells["id"].Value);

                // Check if the product has a discount applied
                if (AppliedDiscount.DiscountedItems.ContainsKey(productId))
                {
                    // Set the checkbox to true (checked)
                    row.Cells["checkBoxColumn"].Value = true;
                }
                else
                {
                    // Set the checkbox to false (unchecked)
                    row.Cells["checkBoxColumn"].Value = false;
                    allChecked = false; // At least one checkbox is unchecked
                }
            }

            // Update the "Select All" checkbox state based on the current state of row checkboxes
            var headerCheckBox = dgvCartItem.Controls.OfType<CheckBox>().FirstOrDefault();
            if (headerCheckBox != null)
            {
                headerCheckBox.Checked = allChecked; // Check if all are checked
            }

            // Refresh the DataGridView to ensure UI updates correctly
            dgvCartItem.Refresh();
        }
        private void dgvCartItem_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 && dgvCartItem.Columns[e.ColumnIndex].Name == "checkBoxColumn")
            {
                bool allChecked = true;

                // Check if all checkboxes are already checked
                foreach (DataGridViewRow row in dgvCartItem.Rows)
                {
                    var cellValue = row.Cells["checkBoxColumn"].Value;
                    if (cellValue == null || !Convert.ToBoolean(cellValue))
                    {
                        allChecked = false;
                        break;  // Exit early if any checkbox is unchecked
                    }
                }

                // Toggle the checkboxes based on the current state
                bool newCheckedState = !allChecked;  // If all are checked, uncheck; otherwise, check all

                // Update the state of all checkboxes in the column
                foreach (DataGridViewRow row in dgvCartItem.Rows)
                {
                    // Explicitly set the checkbox value for all rows
                    row.Cells["checkBoxColumn"].Value = newCheckedState;

                    // Apply or remove discount based on the new checkbox state
                    int productId = Convert.ToInt32(row.Cells["id"].Value);
                    decimal productTotalPrice = Convert.ToDecimal(row.Cells["totalPrice"].Value);

                    if (newCheckedState)
                    {
                        AppliedDiscount.AddDiscount(productId, productTotalPrice);
                    }
                    else
                    {
                        AppliedDiscount.RemoveDiscount(productId);
                    }
                }

                // Update the header checkbox state
                var headerCheckBox = dgvCartItem.Controls.OfType<CheckBox>().FirstOrDefault();
                if (headerCheckBox != null)
                {
                    headerCheckBox.Checked = newCheckedState;
                }

                // Refresh the DataGridView to ensure UI updates correctly
                dgvCartItem.Refresh();
            }
        }

        private void dgvCartItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is in the checkbox column
            if (e.RowIndex >= 0 && dgvCartItem.Columns[e.ColumnIndex].Name == "checkBoxColumn")
            {
                // Get the product ID and the total price for the clicked row
                int productId = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells["id"].Value);

                //decimal productTotalPrice = Convert.ToDecimal(dgvCartItem.Rows[e.RowIndex].Cells["totalPrice"].Value);

                string priceText = dgvCartItem.Rows[e.RowIndex].Cells["totalPrice"].Value?.ToString() ?? "0.00";
                priceText = new string(priceText.Where(c => Char.IsDigit(c) || c == '.').ToArray());

                decimal productTotalPrice = 0;
                if (!decimal.TryParse(priceText, out productTotalPrice))
                {
                    MessageBox.Show("Error: Total Price is not in a valid format.");
                    return;
                }

                // Get the current value of the checkbox (whether it's checked or unchecked)
                bool isChecked = Convert.ToBoolean(dgvCartItem.Rows[e.RowIndex].Cells["checkBoxColumn"].Value);

                // Apply or remove the discount based on the new state
                if (isChecked)
                {
                    AppliedDiscount.AddDiscount(productId, productTotalPrice);
                }
                else
                {
                    AppliedDiscount.RemoveDiscount(productId);
                }

                // Update the header checkbox state
                bool allChecked = true;
                foreach (DataGridViewRow row in dgvCartItem.Rows)
                {
                    var cellValue = row.Cells["checkBoxColumn"].Value;
                    if (cellValue == null || !Convert.ToBoolean(cellValue))
                    {
                        allChecked = false;
                        break;
                    }
                }

                var headerCheckBox = dgvCartItem.Controls.OfType<CheckBox>().FirstOrDefault();
                if (headerCheckBox != null)
                {
                    headerCheckBox.Checked = allChecked;
                }

                // Refresh the DataGridView to ensure UI updates correctly
                dgvCartItem.Refresh();
            }
        }

        private void dgvCartItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCartItem.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                var cell = dgvCartItem.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell == null)
                    return;

                bool isChecked = Convert.ToBoolean(cell.Value);

                int productId = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells[1].Value);
                string? productName = dgvCartItem.Rows[e.RowIndex].Cells[2].Value?.ToString();
                
                string priceText = dgvCartItem.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "0.00";
                priceText = new string(priceText.Where(c => Char.IsDigit(c) || c == '.').ToArray());

                decimal productTotalPrice = 0;
                if (!decimal.TryParse(priceText, out productTotalPrice))
                {
                    MessageBox.Show("Error: Total Price is not in a valid format.");
                    return;
                }

                bool newCheckedState = !isChecked;

                cell.Value = newCheckedState;

                if (newCheckedState)
                {
                    AppliedDiscount.AddDiscount(productId, productTotalPrice);
                    MessageBox.Show($"Checked ID: {productId}\n" +
                        $"Checked Name: {productName}\n" +
                        $"Total: {productTotalPrice:C}");
                }
                else
                {
                    AppliedDiscount.RemoveDiscount(productId);
                }

                dgvCartItem.Refresh();
            }
        }
    }
}

//if (e.RowIndex >= 0 && dgvCartItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
//{
//    int productId = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells[0].Value.ToString());
//    string? productName = dgvCartItem.Rows[e.RowIndex].Cells[1].Value.ToString();
//    int productQuantity = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells[2].Value.ToString());
//    decimal productTotalPrice = Convert.ToDecimal(dgvCartItem.Rows[e.RowIndex].Cells[3].Value.ToString());

//    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvCartItem.Rows[e.RowIndex].Cells[e.ColumnIndex];

//    if (buttonCell.Value.ToString() == "Apply Discount")
//    {
//        buttonCell.Value = "Applied";
//        AppliedDiscount.AddDiscount(productId, productTotalPrice);
//    }
//    else
//    {
//        buttonCell.Value = "Apply Discount";
//        AppliedDiscount.RemoveDiscount(productId);
//    }

//    dgvCartItem.Refresh();
//}