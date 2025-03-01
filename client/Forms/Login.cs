using client.Controllers;
using client.Helpers;
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

namespace client.Forms
{
    public partial class Login : Form
    {
        private readonly AuthController _authController = new AuthController();
        private readonly ProductController _productController = new ProductController();
        private readonly UnitController _unitController = new UnitController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();

        private Point dragOffset;
        private bool isDragging = false;
        private bool isPassHidden = true;

        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            isPassHidden = true;
            txtPassword.PasswordChar = '●';
            txtPassword.UseSystemPasswordChar = false;
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

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            ToggleButton(false);
            await Task.Delay(1);

            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();

            string username = "joma";
            string password = "12345678@Joma";

            try
            {
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

                        MessageBox.Show("Login successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        LoggerHelper.Write("MAIN MENU", $"Error loading data: {ex.Message}");
                    }
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

        private async Task<bool> LoadDataBase()
        {
            try
            {
                await _productController.GetAllProducts();
                if (CurrentProduct.AllProduct == null)
                {
                    LoggerHelper.Write("MAIN MENU", "Failed to load products");
                    return false;
                }
                LoggerHelper.Write("MAIN MENU", $"Successfully loaded {CurrentProduct.AllProduct.Count} products");

                await _unitController.GetAllUnits();
                if (CurrentUnit.AllUnit == null)
                {
                    LoggerHelper.Write("MAIN MENU", "Failed to load units");
                    return false;
                }
                LoggerHelper.Write("MAIN MENU", $"Successfully loaded {CurrentUnit.AllUnit.Count} units");


                await _categoryController.GetAllCategories();
                if (CurrentCategory.AllCategories == null)
                {
                    LoggerHelper.Write("MAIN MENU", "Failed to load categories");
                    return false;
                }
                LoggerHelper.Write("MAIN MENU", $"Successfully loaded {CurrentCategory.AllCategories.Count} categories");

                await _subCategoryController.GetAllSubcategory();
                if (CurrentSubCategory.AllSubCategories == null)
                {
                    LoggerHelper.Write("MAIN MENU", "Failed to load subcategories");
                    return false;
                }
                LoggerHelper.Write("MAIN MENU", $"Successfully loaded {CurrentSubCategory.AllSubCategories.Count} subcategories");

                return true;
            }
            catch (Exception ex)
            {
                LoggerHelper.Write("MAIN MENU", $"Error loading data: {ex.Message}");
                return false;
            }
        }

        private void ToggleButton(Boolean tog)
        {
            txtUsername.Enabled = tog;
            txtPassword.Enabled = tog;
            btnSignIn.Enabled = tog;
            string text = (tog) ? "Sign In" : "Sining In...";
            btnSignIn.Text = text;
        }

        private void btnSignIn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }
    }
}
