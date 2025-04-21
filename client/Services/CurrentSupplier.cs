using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentSupplier
    {
        private static Supplier? _currentSupplier;
        private static List<Supplier> _allSuppliers = new List<Supplier>();

        public static Supplier? Current => _currentSupplier;
        public static List<Supplier> AllSuppliers => _allSuppliers;

        public static void SetSuppliers(List<Supplier> suppliers)
        {
            _allSuppliers = suppliers ?? new List<Supplier>();
            _currentSupplier = null;
        }

        public static void SetCurrentSupplier(Supplier? supplier)
        {
            _currentSupplier = supplier;
        }

        public static Supplier? GetSupplierById(int supplierId)
        {
            return _allSuppliers.FirstOrDefault(c => c.Id == supplierId);
        }

        public static void Clear()
        {
            _currentSupplier = null;
            _allSuppliers.Clear();
        }
    }
}
