using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryItem
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? SubcategoryName { get; set; }
        public string? UnitTypeName { get; set; }
        public string? UnitMeasureName { get; set; }
        public string? UnitMeasureSymbol { get; set; }
        public decimal MinStockLevel { get; set; }
        public decimal MaxStockLevel { get; set; }
        public decimal ReorderPoint { get; set; }
        public int LeadTimeDays { get; set; }
        public int TargetTurnoverDays { get; set; }
        public int ExpiryWarningDays { get; set; }
        public decimal EnableLowStockAlerts { get; set; }

        public List<InventoryBatch>? Batches { get; set; } = new List<InventoryBatch>();
    }
}
