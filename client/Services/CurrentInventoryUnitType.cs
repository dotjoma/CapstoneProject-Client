using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventoryUnitType
    {
        private static InventoryUnitType? _currentInventoryUnitType;
        private static List<InventoryUnitType> _allUnitTypes = new List<InventoryUnitType>();

        public static InventoryUnitType? Current => _currentInventoryUnitType;
        public static List<InventoryUnitType> AllUnitTypes => _allUnitTypes;

        public static void SetUnitTypes(List<InventoryUnitType> unittypes)
        {
            _allUnitTypes = unittypes ?? new List<InventoryUnitType>();
            _currentInventoryUnitType = null;
        }

        public static void SetCurrentUnitType(InventoryUnitType? unittype)
        {
            _currentInventoryUnitType = unittype;
        }

        public static InventoryUnitType? GetUnitTypeById(int unitTypeId)
        {
            return _allUnitTypes.FirstOrDefault(c => c.Id == unitTypeId);
        }

        public static void Clear()
        {
            _currentInventoryUnitType = null;
            _allUnitTypes.Clear();
        }
    }
}
