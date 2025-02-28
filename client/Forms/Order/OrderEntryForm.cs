using client.Controllers;
using client.Controls.Products;
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

namespace client.Forms.Order
{
    public partial class OrderEntryForm : Form
    {
        private FlowLayoutPanel cartContainerPanel;
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly ProductController _productController = new ProductController();

        public static OrderEntryForm? Instance { get; private set; }

        public OrderEntryForm()
        {
            InitializeComponent();
            Instance = this;
            this.FormClosed += OrderEntryForm_FormClosed;
            this.Name = "OrderEntryForm";

            cartContainerPanel = cartPanel as FlowLayoutPanel;

            if (cartContainerPanel == null)
            {
                cartContainerPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                cartPanel.Controls.Add(cartContainerPanel);
            }
        }

        private async void OrderEntryForm_Load(object sender, EventArgs e)
        {
            DataCache.ShouldRefreshCategories = true;
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            await InitializeData();
        }

        private async Task InitializeData()
        {
            try
            {
                // Check if categories need to be refreshed
                Task<bool> categoryTask = DataCache.ShouldRefreshCategories
                    ? _categoryController.Get()
                    : Task.FromResult(false); // If not refreshing, return a completed task

                // Await the category task before loading products
                bool categoriesRefreshed = await categoryTask; // Wait for category task to complete

                // Check category load result
                if (!categoriesRefreshed) // Check the result of categoryTask
                {
                    LoggerHelper.Write("LOAD CATEGORIES", "Failed to load categories.");
                    MessageBox.Show("Failed to load categories.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if products are already cached and valid
                if (!DataCache.ProductsAreValid) // Assuming a property to check cache validity
                {
                    // Load products after categories are loaded
                    var products = await LoadProducts(); // Await the task to get the list of products

                    // Save products and categories to cache after loading
                    SaveProductsToCache(products); // New method to save products to cache
                }

                // Update the last category update time
                DataCache.LastCategoryUpdate = DateTime.Now;

                // Create category buttons after categories are loaded
                CreateCategoryButtons();

                // Load subcategories if a category is selected
                if (CurrentCategory.Current?.Id > 0)
                {
                    bool subCategoriesLoaded = await _subCategoryController.Get(CurrentCategory.Current.Id);
                    if (!subCategoriesLoaded)
                    {
                        MessageBox.Show("Failed to load subcategories.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("LOAD ERROR", ex.Message);
            }
        }

        // Save products and categories to cache
        private async void SaveProductsToCache(List<client.Models.Product> products)
        {
            var categories = await _categoryController.GetAllCategories();
            var cacheData = new CacheData
            {
                LastUpdate = DateTime.UtcNow,
                Products = products,
                Categories = categories
            };

            CacheService.SaveToCache(cacheData);
        }

        private void CreateCategoryButtons()
        {
            categoriesPanel.Controls.Clear();

            categoriesPanel.AutoScroll = true;
            categoriesPanel.WrapContents = false;
            categoriesPanel.FlowDirection = FlowDirection.LeftToRight;
            categoriesPanel.HorizontalScroll.Enabled = true;
            categoriesPanel.HorizontalScroll.Visible = true;

            int buttonMargin = 5;
            int buttonHeight = 40;
            int buttonWidth = 110;

            var categories = CurrentCategory.AllCategories;
            if (categories != null && categories.Count > 0)
            {
                foreach (var category in categories)
                {
                    if (category != null && !string.IsNullOrEmpty(category.Name))
                    {
                        Button categoryButton = new Button
                        {
                            Text = category.Name,
                            Width = buttonWidth,
                            Height = buttonHeight,
                            Margin = new Padding(buttonMargin, buttonMargin, 0, buttonMargin),
                            Tag = category.Id,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                            Font = new Font("Segoe UI", 11, FontStyle.Regular),
                            Cursor = Cursors.Hand,
                            TabStop = false
                        };

                        categoryButton.FlatAppearance.BorderSize = 1;
                        categoryButton.FlatAppearance.BorderColor = Color.WhiteSmoke;

                        categoryButton.MouseEnter += (s, e) =>
                        {
                            if (s is Button btn)
                            {
                                btn.BackColor = Color.LightGray;
                            }
                        };

                        categoryButton.MouseLeave += (s, e) =>
                        {
                            if (s is Button btn)
                            {
                                btn.BackColor = Color.White;
                            }
                        };

                        categoryButton.Click += async (sender, e) =>
                        {
                            if (sender is Button button && button.Tag is int categoryId)
                            {
                                categoriesPanel.Focus();
                                await HandleCategoryClick(categoryId);
                            }
                        };

                        categoriesPanel.Controls.Add(categoryButton);
                    }
                }
            }
        }

        private async Task HandleCategoryClick(int categoryId)
        {
            try
            {
                if (CurrentCategory.AllCategories == null || !CurrentCategory.AllCategories.Any())
                {
                    MessageBox.Show("No categories available.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var selectedCategory = CurrentCategory.AllCategories
                    .FirstOrDefault(c => c.Id == categoryId);

                if (selectedCategory != null)
                {
                    CurrentCategory.SetCurrentCategory(selectedCategory);

                    bool success = await _subCategoryController.Get(categoryId);
                    if (success)
                    {
                        ShowSubCategories();
                    }
                    else
                    {
                        MessageBox.Show("Failed to load subcategories.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoggerHelper.Write("SUBCATEGORY LOAD ERROR", $"Failed to load subcategories for category ID: {categoryId}");
                    }
                }
                else
                {
                    MessageBox.Show("Selected category not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoggerHelper.Write("CATEGORY CLICK ERROR", $"Category ID {categoryId} not found in AllCategories.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling category click: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerHelper.Write("CATEGORY CLICK ERROR", ex.Message);
            }
        }

        private void ShowSubCategories()
        {
            var subcategories = CurrentSubCategory.AllSubCategories;
            if (subcategories != null && subcategories.Count > 0)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Subcategories:");
                message.AppendLine("-------------------");

                foreach (var subcategory in subcategories)
                {
                    if (subcategory != null && !string.IsNullOrEmpty(subcategory.scName))
                    {
                        message.AppendLine($"• {subcategory.scName}");
                    }
                }

                MessageBox.Show(message.ToString(), "Subcategories List",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No subcategories found for this category.",
                    "Subcategories List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<List<client.Models.Product>> LoadProducts()
        {
            try
            {
                if (await _productController.Get())
                {
                    // Clear the existing controls in the panel
                    pnlContainer.Controls.Clear();

                    // Check if there are products available
                    if (CurrentProduct.AllProduct != null && CurrentProduct.AllProduct.Count > 0)
                    {
                        // Create a display for the products
                        var productDisplay = new CardDisplay(CurrentProduct.AllProduct)
                        {
                            Dock = DockStyle.Fill
                        };
                        pnlContainer.Controls.Add(productDisplay);

                        // Return the list of products
                        return CurrentProduct.AllProduct; // Return the list of products
                    }
                    else
                    {
                        MessageBox.Show("No products available to display.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Return an empty list if no products were loaded or an error occurred
            return new List<client.Models.Product>();
        }

        public void AddCartItem(client.Models.Product product)
        {
            if (cartContainerPanel == null)
            {
                MessageBox.Show("Cart panel is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Control control in cartContainerPanel.Controls)
            {
                if (control is Panel existingCartItem && existingCartItem.Tag is client.Models.Product existingProduct)
                {
                    if (existingProduct.productId == product.productId)
                    {
                        Label? quantityLabel = existingCartItem.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblQuantity");

                        if (quantityLabel != null)
                        {
                            int currentQuantity = int.Parse(quantityLabel.Text.Replace("Qty: ", ""));
                            quantityLabel.Text = $"Qty: {(currentQuantity + 1)}";
                        }
                        return;
                    }
                }
            }

            var cartItem = new Panel
            {
                Width = cartContainerPanel.Width - 30,
                Height = 80,
                BackColor = Color.WhiteSmoke,
                Padding = new Padding(5),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.None,
                Tag = product
            };

            var picProductImage = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 60,
                Height = 60,
                Location = new Point(5, 5),
                Image = product.ProductImageObject ?? Properties.Resources.Add_Image
            };

            var lblProductName = new Label
            {
                Text = product.productName,
                AutoSize = true,
                Location = new Point(75, 5),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                AutoSize = true,
                Location = new Point(75, 25),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Green,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblQuantity = new Label
            {
                Name = "lblQuantity",
                Text = "Qty: 1",
                AutoSize = true,
                Location = new Point(95, 45),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var btnMinus = new Button
            {
                Name = "btnMinus",
                Text = "−",
                Width = 24,
                Height = 24,
                Location = new Point(70, 42),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(214, 192, 179),
                Cursor = Cursors.Hand
            };

            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 170, 160);
            btnMinus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 204, 192);

            var btnPlus = new Button
            {
                Name = "btnPlus",
                Text = "+",
                Width = 24,
                Height = 24,
                Location = new Point(150, 42),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(214, 192, 179),
                Cursor = Cursors.Hand
            };

            // Prevents resizing on click
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 170, 160);
            btnPlus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 204, 192);

            btnPlus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                lblQuantity.Text = $"Qty: {currentQuantity + 1}";
            };

            btnMinus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                if (currentQuantity > 1)
                {
                    lblQuantity.Text = $"Qty: {currentQuantity - 1}";
                }
            };

            var btnRemove = new Button
            {
                Name = "btnRemove",
                Text = "X",
                Width = 25,
                Height = 25,
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand,
                FlatAppearance = { BorderSize = 0 }
            };

            btnRemove.Location = new Point(cartItem.Width - btnRemove.Width - 5, 5);
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnRemove.Click += (s, e) => cartContainerPanel.Controls.Remove(cartItem);

            cartItem.Controls.Add(picProductImage);
            cartItem.Controls.Add(lblProductName);
            cartItem.Controls.Add(lblPrice);
            cartItem.Controls.Add(lblQuantity);
            cartItem.Controls.Add(btnMinus);
            cartItem.Controls.Add(btnPlus);
            cartItem.Controls.Add(btnRemove);

            cartContainerPanel.Controls.Add(cartItem);
        }


        private void btnBeverages_Click(object sender, EventArgs e)
        {

        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {

        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = $"{DateTime.Now.ToString("MMM dd, yyyy")} - {DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("hh:mm:ss tt").ToUpper()}";
        }

        private void OrderEntryForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private Point dragOffset;
        private bool isDragging = false;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragOffset = new Point(e.X, e.Y);
            }
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newLocation.X - dragOffset.X, newLocation.Y - dragOffset.Y);
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
