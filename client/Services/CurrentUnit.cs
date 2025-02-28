using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentUnit
    {
        private static Unit? _currentUnit;
        private static List<Unit> _allUnit = new List<Unit>();

        public static Unit? Current => _currentUnit;
        public static List<Unit> AllUnit => _allUnit;

        public static void SetUnits(List<Unit> units)
        {
            _allUnit = units ?? new List<Unit>();
            _currentUnit = null;
        }

        public static void SetCurrentUnit(Unit? unit)
        {
            _currentUnit = unit;
        }

        public static Unit? GetUnitById(int id)
        {
            return AllUnit.FirstOrDefault(u => u.unitId == id);
        }

        public static void Clear()
        {
            _currentUnit = null;
            _allUnit.Clear();
        }
    }
}
