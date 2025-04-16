using client.Controllers;
using client.Forms.ProductManagement;
using client.Helpers;
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
using static System.Windows.Forms.DataFormats;

namespace client.Forms.POS.POSUserControl.ProductFoodCategory
{
    public partial class NewCategory : Form
    {
        private readonly UnitController _unitController = new UnitController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();

        private int? selectedCategoryId = CurrentCategory.Current?.Id;
        private string title = string.Empty;
        private string name = string.Empty;
        private string label = string.Empty;

        private readonly AddProduct _parentForm;

        public NewCategory(string title, string label, string name, AddProduct parent)
        {
            InitializeComponent();
            this.title = title;
            this.name = name;
            this.label = label;

            _parentForm = parent;
        }

        private void NewCategory_Load(object sender, EventArgs e)
        {
            txtTitle.Text = title;
            txtName.PlaceholderText = label;
        }

        private void ToggleButton(Boolean tog)
        {
            btnSave.Enabled = tog;
            //string message = (tog) ? "Save" : "Saving...";
            //btnSave.Text = message;
        }

        private async void HandleUnit(string unitName)
        {
            bool response = await _unitController.Create(unitName, "Test Muna");
            if (response)
            {
                MessageBox.Show($"Unit '{unitName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }

        private async void HandleCategory(string categoryName)
        {
            if (selectedCategoryId == null) // Create new category.
            {
                bool response = await _categoryController.Create(categoryName);
                if (response)
                {
                    HideLoading();
                    //MessageBox.Show($"Category '{categoryName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                    bool getCategories = await _categoryController.Get();
                    if (getCategories)
                    {
                        _parentForm.GetCategory();
                    }
                }
                else
                {
                    ToggleButton(true);
                }
            }
            else // Create sub category
            {
                bool response = await _subCategoryController.Create(categoryName, (int)selectedCategoryId);
                if (response)
                {
                    CurrentSubCategory.SetCurrentSubCategory(null); // This is to prevent the subcategory that show only the selected category previously.

                    HideLoading();
                    //MessageBox.Show($"Subcategory '{categoryName}' has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                    var getCategories = await _subCategoryController.GetAllSubcategory();
                    if (getCategories.Any())
                    {
                        _parentForm.GetSubCategory();
                    }
                }
                else
                {
                    HideLoading();
                    ToggleButton(true);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ToggleButton(false);
            ShowLoading("Creating new category...");
            await Task.Delay(50);

            string name = txtName.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (label)
                {
                    case "Category":
                        HandleCategory(name);
                        break;
                    case "Subcategory":
                        HandleCategory(name);
                        break;
                    case "Unit":
                        HandleUnit(name);
                        break;
                    default:
                        Logger.Write("CREATE UNIT/CATEGORY", "Unknown data received!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            finally
            {
                ToggleButton(true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtName.Text.Length) > 0)
            {
                if (MessageBox.Show("Discard changes?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
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
