using client.Controllers;
using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace client.Forms.Order
{
    public partial class PaymentForm : Form
    {
        private readonly TransactionController _transactionController = new TransactionController();

        private decimal _totalAmount = 0;
        private decimal _amountPaid = 0;
        private decimal _totalAmountPaid = 0;
        private decimal _totalDiscount = 0;
        private decimal _totalChange = 0;
        private string _referenceNumber = string.Empty;

        // Transaction Details.
        private string? _paymentMethod = "cash";

        // Order Details.
        private string _orderType = string.Empty;

        private string _selectedPayment = string.Empty;

        private TextBox? lastFocusedTextBox = new TextBox();
        private TextBox txtAmountPaid = new TextBox();
        private TextBox txtReference = new TextBox();
        private TextBox txtAmountSent = new TextBox();

        public static event Action? PostPaymentProcess;

        private static int refreshScreen = 5;

        // Event
        public static event Action? OnSalesReportUpdated;

        public PaymentForm(decimal totalAmount, string orderType, decimal discount)
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

            this._totalAmount = totalAmount;
            this._orderType = orderType;
            this._totalDiscount = discount;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            lblAmountToPay.Text = $"{_totalAmount:C}";
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

            txtAmountPaid = new TextBox
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
                    _amountPaid = value;
                }
                else
                {
                    _amountPaid = 0m;
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
            txtReference = StyledTextBox(false);
            txtReference.TextChanged += (s, e) => _referenceNumber = txtReference.Text;
            txtReference.Enter += txtReference_Enter;

            Label lblAmountSent = StyledLabel("Amount", true);
            txtAmountSent = StyledTextBox(false);

            txtAmountSent.TextChanged += (s, e) =>
            {
                if (decimal.TryParse(txtAmountSent.Text, out decimal value))
                {
                    _amountPaid = value;
                }
                else
                {
                    _amountPaid = 0m;
                }
            };
            txtAmountSent.Enter += txtAmountSent_Enter;
            txtAmountSent.KeyPress += txtAmountSent_KeyPress;

            cmbProvider.SelectedIndexChanged += (sender, e) => cmbProvider_SelectedIndexChanged(sender as ComboBox, txtReference, txtAmountSent);

            void cmbProvider_SelectedIndexChanged(ComboBox? cmb, TextBox reference, TextBox amountSent)
            {
                string? selectedPaymentMethod = cmbProvider.SelectedItem?.ToString();
                _paymentMethod = selectedPaymentMethod;
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
                        _paymentMethod = "cash";
                        ResetFields();
                        AddCashPaymentUI();
                    }
                    else if (selectedPayment == "Digital Payment")
                    {
                        _paymentMethod = "gcash";
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
            _amountPaid = 0.00m;
        }
        private void ResetReferenceNumber()
        {
            _referenceNumber = string.Empty;
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
            return _totalAmount;
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
                Logger.Write("NUMPAD", $"Button clicked: {btn.Text}");

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
                    Logger.Write("NUMPAD", "No TextBox has been focused.");
                }
            }
            else
            {
                Logger.Write("NUMPAD", "Sender is not a Button.");
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
            if (_amountPaid <= 0)
            {
                MessageBox.Show("Please enter the amount paid.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dgvMop.Rows.Add(_paymentMethod, _amountPaid, _referenceNumber);
                ProcessPayment();
                txtAmountPaid.Clear();
                txtAmountSent.Clear();
            }
        }

        private void ProcessPayment()
        {
            CalculateTotalAmountPaid();
        }

        private void UpdateChange()
        {
            decimal change = _totalAmountPaid - GetTotalAmount();
            decimal defChange = 0.00m;
            _totalChange = change;
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
            decimal balance = GetTotalAmount() - _totalAmountPaid;
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
            _totalAmountPaid = 0m;

            foreach (DataGridViewRow row in dgvMop.Rows)
            {
                if (row.Cells["Amount"].Value != null)
                {
                    _totalAmountPaid += Convert.ToDecimal(row.Cells["Amount"].Value);
                }
            }

            UpdateChange();
            UpdateBalance();
            lblAmountPaid.Text = $"{_totalAmountPaid:C}";
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

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private Label messageLabel = new Label();

        private void InitializeLoadingControls()
        {
            loadingPanel.BackColor = Color.White;
            loadingPanel.BorderStyle = BorderStyle.FixedSingle;
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

        private void postPaymentTimer_Tick(object sender, EventArgs e)
        {
            refreshScreen -= 1;

            if (refreshScreen <= 0)
            {
                PostPaymentProcess?.Invoke();
                this.Dispose();
                postPaymentTimer.Stop();
            }
        }

        private bool ValidatePaymentInputs(out string errorMessage)
        {
            errorMessage = string.Empty;
            string? selectedPayment = cboPaymentMethod.SelectedItem?.ToString();

            if (CurrentTransaction.Current == null)
            {
                errorMessage = "No active transaction found";
                return false;
            }

            if (CurrentTransaction.Current.TransId <= 0)
            {
                errorMessage = "Invalid transaction ID";
                return false;
            }

            if (CurrentUser.Current == null || CurrentUser.Current.UserId <= 0)
            {
                errorMessage = "Invalid cashier session";
                return false;
            }

            if (dgvMop.Rows.Count == 0)
            {
                errorMessage = "Apply the payment first.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(_paymentMethod))
            {
                errorMessage = "Payment method not selected";
                return false;
            }

            if ((cboPaymentMethod.SelectedItem?.ToString() == "Digital Payment") && string.IsNullOrWhiteSpace(_referenceNumber))
            {
                errorMessage = "Reference number is required for digital payment";
                txtReference.Focus();
                return false;
            }

            if (_totalAmount <= 0)
            {
                errorMessage = "Invalid total amount";
                if (selectedPayment == "Cash")
                {
                    txtAmountPaid.Focus();
                }
                else
                {
                    txtAmountSent.Focus();
                }

                return false;
            }

            if (_totalAmountPaid <= 0)
            {
                errorMessage = "Invalid payment amount";
                if (selectedPayment == "Cash")
                {
                    txtAmountPaid.Focus();
                }
                else
                {
                    txtAmountSent.Focus();
                }
                return false;
            }

            if (_totalAmountPaid < _totalAmount)
            {
                errorMessage = "Payment amount is less than total amount";
                if (selectedPayment == "Cash")
                {
                    txtAmountPaid.Focus();
                }
                else
                {
                    txtAmountSent.Focus();
                }
                return false;
            }

            if (_totalChange < 0)
            {
                errorMessage = "Invalid change amount";
                return false;
            }

            return true;
        }

        private async void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                ShowLoading("Processing payment, please wait...");

                if (!ValidatePaymentInputs(out string errorMessage))
                {
                    HideLoading();
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int transId = Convert.ToInt32(CurrentTransaction.Current?.TransId);
                string transNo = CurrentTransaction.Current?.TransNumber ?? string.Empty;
                int cashierId = CurrentUser.Current?.UserId ?? 0;
                var cartItems = CurrentCart.Items;
                string notes = string.Empty;
                string orderType = _orderType.Trim();
                decimal discount = _totalDiscount;
                decimal totalDue = _totalAmountPaid;

                var transaction = new TransactionProcessing()
                {
                    TransId = transId,
                    totalAmount = _totalAmount,
                    status = "paid",
                    paymentMethod = _paymentMethod
                };

                var order = ProcessOrderHelper.CreateOrderProcessingList(cartItems, transNo, cashierId, notes, orderType, discount, totalDue);

                var payment = new PaymentProcessing()
                {
                    transId = transId,
                    amountPaid = _totalAmountPaid,
                    paymentMethod = _paymentMethod,
                    referenceNumber = _referenceNumber,
                    changeAmount = _totalChange
                };

                bool response = await _transactionController.ProcessTransaction(transaction, order, payment);

                if (response)
                {
                    postPaymentTimer.Start();
                    HideLoading();
                    MessageBox.Show("Transaction processed successfully.",
                        "Payment",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PostPaymentProcess?.Invoke();
                    OnSalesReportUpdated?.Invoke();

                    this.Dispose();
                }
                else
                {
                    HideLoading();
                    MessageBox.Show("Failed to process transaction.",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                HideLoading();
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideLoading();
            }
        }

        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
