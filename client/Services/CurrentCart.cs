using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentCart
    {
        private static List<CartItem> _cartItems = new List<CartItem>();

        public static List<CartItem> Items => _cartItems;

        public static void AddItem(CartItem item)
        {
            var existingItem = _cartItems.FirstOrDefault(p => p.productId == item.productId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _cartItems.Add(item);
            }
        }

        public static void RemoveItem(int productId)
        {
            var item = _cartItems.FirstOrDefault(p => p.productId == productId);
            if (item != null)
            {
                _cartItems.Remove(item);
            }
        }

        public static void UpdateItemQuantity(int productId, int quantity)
        {
            var item = _cartItems.FirstOrDefault(p => p.productId == productId);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public static void ClearCart()
        {
            _cartItems.Clear();
        }

        public static decimal GetTotalPrice()
        {
            return _cartItems.Sum(item => item.productPrice * item.Quantity);
        }
    }
}
