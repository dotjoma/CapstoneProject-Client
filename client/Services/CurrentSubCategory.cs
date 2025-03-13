using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentSubCategory
    {
        private static SubCategory? _currentSubCategory;
        private static List<SubCategory> _allSubCategories = new List<SubCategory>();

        public static SubCategory? Current => _currentSubCategory;
        public static List<SubCategory> AllSubCategories => _allSubCategories;

        public static void SetSubCategories(List<SubCategory> subCategories)
        {
            _allSubCategories = subCategories ?? new List<SubCategory>();
            _currentSubCategory = null;
        }

        public static void SetCurrentSubCategory(SubCategory? subCategory)
        {
            _currentSubCategory = subCategory;
        }

        public static SubCategory? GetSubategoryById(int subcategoryId)
        {
            return _allSubCategories.FirstOrDefault(c => c.scId == subcategoryId);
        }

        public static List<SubCategory> GetSubcategoriesByCategoryId(int categoryId)
        {
            if (_allSubCategories == null)
                return new List<SubCategory>();

            return _allSubCategories
                .Where(sc => sc != null && sc.catId == categoryId)
                .ToList();
        }

        public static void Clear()
        {
            _currentSubCategory = null;
            _allSubCategories.Clear();
        }
    }
}
