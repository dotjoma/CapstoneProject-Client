using client.Controllers;
using client.Controls.Products;
using client.Helpers;
using client.Models;
using client.Services;
using client.Services.Auth;
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
        private readonly AuthController _authController = new AuthController();

        public static OrderEntryForm? Instance { get; private set; }

        private decimal subTotal = 0;
        //private decimal discount = 0;

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
                    AutoScroll = true,
                    WrapContents = false,
                    FlowDirection = FlowDirection.TopDown
                };
                cartPanel.Controls.Add(cartContainerPanel);
            }
        }

        private async void OrderEntryForm_Load(object sender, EventArgs e)
        {
            DataCache.ShouldRefreshCategories = true;
            this.WindowState = FormWindowState.Maximized;

            btnHome.Visible = (CurrentUser.IsAdmin) ? true : false;

            string? username = CurrentUser.Current?.Username;
            string role = (CurrentUser.Current?.Role) == "admin" ? "Administrator" : "Cashier";
            lblUser.Text = $"{char.ToUpper(username![0]) + username.Substring(1)} ({role})";

            timer1.Start();
            await InitializeData();
        }

        private async Task InitializeData()
        {
            try
            {
                LoadProducts();

                CreateCategoryButtons();

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

        private void CreateCategoryButtons()
        {
            categoriesPanel.Controls.Clear();

            categoriesPanel.AutoScroll = true;
            categoriesPanel.WrapContents = false;
            categoriesPanel.FlowDirection = FlowDirection.TopDown;
            categoriesPanel.HorizontalScroll.Enabled = false;
            categoriesPanel.HorizontalScroll.Visible = true;

            int buttonMargin = 5;
            int buttonHeight = 40;

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
                            Height = buttonHeight,
                            Width = categoriesPanel.Width - 10,
                            Margin = new Padding(buttonMargin, buttonMargin, 0, buttonMargin),
                            Tag = category.Id,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                            Font = new Font("Segoe UI", 11, FontStyle.Regular),
                            Cursor = Cursors.Hand,
                            TabStop = false
                        };

                        categoryButton.FlatAppearance.BorderSize = 2;
                        categoryButton.FlatAppearance.BorderColor = Color.Gray;

                        //ToolTip toolTip = new ToolTip();
                        //toolTip.InitialDelay = 50;
                        //toolTip.SetToolTip(categoryButton, category.Name);

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

                        categoryButton.Click += (sender, e) =>
                        {
                            if (sender is Button button && button.Tag is int categoryId)
                            {
                                categoriesPanel.Focus();
                                HandleCategoryClick(categoryId);
                            }
                        };

                        categoriesPanel.Controls.Add(categoryButton);
                    }
                }
            }
        }

        private void CreateSubCategoryButtons(List<SubCategory> subcategories)
        {
            subCategoriesPanel.Controls.Clear();
            subCategoriesPanel.AutoScroll = false;
            subCategoriesPanel.WrapContents = false;
            subCategoriesPanel.FlowDirection = FlowDirection.LeftToRight;

            int buttonMargin = 5;
            int buttonHeight = 40;
            int paddingWidth = 20;
            Font buttonFont = new Font("Segoe UI", 10, FontStyle.Regular);

            int totalWidth = 0;

            if (subcategories != null && subcategories.Count > 0)
            {
                foreach (var subCategory in subcategories)
                {
                    if (subCategory != null && !string.IsNullOrEmpty(subCategory.scName))
                    {
                        int textWidth = TextRenderer.MeasureText(subCategory.scName, buttonFont).Width + paddingWidth;

                        Button subCategoryButton = new Button
                        {
                            Text = subCategory.scName,
                            Height = buttonHeight,
                            Width = Math.Max(textWidth, 100),
                            Margin = new Padding(buttonMargin),
                            Tag = subCategory.scId,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.White,
                            ForeColor = Color.Black,
                            Font = buttonFont,
                            Cursor = Cursors.Hand
                        };

                        subCategoryButton.FlatAppearance.BorderSize = 2;
                        subCategoryButton.FlatAppearance.BorderColor = Color.Gray;

                        subCategoryButton.MouseEnter += (s, e) =>
                        {
                            if (s is Button btn)
                            {
                                btn.BackColor = Color.LightGray;
                            }
                        };

                        subCategoryButton.MouseLeave += (s, e) =>
                        {
                            if (s is Button btn)
                            {
                                btn.BackColor = Color.White;
                            }
                        };

                        subCategoryButton.Click += (sender, e) =>
                        {
                            if (sender is Button button && button.Tag is int subCategoryId)
                            {
                                subCategoriesPanel.Focus();
                                MessageBox.Show("Coming Soon.");
                            }
                        };

                        subCategoriesPanel.Controls.Add(subCategoryButton);
                        totalWidth += subCategoryButton.Width + buttonMargin;
                    }
                }

                subCategoriesPanel.AutoScroll = true;
                subCategoriesPanel.HorizontalScroll.Enabled = true;
                subCategoriesPanel.HorizontalScroll.Visible = true;

                subCategoriesPanel.Width = subCategoryPanel.ClientSize.Width - 10;

                AdjustSubCategoriesPanelHeight();
            }
            else
            {
                MessageBox.Show("No subcategories found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdjustSubCategoriesPanelHeight()
        {
            int defaultHeight = 55;
            int subCategoryPanelMinHeight = 62;
            int subCategoryPanelMaxHeight = 150;

            subCategoriesPanel.Height = defaultHeight;

            if (subCategoriesPanel.HorizontalScroll.Visible)
            {
                int scrollbarHeight = SystemInformation.HorizontalScrollBarHeight;
                int subCategoryContentHeight = subCategoryPanel.Controls.Cast<Control>().Sum(c => c.Height + c.Margin.Vertical);
                subCategoryPanel.Height = Math.Clamp(
                    subCategoryContentHeight + subCategoryPanel.Padding.Vertical + (subCategoryPanel.HorizontalScroll.Visible ? scrollbarHeight : 0),
                    subCategoryPanelMinHeight,
                    subCategoryPanelMaxHeight
                );

                int subCategoriesContentHeight = subCategoryPanel.Height + subCategoriesPanel.Padding.Vertical;
                subCategoriesPanel.Height = Math.Clamp(
                    subCategoriesContentHeight + (subCategoriesPanel.HorizontalScroll.Visible ? scrollbarHeight : 0),
                    55,
                    65
                );

                subCategoryPanel.Height = Math.Clamp(
                    subCategoriesPanel.Height + subCategoryPanel.Padding.Vertical + (subCategoryPanel.HorizontalScroll.Visible ? scrollbarHeight : 0),
                    subCategoryPanelMinHeight,
                    subCategoryPanelMaxHeight
                );
            }
            else
            {
                subCategoryPanel.Height = subCategoryPanelMinHeight;
            }
        }

        private void HandleCategoryClick(int categoryId)
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

                    var subcategories = CurrentSubCategory.GetSubcategoriesByCategoryId(categoryId);

                    if (subcategories.Any())
                    {
                        CreateSubCategoryButtons(subcategories);
                    }
                    else
                    {
                        MessageBox.Show("No subcategories found for this category.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoggerHelper.Write("SUBCATEGORY INFO", $"No subcategories found for category ID: {categoryId}");
                        subCategoriesPanel.Controls.Clear();
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

        private List<Product> LoadProducts()
        {
            try
            {
                pnlContainer.Controls.Clear();

                if (CurrentProduct.AllProduct != null && CurrentProduct.AllProduct.Count > 0)
                {
                    var productDisplay = new CardDisplay(CurrentProduct.AllProduct)
                    {
                        Dock = DockStyle.Fill
                    };
                    pnlContainer.Controls.Add(productDisplay);

                    return CurrentProduct.AllProduct;
                }
                else
                {
                    MessageBox.Show("No products available to display.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<Product>();
        }

        private void AddProductToCart(Product product)
        {
            var existingItem = CurrentCart.Items.FirstOrDefault(p => p.productId == product.productId);

            if (existingItem != null)
            {
                existingItem.Quantity += 1;
            }
            else
            {
                var cartItem = new CartItem()
                {
                    productId = product.productId,
                    productName = product.productName,
                    productPrice = product.productPrice,
                    Quantity = 1
                };

                CurrentCart.AddItem(cartItem);
            }
        }

        public void AddCartItem(Product product)
        {
            subTotal += product.productPrice;
            UpdateSubTotal();

            AddProductToCart(product);

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
                Width = GetCartItemWidth(),
                Height = 80,
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.None,
                Tag = product
            };

            int GetCartItemWidth()
            {
                return cartContainerPanel.ClientSize.Width - 10;
            }

            cartContainerPanel.SizeChanged += (s, e) =>
            {
                foreach (Control control in cartContainerPanel.Controls)
                {
                    if (control is Panel panel)
                    {
                        panel.Width = GetCartItemWidth();
                        var removeButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "btnRemove");
                        if (removeButton != null)
                        {
                            removeButton.Location = new Point(panel.Width - removeButton.Width - 5, 5);
                        }
                    }
                }
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
                Cursor = Cursors.Hand,
                TabStop = false
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
                Cursor = Cursors.Hand,
                TabStop = false
            };

            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 170, 160);
            btnPlus.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 204, 192);

            btnMinus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                if (currentQuantity > 1)
                {
                    lblQuantity.Text = $"Qty: {currentQuantity - 1}";

                    subTotal -= product.productPrice;
                    CurrentCart.UpdateItemQuantity(product.productId, currentQuantity - 1);
                    UpdateSubTotal();
                }
            };

            btnPlus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                lblQuantity.Text = $"Qty: {currentQuantity + 1}";

                subTotal += product.productPrice;
                CurrentCart.UpdateItemQuantity(product.productId, currentQuantity + 1);
                UpdateSubTotal();
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
                FlatAppearance = { BorderSize = 0 },
                TabStop = false
            };

            btnRemove.Location = new Point(cartItem.Width - btnRemove.Width - 5, 5);
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnRemove.Click += (s, e) =>
            {
                Label? quantityLabel = cartItem.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblQuantity");

                if (quantityLabel != null)
                {
                    int currentQuantity = int.Parse(quantityLabel.Text.Replace("Qty: ", ""));
                    subTotal -= product.productPrice * currentQuantity;
                }

                UpdateSubTotal();
                CurrentCart.RemoveItem(product.productId);
                cartContainerPanel.Controls.Remove(cartItem);
            };

            cartItem.Controls.Add(picProductImage);
            cartItem.Controls.Add(lblProductName);
            cartItem.Controls.Add(lblPrice);
            cartItem.Controls.Add(lblQuantity);
            cartItem.Controls.Add(btnMinus);
            cartItem.Controls.Add(btnPlus);
            cartItem.Controls.Add(btnRemove);

            cartContainerPanel.Controls.Add(cartItem);
        }

        private void UpdateSubTotal()
        {
            decimal vatableSales = subTotal / 1.12m;
            decimal vat = subTotal - vatableSales;
            decimal total = subTotal;

            lblSubTotal.Text = subTotal.ToString("F2");
            lblVatable.Text = vatableSales.ToString("F2");
            lblVat.Text = vat.ToString("F2");
            lblTotal.Text = total.ToString("F2");
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

        private void OrderEntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
            CurrentCart.ClearCart();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authController.Logout();
            CurrentCart.ClearCart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {

        }
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.WhiteSmoke;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            new ApplyDiscount().ShowDialog();
        }
    }
}
