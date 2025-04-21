using client.Controllers;
using client.Forms.Order;
using client.Helpers;
using client.Models;
using client.Network;
using client.Services;
using client.Services.Auth;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace client.Forms
{
    public partial class Login : Form
    {
        private readonly AuthController _authController = new AuthController();
        private readonly ProductController _productController = new ProductController();
        private readonly UnitController _unitController = new UnitController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();
        private readonly DiscountController _discountController = new DiscountController();
        private readonly SupplierController _supplierController = new SupplierController();
        private readonly InventoryController _inventoryController = new InventoryController();

        private Point dragOffset;
        private bool isDragging = false;
        private bool isPassHidden = true;
        private bool isSigningIn = false;

        public Login()
        {
            InitializeComponent();
            InitializeLoadingControls();
            this.KeyPreview = true;

            MainMenu.OnRefreshClicked += RefreshDatabase;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblCredits.Text = $"© {DateAndTime.Now.Year} Elicia's Garden Food Park. All Rights Reserved.";
            timer1.Start();
            isPassHidden = true;
            txtPassword.PasswordChar = '●';
            txtPassword.UseSystemPasswordChar = false;
        }

        private async void RefreshDatabase()
        {
            await LoadDataBase();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .4;
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newLocation.X - dragOffset.X, newLocation.Y - dragOffset.Y);
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btnForgotPass_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnForgotPass_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            isPassHidden = !isPassHidden;
            if (isPassHidden)
            {
                txtPassword.PasswordChar = '●';
                txtPassword.IconRight = Properties.Resources.Eye;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.IconRight = Properties.Resources.Hide;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regfrm = new Register();
            regfrm.Show();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            isSigningIn = true;
            //ShowLoading("Signing In...");
            ToggleButton(false);
            Cursor = Cursors.WaitCursor;
            await Task.Delay(1);

            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();

            string username = "joma";
            string password = "12345678@Joma";

            try
            {
                if (!ValidateFields(username, password))
                    return;

                bool response = await _authController.Login(username, password);

                if (response)
                {
                    try
                    {
                        bool dataLoaded = await LoadDataBase();
                        if (!dataLoaded)
                        {
                            MessageBox.Show("Failed to load application data. Please try again.",
                                "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (CurrentUser.IsAdmin)
                        {
                            RedirectToDashboard();
                        }
                        else
                        {
                            RedirectToTransaction();
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Write("MAIN MENU", $"Error loading data: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                ToggleButton(true);
                HideLoading();
                isSigningIn = false;
            }
        }

        private bool ValidateFields(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (username.Length < 4)
            {
                MessageBox.Show("Username must be at least 4 characters long", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (!username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username can only contain letters, numbers, and underscores",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void RedirectToDashboard()
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void RedirectToTransaction()
        {
            var transaction = new OrderEntryForm();
            transaction.Show();
            this.Hide();
        }

        private async Task<bool> LoadDataBase()
        {
            try
            {
                var productsTask = _productController.GetAllProducts();
                var unitsTask = _unitController.GetAllUnits();
                var categoriesTask = _categoryController.GetAllCategories();
                var inventoryCategoriesTask = _categoryController.GetAllInventoryCategories();
                var subCategoriesTask = _subCategoryController.GetAllSubcategory();
                var discountsTask = _discountController.GetAllDiscounts();
                var unitTypesTask = _unitController.GetAllInventoryUnitTypes();
                var unitMeasuresTask = _unitController.GetAllInventoryUnitMeasures();
                var suppliersTask = _supplierController.GetAllInventorySuppliers();
                var inventoryItemTask = _inventoryController.GetAllInventoryItems();

                await Task.WhenAll(
                    productsTask, 
                    unitsTask, 
                    categoriesTask, 
                    inventoryCategoriesTask, 
                    subCategoriesTask, 
                    discountsTask, 
                    unitTypesTask,
                    unitMeasuresTask,
                    suppliersTask,
                    inventoryItemTask
                    );

                bool allSuccess = true;

                // Products
                if (CurrentProduct.AllProduct == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load products");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentProduct.AllProduct.Count} products");
                }

                // Units
                if (CurrentUnit.AllUnit == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load units");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentUnit.AllUnit.Count} units");
                }

                // Categories
                if (CurrentCategory.AllCategories == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load categories");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentCategory.AllCategories.Count} categories");
                }

                // Inventory Categories
                if (CurrentInventoryCategory.AllInventoryCategories == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load inventory categories");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentInventoryCategory.AllInventoryCategories.Count} inventory categories");
                }

                // Subcategories
                if (CurrentSubCategory.AllSubCategories == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load subcategories");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentSubCategory.AllSubCategories.Count} subcategories");
                }

                // Discounts
                if (CurrentDiscount.AllDiscount == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load discounts");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentDiscount.AllDiscount.Count} discounts");
                }

                // Inventory unit types
                if (CurrentInventoryUnitType.AllUnitTypes == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load inventory unit types");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentInventoryUnitType.AllUnitTypes.Count} inventory unit types");
                }

                // Inventory unit measures
                if (CurrentInventoryUnitMeasure.AllUnitMeasures == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load inventory unit measures");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentInventoryUnitMeasure.AllUnitMeasures.Count} inventory unit measures");
                }

                // Inventory suppliers
                if (CurrentSupplier.AllSuppliers == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load suppliers");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentSupplier.AllSuppliers.Count} suppliers");
                }

                // Inventory items
                if (CurrentInventoryItem.AllItems == null)
                {
                    Logger.Write("MAIN MENU", "Failed to load inventory items");
                    allSuccess = false;
                }
                else
                {
                    Logger.Write("MAIN MENU", $"Successfully loaded {CurrentInventoryItem.AllItems.Count} inventory items");
                }

                return allSuccess;
            }
            catch (Exception ex)
            {
                Logger.Write("MAIN MENU", $"Error loading data: {ex.Message}");
                return false;
            }
        }

        private void ToggleButton(Boolean tog)
        {
            btnSignIn.Enabled = tog;
            cbRememberMe.Enabled = tog;
            btnCreateAccount.Enabled = tog;
            btnForgotPass.Enabled = tog;
        }

        private void btnSignIn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isSigningIn)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSignIn.PerformClick();
                }
            }
        }

        private Panel loadingPanel = new Panel();
        private PictureBox pictureBox = new PictureBox();
        private Panel panelBox = new Panel();
        private Label messageLabel = new Label();

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
            messageLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
