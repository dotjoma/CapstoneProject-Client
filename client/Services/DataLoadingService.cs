using client.Controllers;
using client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class DataLoadingService
    {
        private readonly ProductController _productController = new ProductController();
        private readonly CategoryController _categoryController = new CategoryController();
        private readonly SubCategoryController _subCategoryController = new SubCategoryController();
        private readonly DiscountController _discountController = new DiscountController();
        private readonly Form _ownerForm;

        public DataLoadingService(Form ownerForm = null!)
        {
            _ownerForm = ownerForm;
        }

        public async Task RefreshDataAsync(Action displayCallback = null!)
        {
            try
            {
                if (_ownerForm != null)
                    _ownerForm.Cursor = Cursors.WaitCursor;

                CurrentProduct.Clear();
                CurrentCategory.Clear();
                CurrentSubCategory.Clear();

                await LoadDataBase();

                displayCallback?.Invoke();
            }
            catch (Exception ex)
            {
                Logger.Write("DATA REFRESH", $"Error refreshing data: {ex.Message}");
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_ownerForm != null)
                    _ownerForm.Cursor = Cursors.Default;
            }
        }

        public async Task RefreshDataOf(string model, Action displayCallback = null!)
        {
            try
            {
                if (_ownerForm != null)
                    _ownerForm.Cursor = Cursors.WaitCursor;

                if (model == "discount")
                {
                    CurrentDiscount.Clear();

                    await LoadTableOf(model);
                }

                displayCallback?.Invoke();
            }
            catch (Exception ex)
            {
                Logger.Write("DATA REFRESH", $"Error refreshing data: {ex.Message}");
                MessageBox.Show($"Error refreshing data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_ownerForm != null)
                    _ownerForm.Cursor = Cursors.Default;
            }
        }

        private async Task LoadDataBase()
        {
            await _productController.GetAllProducts();
            Logger.Write("DATA LOADING", "Successfully loaded products");

            await _categoryController.GetAllCategories();
            Logger.Write("DATA LOADING", "Successfully loaded categories");

            await _subCategoryController.GetAllSubcategory();
            Logger.Write("DATA LOADING", "Successfully loaded subcategories");
        }

        private async Task LoadTableOf(string model)
        {
            if (model == "discount")
            {
                await _discountController.GetAllDiscounts();
                Logger.Write("DATA LOADING", "Successfully loaded discounts");
            }
        }
    }
}
