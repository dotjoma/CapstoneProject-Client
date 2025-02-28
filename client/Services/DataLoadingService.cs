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
        private readonly ProductController _productController;
        private readonly CategoryController _categoryController;
        private readonly SubCategoryController _subCategoryController;
        private readonly Form _ownerForm;

        public DataLoadingService(Form ownerForm = null!)
        {
            _productController = new ProductController();
            _categoryController = new CategoryController();
            _subCategoryController = new SubCategoryController();
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
                LoggerHelper.Write("DATA REFRESH", $"Error refreshing data: {ex.Message}");
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
            LoggerHelper.Write("DATA LOADING", "Successfully loaded products");

            await _categoryController.GetAllCategories();
            LoggerHelper.Write("DATA LOADING", "Successfully loaded categories");

            await _subCategoryController.GetAllSubcategory();
            LoggerHelper.Write("DATA LOADING", "Successfully loaded subcategories");
        }
    }
}
