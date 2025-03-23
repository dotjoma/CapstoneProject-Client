using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentOrder
    {
        private static Order? _currentOrder;
        private static List<Order> _allOrders = new List<Order>();

        public static Order? Current => _currentOrder;
        public static List<Order> AllOrders => _allOrders;

        public static void SetOrders(List<Order> orders)
        {
            _allOrders = orders ?? new List<Order>();
            _currentOrder = null;
        }

        public static void SetCurrentOrder(Order? order)
        {
            _currentOrder = order;
        }

        public static Order? GetOrderById(int id)
        {
            return AllOrders.FirstOrDefault(o => o.orderId == id);
        }

        public static void Clear()
        {
            _currentOrder = null;
            _allOrders.Clear();
        }
    }
}
