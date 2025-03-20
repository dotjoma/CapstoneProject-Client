using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.Order
{
    public partial class PaymentForm : Form
    {
        private string amountPaid = string.Empty;
        public PaymentForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += PaymentForm_KeyDown;
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentMethod.SelectedItem is null)
                return;

            string? selectedPayment = cboPaymentMethod.SelectedItem.ToString();

            paymentDetailsPanel.Controls.Clear();

            if (selectedPayment == "Cash")
            {
                AddCashPaymentUI();
            }
            else if (selectedPayment == "Digital Payment")
            {
                AddDigitalPaymentUI();
            }
        }

        private void AddCashPaymentUI()
        {
            paymentDetailsPanel.Controls.Clear();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(5),
                BackColor = Color.White,
                AutoSize = true
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            TextBox txtChange = CreateTextBox(true);
            // Amount Paid Row
            Label lblAmountPaid = CreateLabel("Amount:", true);
            TextBox txtAmountPaid = CreateTextBox(false);
            txtAmountPaid.TextChanged += (s, e) => CalculateChange(txtAmountPaid, txtChange);

            // Change Row
            Label lblChange = CreateLabel("Change:", true);


            // Add controls to layout
            mainLayout.Controls.Add(lblAmountPaid, 0, 0);
            mainLayout.Controls.Add(txtAmountPaid, 1, 0);
            mainLayout.Controls.Add(lblChange, 0, 1);
            mainLayout.Controls.Add(txtChange, 1, 1);

            paymentDetailsPanel.Controls.Add(mainLayout);
        }

        private void AddDigitalPaymentUI()
        {
            paymentDetailsPanel.Controls.Clear();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(5),
                BackColor = Color.White,
                AutoSize = true
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            // Provider Row
            Label lblProvider = CreateLabel("Method:", true);
            ComboBox cmbProvider = CreateComboBox();
            cmbProvider.Items.AddRange(new string[] { "GCash", "PayMaya", "Bank" });

            // Reference Number Row
            Label lblReference = CreateLabel("Ref #:", true);
            TextBox txtReference = CreateTextBox(false);

            // Add controls to layout
            mainLayout.Controls.Add(lblProvider, 0, 0);
            mainLayout.Controls.Add(cmbProvider, 1, 0);
            mainLayout.Controls.Add(lblReference, 0, 1);
            mainLayout.Controls.Add(txtReference, 1, 1);

            paymentDetailsPanel.Controls.Add(mainLayout);
        }

        // Helper methods
        private Label CreateLabel(string text, bool isFieldLabel)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(47, 54, 64),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(2, 0, 0, 0),
                AutoSize = true
            };
        }

        private TextBox CreateTextBox(bool readOnly)
        {
            return new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                ReadOnly = readOnly,
                BackColor = readOnly ? Color.FromArgb(245, 246, 250) : Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(2),
                Height = 25
            };
        }

        private ComboBox CreateComboBox()
        {
            return new ComboBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.White,
                Margin = new Padding(2),
                Height = 25
            };
        }

        private void CalculateChange(TextBox amountPaid, TextBox change)
        {
            if (decimal.TryParse(amountPaid.Text, out decimal paid))
            {
                // Assuming you have a way to get the total amount
                decimal total = GetTotalAmount(); // Implement this method
                decimal changeAmount = paid - total;
                change.Text = changeAmount >= 0 ? changeAmount.ToString("N2") : "0.00";
                change.ForeColor = changeAmount >= 0 ? Color.FromArgb(46, 213, 115) : Color.Red;
            }
            else
            {
                change.Text = "0.00";
                change.ForeColor = Color.Black;
            }
        }

        private decimal GetTotalAmount()
        {
            return 0.00m;
        }

        private void PaymentForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is not TextBox textBox)
            {
                e.Handled = true;
                return;
            }

            bool isNumber = char.IsDigit(e.KeyChar);
            bool isBackspace = e.KeyChar == (char)Keys.Back;
            bool isDecimalPoint = e.KeyChar == '.';
            bool hasDecimalPoint = textBox.Text.Contains(".");

            e.Handled = !isNumber && !isBackspace && !(isDecimalPoint && !hasDecimalPoint);
        }
    }
}
