using client.Helpers;
using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentProduct
    {
        private static Product? _currentProduct;
        private static List<Product> _allProduct = new List<Product>();

        public static Product? Current => _currentProduct;
        public static List<Product> AllProduct => _allProduct;

        public static void SetProducts(List<Product> products)
        {
            _allProduct = products ?? new List<Product>();
            _currentProduct = null;
        }

        public static void SetCurrentProduct(Product? product)
        {
            _currentProduct = product;
        }

        public static Product? GetProductById(int id)
        {
            try
            {
                var product = _allProduct.FirstOrDefault(p => p.productId == id);

                if (product == null)
                {
                    Logger.Write("PRODUCT", $"Product with ID {id} not found");
                    return null;
                }

                Logger.Write("PRODUCT", $"Found product: {product.productName} (ID: {id})");
                return product;
            }
            catch (Exception ex)
            {
                Logger.Write("PRODUCT", $"Error getting product with ID {id}: {ex.Message}");
                return null;
            }
        }

        public static void Clear()
        {
            _currentProduct = null;
            _allProduct.Clear();
        }
    }
}
