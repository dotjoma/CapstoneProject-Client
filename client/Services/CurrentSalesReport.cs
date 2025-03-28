using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentSalesReport
    {
        private static SalesReport? _currentSalesReport;
        private static List<SalesReport> _allSalesReports = new List<SalesReport>();

        public static SalesReport? Current => _currentSalesReport;
        public static List<SalesReport> AllSalesReports => _allSalesReports;

        public static void SetSalesReports(List<SalesReport> salesreports)
        {
            _allSalesReports= salesreports ?? new List<SalesReport>();
            _currentSalesReport = null;
        }

        public static void SetCurrentSalesReport(SalesReport? salesreport)
        {
            _currentSalesReport = salesreport;
        }

        public static SalesReport? GetSalesReportById(int salesReportId)
        {
            return _allSalesReports.FirstOrDefault(c => c.Id == salesReportId);
        }

        public static void Clear()
        {
            _currentSalesReport = null;
            _allSalesReports.Clear();
        }
    }
}
