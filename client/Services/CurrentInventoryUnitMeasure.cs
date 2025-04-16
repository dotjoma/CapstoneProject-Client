using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentInventoryUnitMeasure
    {
        private static InventoryUnitMeasure? _currentInventoryUnitMeasure;
        private static List<InventoryUnitMeasure> _allUnitMeasures = new List<InventoryUnitMeasure>();

        public static InventoryUnitMeasure? Current => _currentInventoryUnitMeasure;
        public static List<InventoryUnitMeasure> AllUnitMeasures => _allUnitMeasures;

        public static void SetUnitMeasures(List<InventoryUnitMeasure> unitmeasures)
        {
            _allUnitMeasures = unitmeasures ?? new List<InventoryUnitMeasure>();
            _currentInventoryUnitMeasure = null;
        }

        public static void SetCurrentUnitMeasure(InventoryUnitMeasure? unitmeasure)
        {
            _currentInventoryUnitMeasure = unitmeasure;
        }

        public static InventoryUnitMeasure? GetUnitMeasureById(int unitMeasureId)
        {
            return _allUnitMeasures.FirstOrDefault(c => c.Id == unitMeasureId);
        }

        public static void Clear()
        {
            _currentInventoryUnitMeasure = null;
            _allUnitMeasures.Clear();
        }
    }
}
