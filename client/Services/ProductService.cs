using client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class ProductService
    {
        private static readonly string FilePath = "products.json"; 


        public static List<Product> GetAllProducts()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Product>();
            }

            var json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }

        public static void SaveProducts(List<Product> products)
        {
            var json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static void AddProduct(Product product)
        {
            var products = GetAllProducts();
            products.Add(product);
            SaveProducts(products);
        }

        public static void ClearProducts()
        {
            File.WriteAllText(FilePath, "[]");
        }
    }
}
