using client.Helpers;
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
        private decimal totalAmount = 0.00m;
        private decimal amountPaid = 0.00m;
        private decimal totalAmountPaid = 0.00m;
        private string paymentMethod = "Cash";
        private string referenceNumber = string.Empty;

        private string _selectedPayment = string.Empty;

        private TextBox? lastFocusedTextBox = new TextBox();
        public PaymentForm(decimal totalAmount)
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.GotFocus += (s, e) => lastFocusedTextBox = textBox;
                }
            }

            this.KeyPreview = true;
            btn1.Click += Numpad_Click;
            btn2.Click += Numpad_Click;
            btn3.Click += Numpad_Click;
            btn4.Click += Numpad_Click;
            btn5.Click += Numpad_Click;
            btn6.Click += Numpad_Click;
            btn7.Click += Numpad_Click;
            btn8.Click += Numpad_Click;
            btn9.Click += Numpad_Click;
            btnDot.Click += Numpad_Click;
            btnDelete.Click += Numpad_Click;
            btnApply.Click += Numpad_Click;
            btnRemove.Click += Numpad_Click;

            this.totalAmount = totalAmount;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblAmountToPay.Text = $"{totalAmount:C}";
            cboPaymentMethod.SelectedIndex = 0;
        }

        private void AddCashPaymentUI()
        {
            paymentDetailsPanel.Controls.Clear();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10),
                BackColor = Color.White,
                ColumnCount = 2,
                RowCount = 1,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            Label lblAmountPaid = StyledLabel("Amount", true);

            TextBox txtAmountPaid = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.FromArgb(64, 64, 64),
                BorderStyle = BorderStyle.None,
                Size = new Size(150, 30),
                TextAlign = HorizontalAlignment.Right,
                Multiline = true,
                AutoSize = false,
                Height = lblAmountPaid.Height
            };
            txtAmountPaid.TextChanged += (s, e) =>
            {
                if (decimal.TryParse(txtAmountPaid.Text, out decimal value))
                {
                    amountPaid = value;
                }
                else
                {
                    amountPaid = 0m;
                }
            };
            txtAmountPaid.KeyPress += txtAmountPaid_KeyPress;
            txtAmountPaid.Enter += txtAmountPaid_Enter;

            lblAmountPaid.TextAlign = ContentAlignment.MiddleRight;
            lblAmountPaid.Anchor = AnchorStyles.Right;
            lblAmountPaid.Margin = new Padding(0, 5, 10, 5);

            txtAmountPaid.Anchor = AnchorStyles.Left;
            txtAmountPaid.Margin = new Padding(0, 5, 0, 5);

            mainLayout.Controls.Add(lblAmountPaid, 0, 0);
            mainLayout.Controls.Add(txtAmountPaid, 1, 0);

            paymentDetailsPanel.Controls.Add(mainLayout);

            mainLayout.Anchor = AnchorStyles.None;
            mainLayout.Location = new Point(
                (paymentDetailsPanel.Width - mainLayout.PreferredSize.Width) / 2,
                (paymentDetailsPanel.Height - mainLayout.PreferredSize.Height) / 2
            );

            this.BeginInvoke((MethodInvoker)delegate
            {
                txtAmountPaid.Focus();
            });
        }

        private void AddDigitalPaymentUI()
        {
            paymentDetailsPanel.Controls.Clear();

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10),
                BackColor = Color.White,
                ColumnCount = 2,
                RowCount = 3,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));

            Label lblProvider = StyledLabel("Method", true);
            ComboBox cmbProvider = StyledComboBox();
            cmbProvider.Items.AddRange(new string[] { "GCash", "PayMaya", "Bank" });

            Label lblReference = StyledLabel("Ref #", true);
            TextBox txtReference = StyledTextBox(false);
            txtReference.TextChanged += (s, e) => referenceNumber = txtReference.Text;
            txtReference.Enter += txtReference_Enter;

            Label lblAmountSent = StyledLabel("Amount", true);
            TextBox txtAmountSent = StyledTextBox(false);
      
            txtAmountSent.TextChanged += (s, e) =>
            {
                if (decimal.TryParse(txtAmountSent.Text, out decimal value))
                {
                    amountPaid = value;
                }
                else
                {
                    amountPaid = 0m;
                }
            };
            txtAmountSent.Enter += txtAmountSent_Enter;
            txtAmountSent.KeyPress += txtAmountSent_KeyPress;

            cmbProvider.SelectedIndexChanged += (sender, e) => cmbProvider_SelectedIndexChanged(sender as ComboBox, txtReference, txtAmountSent);
            void cmbProvider_SelectedIndexChanged(ComboBox? cmb, TextBox reference, TextBox amountSent)
            {
                if (cmb?.SelectedIndex == -1)
                {
                    reference.Enabled = false;
                    amountSent.Enabled = false;
                }
                else
                {
                    reference.Enabled = true;
                    amountSent.Enabled = true;
                }
            }

            int fieldHeight = 30;
            cmbProvider.Height = fieldHeight;
            txtReference.Height = fieldHeight;
            txtAmountSent.Height = fieldHeight;

            lblProvider.TextAlign = ContentAlignment.MiddleRight;
            lblReference.TextAlign = ContentAlignment.MiddleRight;
            lblAmountSent.TextAlign = ContentAlignment.MiddleRight;

            cmbProvider.Margin = new Padding(0, 5, 0, 5);
            txtReference.Margin = new Padding(0, 5, 0, 5);
            txtAmountSent.Margin = new Padding(0, 5, 0, 5);

            txtAmountSent.TextAlign = HorizontalAlignment.Right;

            mainLayout.Controls.Add(lblProvider, 0, 0);
            mainLayout.Controls.Add(cmbProvider, 1, 0);
            mainLayout.Controls.Add(lblReference, 0, 1);
            mainLayout.Controls.Add(txtReference, 1, 1);
            mainLayout.Controls.Add(lblAmountSent, 0, 2);
            mainLayout.Controls.Add(txtAmountSent, 1, 2);

            paymentDetailsPanel.Controls.Add(mainLayout);
            mainLayout.Anchor = AnchorStyles.None;
            mainLayout.Location = new Point(
                (paymentDetailsPanel.Width - mainLayout.PreferredSize.Width) / 2,
                (paymentDetailsPanel.Height - mainLayout.PreferredSize.Height) / 2
            );

            this.BeginInvoke((MethodInvoker)delegate
            {
                cmbProvider.SelectedIndex = 0;
                txtReference.Focus();
            });
        }
        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentMethod.SelectedItem is null)
                return;

            string? selectedPayment = cboPaymentMethod.SelectedItem.ToString();

            AnimatePanelClear(paymentDetailsPanel, () =>
            {
                System.Windows.Forms.Timer delayTimer = new System.Windows.Forms.Timer();
                delayTimer.Interval = 100;
                delayTimer.Tick += (s, ev) =>
                {
                    delayTimer.Stop();

                    if (selectedPayment == "Cash")
                    {
                        paymentMethod = "Cash";
                        ResetFields();
                        AddCashPaymentUI();
                    }
                    else if (selectedPayment == "Digital Payment")
                    {
                        paymentMethod = "Digital Payment";
                        ResetFields();
                        AddDigitalPaymentUI();
                    }

                    AnimatePanelShow(paymentDetailsPanel);
                };
                delayTimer.Start();
            });
        }
        private void ResetFields()
        {
            ResetAmountPaid();
            ResetReferenceNumber();
        }
        private void ResetAmountPaid()
        {
            amountPaid = 0.00m;
        }
        private void ResetReferenceNumber()
        {
            referenceNumber = string.Empty;
        }
        private void AnimatePanelClear(Panel panel, Action onComplete)
        {
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 10;
            double opacity = 1.0;

            fadeTimer.Tick += (s, ev) =>
            {
                opacity -= 0.05;
                if (opacity <= 0)
                {
                    panel.Controls.Clear();
                    panel.BackColor = Color.White;
                    fadeTimer.Stop();

                    onComplete?.Invoke();
                }
                else
                {
                    panel.BackColor = Color.FromArgb((int)(opacity * 255), panel.BackColor);
                }
            };
            fadeTimer.Start();
        }
        private void AnimatePanelShow(Panel panel)
        {
            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 10;
            double opacity = 0.0;

            fadeTimer.Tick += (s, ev) =>
            {
                opacity += 0.05;
                if (opacity >= 1.0)
                {
                    fadeTimer.Stop();
                }
                else
                {
                    panel.BackColor = Color.FromArgb((int)(opacity * 255), Color.White);
                }
            };
            fadeTimer.Start();
        }
        private void txtAmountPaid_Enter(object? sender, EventArgs e)
        {
            lastFocusedTextBox = sender as TextBox;
        }
        private void txtAmountPaid_KeyPress(object? sender, KeyPressEventArgs e)
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
        private void txtReference_Enter(object? sender, EventArgs e)
        {
            lastFocusedTextBox = sender as TextBox;
        }
        private void txtAmountSent_Enter(object? sender, EventArgs e)
        {
            lastFocusedTextBox = sender as TextBox;
        }
        private void txtAmountSent_KeyPress(object? sender, KeyPressEventArgs e)
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
        private Label StyledLabel(string text, bool isBold)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 12, isBold ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = Color.FromArgb(64, 64, 64),
                AutoSize = true
            };
        }
        private TextBox StyledTextBox(bool isReadOnly)
        {
            return new TextBox
            {
                Font = new Font("Segoe UI", 12),
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.FromArgb(64, 64, 64),
                BorderStyle = BorderStyle.None,
                Size = new Size(150, 30),
                Margin = new Padding(0, 5, 0, 5),
                ReadOnly = isReadOnly,
                Padding = new Padding(10, 5, 10, 5)
            };
        }
        private ComboBox StyledComboBox()
        {
            return new ComboBox
            {
                Font = new Font("Segoe UI", 12),
                BackColor = Color.WhiteSmoke,
                ForeColor = Color.FromArgb(64, 64, 64),
                FlatStyle = FlatStyle.Flat,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(150, 30),
                Margin = new Padding(0, 5, 0, 5)
            };
        }
        private decimal GetTotalAmount()
        {
            return totalAmount;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Dispose();
                return true;
            }
            if (keyData == Keys.Insert)
            {
                btnApply.PerformClick();
                return true;
            }
            if (keyData == Keys.Delete)
            {
                btnRemove.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Numpad_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                LoggerHelper.Write("NUMPAD", $"Button clicked: {btn.Text}");

                if (lastFocusedTextBox != null)
                {
                    var textBox = lastFocusedTextBox;

                    if (btn.Tag?.ToString() == "delete")
                    {
                        if (textBox.SelectionLength > 0)
                        {
                            int start = textBox.SelectionStart;
                            textBox.Text = textBox.Text.Remove(start, textBox.SelectionLength);
                            textBox.SelectionStart = start;
                        }
                        else if (textBox.SelectionStart > 0)
                        {
                            int start = textBox.SelectionStart - 1;
                            textBox.Text = textBox.Text.Remove(start, 1);
                            textBox.SelectionStart = start;
                        }
                    }
                    else
                    {
                        if (btn.Text.Length == 1 && (char.IsDigit(btn.Text[0]) || btn.Text == "."))
                        {
                            if (btn.Text == "." && textBox.Text.Contains("."))
                            {
                                return;
                            }

                            int selectionStart = textBox.SelectionStart;
                            textBox.Text = textBox.Text.Insert(selectionStart, btn.Text);
                            textBox.SelectionStart = selectionStart + 1;
                        }
                    }

                    textBox.Focus();
                }
                else
                {
                    LoggerHelper.Write("NUMPAD", "No TextBox has been focused.");
                }
            }
            else
            {
                LoggerHelper.Write("NUMPAD", "Sender is not a Button.");
            }
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (amountPaid <= 0)
            {
                MessageBox.Show("Please enter the amount paid.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dgvMop.Rows.Add(paymentMethod, amountPaid, referenceNumber);
                ProcessPayment();
            }
        }

        private void ProcessPayment()
        {
            CalculateTotalAmountPaid();
        }

        private void UpdateChange()
        {
            decimal change = totalAmountPaid - GetTotalAmount();
            decimal defChange = 0.00m;
            if (change > 0)
            {
                lblChange.Text = $"{change:C}";
            }
            else
            {
                lblChange.Text = $"{defChange:C}";
            }
        }

        private void UpdateBalance()
        {
            decimal balance = GetTotalAmount() - totalAmountPaid;
            decimal defBal = 0.00m;
            if (balance > 0)
            {
                lblBalance.Text = $"{balance:C}";
            }
            else
            {
                lblBalance.Text = $"{defBal:C}";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMop.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvMop.SelectedRows[0].Index;

                    decimal amount = Convert.ToDecimal(dgvMop.Rows[rowIndex].Cells["Amount"].Value);

                    dgvMop.Rows.RemoveAt(rowIndex);

                    CalculateTotalAmountPaid();
                }
                else
                {
                    MessageBox.Show("Please select a payment method to remove.", "Remove Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
               
            }
        }
        private void CalculateTotalAmountPaid()
        {
            totalAmountPaid = 0m;

            foreach (DataGridViewRow row in dgvMop.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                {
                    totalAmountPaid += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            UpdateChange();
            UpdateBalance();
            lblAmountPaid.Text = $"{totalAmountPaid:C}";
        }

        private void dgvMop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedPayment = e.RowIndex.ToString();
            }
            catch
            {

            }
        }
    }
}
