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
            dgvCartItem.CellPainting += dgvCartItem_CellPainting;
        }

        private void ApplyDiscount_Load(object sender, EventArgs e)
        {
            LoadDiscountState();
        }

        public void LoadCart()
        {
            dgvCartItem.Rows.Clear();

            foreach (var item in CurrentCart.Items)
            {
                dgvCartItem.Rows.Add(
                    item.productId,
                    item.productName,
                    item.Quantity,
                    (item.productPrice * item.Quantity).ToString("N2"),
                    "Apply Discount"
                );
            }
        }

        private void ApplyDiscount_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void dgvCartItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCartItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int productId = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells[0].Value.ToString());
                string? productName = dgvCartItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                int productQuantity = Convert.ToInt32(dgvCartItem.Rows[e.RowIndex].Cells[2].Value.ToString());
                decimal productTotalPrice = Convert.ToDecimal(dgvCartItem.Rows[e.RowIndex].Cells[3].Value.ToString());

                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvCartItem.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (buttonCell.Value.ToString() == "Apply Discount")
                {
                    buttonCell.Value = "Applied";
                    AppliedDiscount.AddDiscount(productId, productTotalPrice);
                }
                else
                {
                    buttonCell.Value = "Apply Discount";
                    AppliedDiscount.RemoveDiscount(productId);
                }

                dgvCartItem.Refresh();
            }
        }

        private void LoadDiscountState()
        {
            foreach (DataGridViewRow row in dgvCartItem.Rows)
            {
                if (row.Cells["id"].Value == null) continue;

                int productId = Convert.ToInt32(row.Cells["id"].Value);

                if (AppliedDiscount.DiscountedItems.ContainsKey(productId))
                {
                    row.Cells["discount"].Value = "Applied";
                    row.Cells["discount"].Style.BackColor = Color.Green;
                }
                else
                {
                    row.Cells["discount"].Value = "Apply Discount";
                    row.Cells["discount"].Style.BackColor = SystemColors.Control;
                }
            }
        }

        private void ApplyDiscount_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void dgvCartItem_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCartItem.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);

                string? buttonText = dgvCartItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                Color buttonColor = Color.White;
                Color textColor = Color.Black;

                using (SolidBrush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics!.FillRectangle(brush, e.CellBounds);
                }

                e.Graphics.DrawRectangle(Pens.Black, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                TextRenderer.DrawText(
                    e.Graphics,
                    buttonText,
                    dgvCartItem.Font,
                    e.CellBounds,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
