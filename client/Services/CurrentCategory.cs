using client.Models;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentCategory
    {
        private static Category? _currentCategory;
        private static List<Category> _allCategories = new List<Category>();

        public static Category? Current => _currentCategory;
        public static List<Category> AllCategories => _allCategories;

        public static void SetCategories(List<Category> categories)
        {
            _allCategories = categories ?? new List<Category>();
            _currentCategory = null;
        }

        public static void SetCurrentCategory(Category? category)
        {
            _currentCategory = category;
        }

        public static Category? GetCategoryById(int categoryId)
        {
            return _allCategories.FirstOrDefault(c => c.Id == categoryId);
        }

        public static void Clear()
        {
            _currentCategory = null;
            _allCategories.Clear();
        }
    }
}
