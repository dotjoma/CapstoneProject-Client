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
using System.Drawing.Drawing2D;
using System.Formats.Tar;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
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
        private readonly TransactionController _transactionController = new TransactionController();

        private System.Threading.Timer? searchTimer;
        private string lastSearchText = string.Empty;
        private readonly int searchDelayMs = 300;

        private bool isTransactionActive = false;

        public static OrderEntryForm? Instance { get; private set; }

        private decimal _subTotal = 0;
        private decimal totalAmount = 0;
        private string orderType = "Dine-In";

        private Button activeButton = new Button();

        public OrderEntryForm()
        {
            InitializeComponent();
            Instance = this;
            this.FormClosed += OrderEntryForm_FormClosed;
            this.KeyPreview = true;
            this.KeyDown += OrderEntryForm_KeyDown;
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

            AppliedDiscount.OnDiscountChanged += UpdateDiscount;
            PaymentForm.PostPaymentProcess += ManagePostPayment;
        }


        decimal VATAmount = 0; // 12%
        decimal saleWoVAT = 0;
        decimal lessDiscount = 0; // PWD/Senior discount usually 20%
        private decimal _discountAmount = 0;
        private decimal _totalDue = 0;
        private void UpdateDiscount(decimal updatedDiscount)
        {
            if (AppliedDiscount.DiscountType.ToString() == "Percentage")
            {
                decimal vatableSales = 0m;
                decimal vatAmount = 0m;
                decimal discountAmount = 0m;

                vatableSales = _subTotal / 1.12m;
                vatAmount = _subTotal - vatableSales;
                discountAmount = vatableSales * updatedDiscount;
                _totalDue = vatableSales - discountAmount;

                saleWoVAT = vatableSales;
                VATAmount = vatAmount;
                lessDiscount = discountAmount;
                _discountAmount = discountAmount;

                lblSubTotal.Text = _subTotal.ToString("F2");
                lblTotalDue.Text = _totalDue.ToString("F2");
                lblVatable.Text = vatableSales.ToString("F2");
                lblVatAmount.Text = vatAmount.ToString("F2");
                lblDiscount.Text = discountAmount.ToString("F2");
            }
        }

        private void UpdateSubTotal()
        {
            decimal vatableSales = _subTotal / 1.12m;
            decimal vat = _subTotal - vatableSales;
            totalAmount = _subTotal;
            _totalDue = _subTotal;

            VATAmount = vat;
            saleWoVAT = vatableSales;
            lessDiscount = saleWoVAT * _discountAmount;

            lblSubTotal.Text = _subTotal.ToString("F2");
            lblTotalDue.Text = _subTotal.ToString("F2");
            lblVatable.Text = vatableSales.ToString("F2");
            lblVatAmount.Text = VATAmount.ToString("F2");
            lblDiscount.Text = _discountAmount.ToString("F2");
        }

        private async void OrderEntryForm_Load(object sender, EventArgs e)
        {
            DataCache.ShouldRefreshCategories = true;
            this.WindowState = FormWindowState.Maximized;

            ToggleButton(false);

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
                Logger.Write("LOAD ERROR", ex.Message);
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

            Button allMenusButton = new Button
            {
                Text = "All Menus",
                Height = buttonHeight,
                Width = categoriesPanel.Width - 10,
                Margin = new Padding(buttonMargin, buttonMargin, 0, buttonMargin),
                Tag = -1,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                Cursor = Cursors.Hand,
                TabStop = false
            };

            allMenusButton.FlatAppearance.BorderSize = 2;
            allMenusButton.FlatAppearance.BorderColor = Color.Gray;

            allMenusButton.MouseEnter += (s, e) =>
            {
                if (s is Button btn)
                {
                    btn.BackColor = Color.LightGray;
                }
            };

            allMenusButton.MouseLeave += (s, e) =>
            {
                if (s is Button btn)
                {
                    btn.BackColor = Color.White;
                }
            };

            allMenusButton.Click += (sender, e) =>
            {
                categoriesPanel.Focus();
                subCategoriesPanel.Controls.Clear();
                CurrentCategory.SetCurrentCategory(null);
                LoadProducts();
            };

            categoriesPanel.Controls.Add(allMenusButton);

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
                Button allButton = new Button
                {
                    Text = "All",
                    Height = buttonHeight,
                    Width = 80,
                    Margin = new Padding(buttonMargin),
                    Tag = -1,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    Font = buttonFont,
                    Cursor = Cursors.Hand,
                    TabStop = false
                };

                allButton.FlatAppearance.BorderSize = 2;
                allButton.FlatAppearance.BorderColor = Color.Gray;

                allButton.MouseEnter += (s, e) =>
                {
                    if (s is Button btn)
                    {
                        btn.BackColor = Color.LightGray;
                    }
                };

                allButton.MouseLeave += (s, e) =>
                {
                    if (s is Button btn)
                    {
                        btn.BackColor = Color.White;
                    }
                };

                allButton.Click += (sender, e) =>
                {
                    subCategoriesPanel.Focus();
                    if (CurrentCategory.Current != null)
                    {
                        DisplayProductsByCategory(CurrentCategory.Current.Id);
                    }
                };

                subCategoriesPanel.Controls.Add(allButton);
                totalWidth += allButton.Width + buttonMargin;

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
                                DisplayProductsBySubcategory(subCategoryId);
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

        private void DisplayProductsBySubcategory(int subcategoryId)
        {
            try
            {
                if (CurrentProduct.AllProduct == null || !CurrentProduct.AllProduct.Any())
                {
                    MessageBox.Show("No products available.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var filteredProducts = CurrentProduct.AllProduct
                    .Where(p => p.subcategoryId == subcategoryId)
                    .ToList();

                pnlContainer.Controls.Clear();

                if (filteredProducts.Any())
                {
                    var productDisplay = new CardDisplay(filteredProducts)
                    {
                        Dock = DockStyle.Fill
                    };
                    pnlContainer.Controls.Add(productDisplay);
                }
                else
                {
                    var noResultsLabel = new Label
                    {
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 12, FontStyle.Regular),
                        ForeColor = Color.Gray
                    };

                    noResultsLabel.Paint += (s, e) =>
                    {
                        if (s is Label label)
                        {
                            e.Graphics.Clear(pnlContainer.BackColor);

                            string normalText = "No products found in";
                            string boldText = CurrentSubCategory.GetSubcategoryNameById(subcategoryId) + ".";

                            Font normalFont = label.Font;
                            Font boldFont = new Font(normalFont, FontStyle.Bold);

                            float normalWidth = e.Graphics.MeasureString(normalText, normalFont).Width;
                            float boldWidth = e.Graphics.MeasureString(boldText, boldFont).Width;
                            float totalWidth = normalWidth + boldWidth;

                            float normalHeight = e.Graphics.MeasureString(normalText, normalFont).Height;
                            float boldHeight = e.Graphics.MeasureString(boldText, boldFont).Height;
                            float totalHeight = Math.Max(normalHeight, boldHeight);

                            float startX = (label.Width - totalWidth) / 2;
                            float startY = (label.Height - totalHeight) / 2;

                            e.Graphics.DrawString(normalText, normalFont, new SolidBrush(label.ForeColor), new PointF(startX, startY));
                            e.Graphics.DrawString(boldText, boldFont, new SolidBrush(label.ForeColor), new PointF(startX + normalWidth, startY));
                        }
                    };

                    Panel centerPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        BackColor = pnlContainer.BackColor
                    };

                    centerPanel.Controls.Add(noResultsLabel);
                    pnlContainer.Controls.Add(centerPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("DISPLAY ERROR", ex.Message);
            }
        }

        private void DisplayProductsByCategory(int categoryId)
        {
            try
            {
                if (CurrentProduct.AllProduct == null || !CurrentProduct.AllProduct.Any())
                {
                    MessageBox.Show("No products available.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var filteredProducts = CurrentProduct.AllProduct
                    .Where(p => p.categoryId == categoryId)
                    .ToList();

                pnlContainer.Controls.Clear();

                if (filteredProducts.Any())
                {
                    var productDisplay = new CardDisplay(filteredProducts)
                    {
                        Dock = DockStyle.Fill
                    };
                    pnlContainer.Controls.Add(productDisplay);
                }
                else
                {
                    var noResultsLabel = new Label
                    {
                        Text = "No products found in this category.",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 12, FontStyle.Regular),
                        ForeColor = Color.Gray
                    };

                    pnlContainer.Controls.Add(noResultsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("DISPLAY ERROR", ex.Message);
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
                        Logger.Write("SUBCATEGORY INFO", $"No subcategories found for category ID: {categoryId}");
                        subCategoriesPanel.Controls.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Selected category not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.Write("CATEGORY CLICK ERROR", $"Category ID {categoryId} not found in AllCategories.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling category click: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("CATEGORY CLICK ERROR", ex.Message);
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
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _subTotal += product.productPrice;
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
                Width = 80,
                Height = 70,
                Location = new Point(5, 5),
                Image = product.ProductImageObject ?? Properties.Resources.Add_Image
            };

            int textStartX = picProductImage.Width + 10;

            var lblProductName = new Label
            {
                Text = product.productName,
                AutoSize = true,
                Location = new Point(textStartX, 5),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblPrice = new Label
            {
                Text = "₱ " + product.productPrice.ToString("F2"),
                AutoSize = true,
                Location = new Point(textStartX, 30),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Green,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var lblQuantity = new Label
            {
                Name = "lblQuantity",
                Text = "Qty: 1",
                AutoSize = true,
                Location = new Point(textStartX + 30, 55),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var btnMinus = new Button
            {
                Name = "btnMinus",
                Text = "−",
                Width = 24,
                Height = 24,
                Location = new Point(textStartX, 52),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
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
                Location = new Point(textStartX + 90, 52),
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
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

                    _subTotal -= product.productPrice;
                    CurrentCart.UpdateItemQuantity(product.productId, currentQuantity - 1);
                    UpdateSubTotal();

                    if (AppliedDiscount.DiscountedItems.ContainsKey(product.productId))
                    {
                        AppliedDiscount.DecrementDiscount(product.productId);
                    }
                }
            };

            btnPlus.Click += (sender, e) =>
            {
                int currentQuantity = int.Parse(lblQuantity.Text.Replace("Qty: ", ""));
                lblQuantity.Text = $"Qty: {currentQuantity + 1}";

                _subTotal += product.productPrice;
                CurrentCart.UpdateItemQuantity(product.productId, currentQuantity + 1);
                UpdateSubTotal();

                if (AppliedDiscount.DiscountedItems.ContainsKey(product.productId))
                {
                    AppliedDiscount.IncrementDiscount(product.productId);
                }
                else
                {
                    AppliedDiscount.AddDiscount(product.productId, product.productPrice, 1);
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
                    _subTotal -= product.productPrice * currentQuantity;
                }

                UpdateSubTotal();
                CurrentCart.RemoveItem(product.productId);
                AppliedDiscount.RemoveDiscount(product.productId);

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

        private void ForceResetTransaction()
        {
            ShowLoading("Closing transaction...");
            RemoveTransaction();
        }

        private void CloseWindow()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IsTransactionActive())
                {
                    ForceResetTransaction();
                    Task.Delay(500);
                }

                Environment.Exit(0);
            }
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
            if (IsTransactionActive())
            {
                ForceResetTransaction();
            }

            NavigateToDashboard();
        }

        private void NavigateToDashboard()
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
            if (IsCartEmpty())
            {
                MessageBox.Show("The cart is empty, Please add item to the cart first.",
                    "Cart Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //new ApplyDiscount().ShowDialog(); // The last discount calculation is not correct.
            new DiscountForm(_subTotal).ShowDialog();
        }

        private void txtSearchInput_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchInput.Text.Trim();

            lastSearchText = searchText;

            searchTimer?.Dispose();

            searchTimer = new System.Threading.Timer(
                _ => PerformSearch(searchText),
                null,
                searchDelayMs,
                Timeout.Infinite
            );
        }

        private void PerformSearch(string searchText)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => PerformSearch(searchText)));
                return;
            }

            if (searchText != lastSearchText)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    if (CurrentCategory.Current != null)
                    {
                        DisplayProductsByCategory(CurrentCategory.Current.Id);
                    }
                    else
                    {
                        LoadProducts();
                    }
                    return;
                }

                searchText = searchText.ToLower();

                if (CurrentProduct.AllProduct == null || !CurrentProduct.AllProduct.Any())
                {
                    MessageBox.Show("No products available to search.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var filteredProducts = CurrentProduct.AllProduct
                    .Where(p => p.productName != null && p.productName.ToLower().Contains(searchText))
                    .ToList();

                pnlContainer.Controls.Clear();

                if (filteredProducts.Any())
                {
                    var productDisplay = new CardDisplay(filteredProducts)
                    {
                        Dock = DockStyle.Fill
                    };
                    pnlContainer.Controls.Add(productDisplay);
                }
                else
                {
                    var noResultsLabel = new Label
                    {
                        Text = "No products found matching your search.",
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 12, FontStyle.Regular),
                        ForeColor = Color.Gray
                    };

                    pnlContainer.Controls.Add(noResultsLabel);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("SEARCH ERROR", ex.Message);
            }
        }

        private async void btnNewOrder_Click(object sender, EventArgs e)
        {
            isTransactionActive = true;
            await StartNewTransaction();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (IsCartEmpty())
            {
                MessageBox.Show("Please add items to the cart first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var paymentForm = new PaymentForm(_totalDue, orderType,_discountAmount);
            paymentForm.ShowDialog();
        }

        private async Task StartNewTransaction()
        {
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!IsCartEmpty())
            {
                if (MessageBox.Show(
                    "Are you sure you want to create a new transaction? All changes will be discarded.",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes)
                {
                    RefreshTransaction();
                }
                else
                {
                    return;
                }
            }

            btnNewOrder.Enabled = false;
            ShowLoading("Starting new transaction...");

            var numbers = await _transactionController.GenerateTransactionNumbers();
            if (numbers != null)
            {
                string? transNumber = numbers.TransNumber;
                string? orderNumber = numbers.OrderNumber;

                lblTransactionNo.Text = transNumber;
                lblOrderNo.Text = orderNumber;
                SetActiveButton(btnDineIn);
                UpdateOrderType("Dine-In");

                ToggleButton(true);

                HideLoading();
                btnNewOrder.Enabled = true;

                Logger.Write("NEW TRANSACTION",
                    $"Started new transaction: {transNumber}, Order: {orderNumber}");
            }
            else
            {
                MessageBox.Show(
                    "Failed to start new transaction. Please try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                ToggleButton(false);
                HideLoading();
                btnNewOrder.Enabled = true;
            }
        }

        private bool IsCartEmpty()
        {
            return cartContainerPanel.Controls.Count <= 0;
        }

        private bool IsTransactionActive()
        {
            if (!isTransactionActive)
            {
                return false;
            }

            return true;
        }

        private void RefreshTransaction()
        {
            _subTotal = 0;
            totalAmount = 0;
            _totalDue = 0;
            _discountAmount = 0;
            VATAmount = 0;
            saleWoVAT = 0;
            lessDiscount = 0;

            lblOrderNo.Text = string.Empty;
            lblTransactionNo.Text = string.Empty;
            lblSubTotal.Text = "0.00";
            lblTotalDue.Text = "0.00";
            lblVatable.Text = "0.00";
            lblVatAmount.Text = "0.00";
            lblDiscount.Text = "0.00";

            CurrentCart.ClearCart();
            CurrentTransaction.Clear();

            cartContainerPanel.Controls.Clear();
            RemoveActiveButton();

            UpdateSubTotal();
        }

        private void ResetTransaction()
        {
            if (!IsCartEmpty())
            {
                var confirmCancel = MessageBox.Show(
                    "Are you sure you want to cancel the transaction? All changes will be discarded.",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmCancel != DialogResult.Yes)
                    return;
            }

            ShowLoading("Cancelling transaction...");
            RemoveTransaction();
            isTransactionActive = false;
        }

        private void ToggleButton(Boolean tog)
        {
            btnHoldOrder.Enabled = tog;
            btnPendingOrders.Enabled = tog;
            btnApplyDiscount.Enabled = tog;
            btnCancelTransaction.Enabled = tog;
            btnPayment.Enabled = tog;
            btnDineIn.Enabled = tog;
            btnTakeOut.Enabled = tog;
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            ResetTransaction();
        }

        private void OrderEntryForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnNewOrder.PerformClick();
                    break;
                case Keys.Enter:
                    btnPayment.PerformClick();
                    break;
                case Keys.F3:
                    btnApplyDiscount.PerformClick();
                    break;
                case Keys.F4:
                    btnCancelTransaction.PerformClick();
                    break;
                case Keys.F5:
                    btnHoldOrder.PerformClick();
                    break;
                case Keys.F6:
                    btnPendingOrders.PerformClick();
                    break;
            }
        }

        private async void RemoveTransaction()
        {
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string transNum = CurrentTransaction.Current!.TransNumber!;
            var res = await _transactionController.RemoveTransaction(transNum);
            if (res)
            {
                Logger.Write("TRANSACTION REMOVED", $"Transaction {transNum} removed.");
                RefreshTransaction();
                HideLoading();
                ToggleButton(false);
                AppliedDiscount.Clear();
                isTransactionActive = false;
            }
            else
            {
                MessageBox.Show("Failed to remove transaction.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Write("TRANSACTION REMOVAL ERROR", $"Failed to remove transaction {transNum}.");
                HideLoading();
                ToggleButton(false);
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

        private void SetActiveButton(Button? clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = SystemColors.Control;
                activeButton.ForeColor = Color.Black;
            }

            activeButton = clickedButton!;
            activeButton.BackColor = Color.FromArgb(141, 110, 99);
            activeButton.ForeColor = Color.White;
        }

        private void RemoveActiveButton()
        {
            if (activeButton != null)
            {
                orderType = "Dine-In";
                lblOrderType.Text = string.Empty;
                activeButton.BackColor = SystemColors.Control;
                activeButton.ForeColor = Color.Black;
            }
        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            SetActiveButton(sender as Button);
            UpdateOrderType("Dine-In");
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            if (!IsTransactionActive())
            {
                MessageBox.Show("Please start a new transaction first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SetActiveButton(sender as Button);
            UpdateOrderType("Take-Out");
        }

        private void UpdateOrderType(string type)
        {
            orderType = type;
            lblOrderType.Text = (type == "Dine-In") ? "DINE IN" : "TAKE OUT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Discount: {AppliedDiscount.TotalDiscount.ToString("F2")}", "Discount Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ManagePostPayment()
        {
            // TODO:
            // Generate Receipt.
            // Update Inventory.
            ResetPOSAfterPayment(true);
        }
        public void ResetPOSAfterPayment(bool transactionSuccess)
        {
            try
            {
                // Clear current order data
                CurrentOrder.Clear();
                CurrentCart.ClearCart();

                // Release hardware resources
                // cash drawer, thermal printer etc

                // UI Reset
                this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                {
                    RefreshTransaction();
                    ToggleButton(false);
                });

                if (IsTransactionActive()) isTransactionActive = false;

                // SAFE orderId parsing - fixed version
                int orderId = 0;
                try
                {
                    if (CurrentOrder.Current?.orderId != null)
                    {
                        if (int.TryParse(CurrentOrder.Current.orderId.ToString(), out int parsedId))
                        {
                            orderId = parsedId;
                        }
                    }
                }
                catch { /* Silently handle any parse errors */ }

                // Log cleanup completion
                Logger.LogPOSEvent(
                    eventType: "SystemReset",
                    details: $"After {(transactionSuccess ? "successful" : "failed")} payment",
                    orderId: orderId
                );

                if (ShouldPerformMaintenance())
                {
                    PerformScheduledCleanup();
                }
            }
            catch (Exception ex)
            {
                Logger.Write("RESET FAILURE", ex.Message);
            }
        }

        private bool ShouldPerformMaintenance()
        {
            bool isOffPeak = DateTime.Now.Hour < 8 || DateTime.Now.Hour > 21;

            //return isOffPeak &&
            //      (TransactionCounter.DailyCount > 1000 ||
            //       MemoryMonitor.IsHighUsage);

            return isOffPeak;
        }

        private void PerformScheduledCleanup()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Optimized);
            //DatabaseConnectionPool.CleanIdleConnections();
            //TempFileCleaner.Run();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
