using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class AppliedDiscount
    {
        private static decimal _totalDiscount = 0;
        private static Dictionary<int, decimal> _discountedItems = new Dictionary<int, decimal>();

        public static decimal TotalDiscount => _totalDiscount;
        public static Dictionary<int, decimal> DiscountedItems => _discountedItems;

        public static event Action<decimal>? OnDiscountChanged;

        public static void AddDiscount(int productId, decimal amount)
        {
            if (_discountedItems.ContainsKey(productId))
            {
                _discountedItems[productId] += amount;
            }
            else
            {
                _discountedItems[productId] = amount;
            }

            _totalDiscount += amount;
            OnDiscountChanged?.Invoke(_totalDiscount);
        }

        public static void RemoveDiscount(int productId)
        {
            if (_discountedItems.ContainsKey(productId))
            {
                _totalDiscount -= _discountedItems[productId];
                _discountedItems.Remove(productId);
            }

            if (_totalDiscount < 0) _totalDiscount = 0;
            OnDiscountChanged?.Invoke(_totalDiscount);
        }

        public static void SetDiscount(int productId, decimal amount)
        {
            RemoveDiscount(productId);
            AddDiscount(productId, amount);
        }

        public static void Clear()
        {
            _totalDiscount = 0;
            _discountedItems.Clear();
            OnDiscountChanged?.Invoke(_totalDiscount);
        }
    }
}
