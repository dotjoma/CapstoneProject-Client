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
        private static Dictionary<int, List<SubCategory>> _categorySubcategoriesCache = new Dictionary<int, List<SubCategory>>();

        public static SubCategory? Current => _currentSubCategory;
        public static List<SubCategory> AllSubCategories => _allSubCategories;

        public static void SetSubCategories(List<SubCategory> subCategories)
        {
            _allSubCategories = subCategories ?? new List<SubCategory>();

            foreach (var subcategory in _allSubCategories.Where(sc => sc != null))
            {
                if (!_categorySubcategoriesCache.ContainsKey(subcategory.catId))
                {
                    _categorySubcategoriesCache[subcategory.catId] = new List<SubCategory>();
                }
                if (!_categorySubcategoriesCache[subcategory.catId].Any(sc => sc.scId == subcategory.scId))
                {
                    _categorySubcategoriesCache[subcategory.catId].Add(subcategory);
                }
            }

            _currentSubCategory = null;
        }

        public static void SetCurrentSubCategory(SubCategory? subCategory)
        {
            _currentSubCategory = subCategory;
        }

        public static SubCategory? GetSubategoryById(int subcategoryId)
        {
            foreach (var subcategories in _categorySubcategoriesCache.Values)
            {
                var found = subcategories.FirstOrDefault(sc => sc.scId == subcategoryId);
                if (found != null) return found;
            }

            return _allSubCategories.FirstOrDefault(c => c.scId == subcategoryId);
        }

        public static string GetSubcategoryNameById(int subcategoryId)
        {
            var subCategory = GetSubategoryById(subcategoryId);
            return subCategory?.scName ?? "Unknown Subcategory";
        }

        public static List<SubCategory> GetSubcategoriesByCategoryId(int categoryId)
        {
            if (_categorySubcategoriesCache.ContainsKey(categoryId))
            {
                var cachedResults = _categorySubcategoriesCache[categoryId];
                if (cachedResults.Any())
                {
                    return cachedResults;
                }
            }

            var results = _allSubCategories
                .Where(sc => sc != null && sc.catId == categoryId)
                .ToList();

            if (results.Any())
            {
                _categorySubcategoriesCache[categoryId] = results;
                return results;
            }

            return new List<SubCategory>();
        }

        public static void Clear()
        {
            _currentSubCategory = null;
            _allSubCategories.Clear();
            _categorySubcategoriesCache.Clear();
        }

        public static void RefreshCache()
        {
            _categorySubcategoriesCache.Clear();
            foreach (var subcategory in _allSubCategories.Where(sc => sc != null))
            {
                if (!_categorySubcategoriesCache.ContainsKey(subcategory.catId))
                {
                    _categorySubcategoriesCache[subcategory.catId] = new List<SubCategory>();
                }
                if (!_categorySubcategoriesCache[subcategory.catId].Any(sc => sc.scId == subcategory.scId))
                {
                    _categorySubcategoriesCache[subcategory.catId].Add(subcategory);
                }
            }
        }
    }
}
