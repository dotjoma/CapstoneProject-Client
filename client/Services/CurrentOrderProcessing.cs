using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentOrderProcessing
    {
        private static List<OrderProcessing> _orderItems = new List<OrderProcessing>();

        public static List<OrderProcessing> Items => _orderItems;

        public static void AddItem(OrderProcessing item)
        {
            var existingItem = _orderItems.FirstOrDefault(p => p.ProductId == item.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                _orderItems.Add(item);
            }
        }

        public static void RemoveItem(int productId)
        {
            var item = _orderItems.FirstOrDefault(p => p.ProductId == productId);
            if (item != null)
            {
                _orderItems.Remove(item);
            }
        }

        public static void UpdateItemQuantity(int productId, int quantity)
        {
            var item = _orderItems.FirstOrDefault(p => p.ProductId == productId);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public static void ClearOrder()
        {
            _orderItems.Clear();
        }

        public static decimal GetTotalPrice()
        {
            return _orderItems.Sum(item => item.Price * item.Quantity);
        }
    }
}
