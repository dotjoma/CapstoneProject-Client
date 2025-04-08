using client.Models;
using client.Models.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentAudit
    {
        private static Audit? _currentAudit;
        private static List<Audit> _allAudits = new List<Audit>();

        public static Audit? Current => _currentAudit;
        public static List<Audit> AllAudits => _allAudits;

        public static void SetAudits(List<Audit> audits)
        {
            _allAudits = audits ?? new List<Audit>();
            _currentAudit = null;
        }

        public static void SetCurrentAudit(Audit? audit)
        {
            _currentAudit = audit;
        }

        public static void Clear()
        {
            _currentAudit = null;
            _allAudits.Clear();
        }
    }
}
