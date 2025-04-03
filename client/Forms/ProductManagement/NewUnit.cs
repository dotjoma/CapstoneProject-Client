using client.Controllers;
using client.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace client.Forms.ProductManagement
{
    public partial class NewUnit : Form
    {
        private readonly UnitController _unitController = new UnitController();

        private readonly AddProduct _parentForm;

        public NewUnit(AddProduct parent)
        {
            InitializeComponent();

            _parentForm = parent;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            ShowLoading("Creating new unit...");
            await Task.Delay(50);

            string name = txtName.Text.Trim();
            string desc = rtbDescription.Text.Trim();

            try
            {
                if (!Validation(name, desc)) return;
                HandleUnit(name, desc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                HideLoading();
                return;
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private bool Validation(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Description cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return false;
            }

            return true;
        }

        private async void HandleUnit(string unitName, string unitDesc)
        {
            bool response = await _unitController.Create(unitName, unitDesc);
            if (response)
            {
                HideLoading();
                //MessageBox.Show($"Unit '{unitName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

                bool getUnits = await _unitController.Get();
                if (getUnits)
                {
                    _parentForm.GetUnit();
                }
            }
            else
            {
                ToggleButton(true);
                HideLoading();
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            //string message = (tog) ? "Save" : "Saving...";
            //btnSave.Text = message;
        }

        private void NewUnit_Load(object sender, EventArgs e)
        {
            //this.ShowInTaskbar = false;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private System.Windows.Forms.Label messageLabel = new System.Windows.Forms.Label();

        private void InitializeLoadingControls()
        {
            loadingPanel.BackColor = Color.White;
            loadingPanel.BorderStyle = BorderStyle.None;
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
    }
}
