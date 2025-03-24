using client.Controllers;
using client.Forms.ProductManagement;
using client.Helpers;
using client.Models;
using client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Forms.DiscountManagement
{
    public partial class AddDiscount : Form
    {
        DiscountController _discountController = new DiscountController();
        private Panel pnlCategoryList = new Panel();
        private FlowLayoutPanel flowApplicableTo = new FlowLayoutPanel();
        private System.Windows.Forms.Timer searchTimer = new System.Windows.Forms.Timer();
        public AddDiscount()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            await Task.Delay(1);

            try
            {
                string name = txtName.Text.Trim();
                string type = cboType.Text;
                decimal value = string.IsNullOrWhiteSpace(txtValue.Text) ? 0 : decimal.Parse(txtValue.Text);
                string formattedValue = value.ToString("F2");
                string applicableTo = string.Join(", ", CurrentDiscount.AllDiscount.Select(d => d.Id));
                int vatExempt = rbVatExemptYes.Checked ? 1 : 0;
                int isActive = cbIsActive.Checked ? 1 : 0;

                var applicableToList = CurrentDiscount.AllDiscount
                           .Select(d => d.Id)
                           .ToList();

                if (!ValidateRequiredFields(name, type, formattedValue, vatExempt.ToString(), applicableToList))
                    return;

                bool response = await _discountController.Create(name, type, value, vatExempt, isActive, applicableToList);

                if (response)
                {
                    Logger.Write("RESPONSE", $"Discount created successfully.");
                    MessageBox.Show("Discount created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DiscountHome.Instance?.RefreshDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
        }

        private bool ValidateRequiredFields(string name, string type, string value, string vatExempt, List<int> applicableTo)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Discount name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Discount type is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Discount value is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(value, out decimal discountValue) || discountValue <= 0)
            {
                MessageBox.Show("Discount value must be a valid positive number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(vatExempt) || !(vatExempt == "0" || vatExempt == "1"))
            {
                MessageBox.Show("VAT Exemption must be either '0' (No) or '1' (Yes).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (applicableTo == null || applicableTo.Count == 0)
            {
                MessageBox.Show("Please select at least one applicable category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to cancel? Your changes will be discarded.",
                    "Cancel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private bool Validation()
        {
            bool hasData =
                !string.IsNullOrWhiteSpace(txtName.Text) ||
                cboType.SelectedIndex >= 0 ||
                !string.IsNullOrWhiteSpace(txtValue.Text) ||
                !string.IsNullOrWhiteSpace(txtApplicableTo.Text);

            if (hasData)
            {
                return true;
            }

            return false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name for the discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboType.SelectedIndex == -0)
            {
                MessageBox.Show("Please select a type for the discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Please enter a value for the discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApplicableTo.Text))
            {
                MessageBox.Show("Please select categories for the discount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddDiscount_Load(object sender, EventArgs e)
        {
            rbVatExemptYes.Checked = true;

            if (!string.IsNullOrEmpty(txtApplicableTo.Text))
            {
                selectedCategories = txtApplicableTo.Text
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            pnlCategoryList = new Panel
            {
                Size = new Size(350, 350),
                BackColor = Color.White,
                Visible = false,
                Padding = new Padding(15),
                AutoScroll = true
            };

            Panel overlay = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(50, 0, 0, 0),
                Visible = false
            };

            pnlCategoryList.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, pnlCategoryList.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            flowApplicableTo = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                Height = 180
            };

            Button btnDoneCategory = new Button
            {
                Text = "Done",
                Dock = DockStyle.Bottom,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(0, 120, 212),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 10, 0, 0)
            };

            btnDoneCategory.FlatAppearance.BorderSize = 0;
            btnDoneCategory.Click += btnDoneCategory_Click;

            btnDoneCategory.MouseEnter += (s, e) =>
                btnDoneCategory.BackColor = Color.FromArgb(0, 100, 190);
            btnDoneCategory.MouseLeave += (s, e) =>
                btnDoneCategory.BackColor = Color.FromArgb(0, 120, 212);

            TextBox searchBox = new TextBox
            {
                Dock = DockStyle.Top,
                Height = 30,
                Font = new Font("Segoe UI", 10),
                PlaceholderText = "Search categories...",
                Margin = new Padding(0, 0, 0, 10)
            };

            searchTimer = new System.Windows.Forms.Timer
            {
                Interval = 300
            };

            searchTimer.Tick += (s, e) =>
            {
                searchTimer.Stop();
                string searchText = searchBox.Text.ToLower().Trim();

                foreach (Control control in flowApplicableTo.Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        checkbox.Visible = string.IsNullOrEmpty(searchText) ||
                                         checkbox.Text.ToLower().Contains(searchText);
                    }
                }
            };

            searchBox.TextChanged += (s, e) =>
            {
                searchTimer.Stop();
                searchTimer.Start();
            };

            pnlCategoryList.Controls.Add(btnDoneCategory);
            pnlCategoryList.Controls.Add(flowApplicableTo);
            pnlCategoryList.Controls.Add(searchBox);

            pnlCategoryList.BringToFront();

            this.Controls.Add(pnlCategoryList);
            this.Controls.Add(overlay);

            pnlCategoryList.VisibleChanged += (s, e) =>
            {
                overlay.Visible = pnlCategoryList.Visible;
                if (pnlCategoryList.Visible)
                {
                    overlay.BringToFront();
                    pnlCategoryList.BringToFront();
                }
            };
        }

        private void btnDoneCategory_Click(object? sender, EventArgs e)
        {
            selectedCategories.Clear();
            List<int> selectedCategoryIds = new List<int>();

            foreach (Control control in flowApplicableTo.Controls)
            {
                if (control is CheckBox chk && chk.Checked)
                {
                    selectedCategories.Add(chk.Text);
                    if (chk.Tag is int categoryId)
                    {
                        selectedCategoryIds.Add(categoryId);
                    }
                }
            }

            txtApplicableTo.Text = string.Join(", ", selectedCategories);

            List<Discount> discounts = selectedCategoryIds?
                .Select(id => new Discount { Id = id })
                .ToList() ?? new List<Discount>();

            CurrentDiscount.SetDiscounts(discounts);
            pnlCategoryList.Visible = false;
        }

        private List<string> selectedCategories = new List<string>();
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            flowApplicableTo.Controls.Clear();

            Label headerLabel = new Label
            {
                Text = "Select Applicable Categories",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(64, 64, 64),
                AutoSize = true,
                Padding = new Padding(10),
                Dock = DockStyle.Top
            };
            flowApplicableTo.Controls.Add(headerLabel);

            foreach (var category in CurrentCategory.AllCategories)
            {
                CheckBox chk = new CheckBox
                {
                    Text = category.Name,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10, 5, 5, 5),
                    Cursor = Cursors.Hand,
                    Checked = selectedCategories.Contains(category.Name),
                    Tag = category.Id
                };
                flowApplicableTo.Controls.Add(chk);
            }

            pnlCategoryList.Location = new Point(
                (this.ClientSize.Width - pnlCategoryList.Width) / 2,
                (this.ClientSize.Height - pnlCategoryList.Height) / 2
            );

            pnlCategoryList.Visible = true;
            pnlCategoryList.BringToFront();
        }

        private void txtApplicableTo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
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
