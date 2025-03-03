using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentDiscount
    {
        private static Discount? _currentDiscount;
        private static List<Discount> _allDiscount = new List<Discount>();

        public static Discount? Current => _currentDiscount;
        public static List<Discount> AllDiscount => _allDiscount;

        public static void SetDiscounts(List<Discount> discounts)
        {
            _allDiscount = discounts ?? new List<Discount>();
            _currentDiscount = null;
        }

        public static void SetCurrentDiscount(Discount? discount)
        {
            _currentDiscount = discount;
        }

        public static Discount? GetDiscountById(int id)
        {
            return AllDiscount.FirstOrDefault(u => u.Id == id);
        }

        public static void Clear()
        {
            _currentDiscount = null;
            _allDiscount.Clear();
        }
    }
}
