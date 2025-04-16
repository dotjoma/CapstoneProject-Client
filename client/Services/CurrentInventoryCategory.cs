using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventoryCategory
    {
        private static InventoryCategory? _currentInventoryCategory;
        private static List<InventoryCategory> _allInventoryCategories = new List<InventoryCategory>();

        public static InventoryCategory? Current => _currentInventoryCategory;
        public static List<InventoryCategory> AllInventoryCategories => _allInventoryCategories;

        public static void SetInventoryCategories(List<InventoryCategory> categories)
        {
            _allInventoryCategories = categories ?? new List<InventoryCategory>();
            _currentInventoryCategory = null;
        }

        public static void SetCurrenInventorytCategory(InventoryCategory? category)
        {
            _currentInventoryCategory = category;
        }

        public static InventoryCategory? GetCategoryById(int categoryId)
        {
            return _allInventoryCategories.FirstOrDefault(c => c.Id == categoryId);
        }

        public static void Clear()
        {
            _currentInventoryCategory = null;
            _allInventoryCategories.Clear();
        }
    }
}
