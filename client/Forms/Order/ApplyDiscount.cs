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

namespace client.Forms.Order
{
    public partial class ApplyDiscount : Form
    {
        public ApplyDiscount()
        {
            InitializeComponent();
            LoadCart();
        }

        private void ApplyDiscount_Load(object sender, EventArgs e)
        {

        }

        public void LoadCart()
        {
            dgvCartItem.Rows.Clear();

            foreach (var item in CurrentCart.Items)
            {
                dgvCartItem.Rows.Add(
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
                string? productName = dgvCartItem.Rows[e.RowIndex].Cells[0].Value.ToString();

                MessageBox.Show($"Applying discount to: {productName}", "Discount",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: discount logic.
            }
        }
    }
}
