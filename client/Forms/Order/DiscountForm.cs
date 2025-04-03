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
using static client.Models.AppliedDiscount;

namespace client.Forms.Order
{
    public partial class DiscountForm : Form
    {
        private static string _discountName = string.Empty;
        private static string _discountCusName = string.Empty;
        private static DiscountTypeEnum _discountType = DiscountTypeEnum.None;
        private static decimal _discountValue = 0;

        private decimal _subtotal = 0;

        public DiscountForm(decimal subtotal)
        {
            InitializeComponent();
            this._subtotal = subtotal;
            this.KeyPreview = true;
            this.KeyDown += DiscountForm_KeyDown;
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            GetDiscount();
            txtName.Text = CustomerName;
            txtIdNumber.Text = CustomerIdNumber;
        }

        private void btnConfirmPayment_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmPayment.BackColor = Color.FromArgb(109, 76, 65);
        }

        private void btnConfirmPayment_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmPayment.BackColor = Color.FromArgb(141, 110, 99);
        }
        private void DiscountForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void DiscountForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    CurrentDiscount.SetCurrentDiscount(null);
                    this.Dispose();
                    break;
                case Keys.Enter:
                    btnConfirmPayment.PerformClick();
                    break;
            }
        }

        public void GetDiscount()
        {
            cboType.DataSource = null;
            cboType.DataSource = CurrentDiscount.AllDiscount;
            cboType.DisplayMember = "Name";
            cboType.ValueMember = "Id";

            if (cboType.Items.Count > 0)
                cboType.SelectedIndex = 0;
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid discount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedDiscount = cboType.SelectedItem as Discount;

                if (selectedDiscount != null && selectedDiscount.Id > 0)
                {
                    CurrentDiscount.SetCurrentDiscount(selectedDiscount);

                    if (!Enum.TryParse(selectedDiscount.Type, true, out DiscountTypeEnum discountType))
                    {
                        discountType = DiscountTypeEnum.None;
                    }

                    _discountCusName = txtName.Text.Trim();
                    _discountName = selectedDiscount.Name;
                    _discountType = discountType;
                    _discountValue = selectedDiscount.Value; // total amount!
                }
                else
                {
                    MessageBox.Show("Invalid discount selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Logger.Write("DISCOUNT ERROR", $"Error selecting discount: {ex.Message}");
                MessageBox.Show("An error occurred while selecting the discount:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboType.SelectedIndex = 0;
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string idNumber = txtIdNumber.Text.Trim();

            if (cboType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select discount type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please provide the customer's name and ID number.", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SetDiscountDetails(_discountName, _discountType, _discountValue, _subtotal);
            SetCustomerDiscountDetails(name, idNumber);

            this.Dispose();
        }
    }
}
