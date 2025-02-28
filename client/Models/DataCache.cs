using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class DataCache
    {
        public static DateTime LastCategoryUpdate { get; set; }
        public static DateTime LastProductUpdate { get; set; }


        public static List<Product> Products { get; set; } = new List<Product>(); 
        public static bool ProductsAreValid { get; set; } = false;

        public static bool ShouldRefreshCategories { get; set; } = true;

        public static bool ShouldRefreshProducts =>
            (DateTime.Now - LastProductUpdate).TotalMinutes > 5;


        public static void InvalidateProductCache()
        {
            ProductsAreValid = false; 
            LastProductUpdate = DateTime.MinValue;
        }
    }
}
