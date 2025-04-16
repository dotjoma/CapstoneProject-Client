using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventorySubCategory
    {
        private static InventorySubCategory? _currentInventorySubCategory;
        private static List<InventorySubCategory> _allInventorySubCategories = new List<InventorySubCategory>();
        private static Dictionary<int, List<InventorySubCategory>> _categorySubcategoriesCache = new Dictionary<int, List<InventorySubCategory>>();

        public static InventorySubCategory? Current => _currentInventorySubCategory;
        public static List<InventorySubCategory> AllInventorySubCategories => _allInventorySubCategories;

        public static void SetInventorySubCategories(List<InventorySubCategory> subCategories)
        {
            _allInventorySubCategories = subCategories ?? new List<InventorySubCategory>();

            foreach (var subcategory in _allInventorySubCategories.Where(sc => sc != null))
            {
                if (!_categorySubcategoriesCache.ContainsKey(subcategory.catId))
                {
                    _categorySubcategoriesCache[subcategory.catId] = new List<InventorySubCategory>();
                }
                if (!_categorySubcategoriesCache[subcategory.catId].Any(sc => sc.scId == subcategory.scId))
                {
                    _categorySubcategoriesCache[subcategory.catId].Add(subcategory);
                }
            }

            _currentInventorySubCategory = null;
        }

        public static void SetCurrentInventorySubCategory(InventorySubCategory? subCategory)
        {
            _currentInventorySubCategory = subCategory;
        }

        public static InventorySubCategory? GetInventorySubategoryById(int subcategoryId)
        {
            foreach (var subcategories in _categorySubcategoriesCache.Values)
            {
                var found = subcategories.FirstOrDefault(sc => sc.scId == subcategoryId);
                if (found != null) return found;
            }

            return _allInventorySubCategories.FirstOrDefault(c => c.scId == subcategoryId);
        }

        public static string GetInventorySubcategoryNameById(int subcategoryId)
        {
            var subCategory = GetInventorySubategoryById(subcategoryId);
            return subCategory?.scName ?? "Unknown Subcategory";
        }

        public static List<InventorySubCategory> GetInventorySubcategoriesByCategoryId(int categoryId)
        {
            if (_categorySubcategoriesCache.ContainsKey(categoryId))
            {
                var cachedResults = _categorySubcategoriesCache[categoryId];
                if (cachedResults.Any())
                {
                    return cachedResults;
                }
            }

            var results = _allInventorySubCategories
                .Where(sc => sc != null && sc.catId == categoryId)
                .ToList();

            if (results.Any())
            {
                _categorySubcategoriesCache[categoryId] = results;
                return results;
            }

            return new List<InventorySubCategory>();
        }

        public static void Clear()
        {
            _currentInventorySubCategory = null;
            _allInventorySubCategories.Clear();
            _categorySubcategoriesCache.Clear();
        }

        public static void RefreshCache()
        {
            _categorySubcategoriesCache.Clear();
            foreach (var subcategory in _allInventorySubCategories.Where(sc => sc != null))
            {
                if (!_categorySubcategoriesCache.ContainsKey(subcategory.catId))
                {
                    _categorySubcategoriesCache[subcategory.catId] = new List<InventorySubCategory>();
                }
                if (!_categorySubcategoriesCache[subcategory.catId].Any(sc => sc.scId == subcategory.scId))
                {
                    _categorySubcategoriesCache[subcategory.catId].Add(subcategory);
                }
            }
        }
    }
}
