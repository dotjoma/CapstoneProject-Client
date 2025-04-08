using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryItem
    {
        string? ItemName { get; set; }
        string? Category {  get; set; }
        string? Subcategory { get; set; }
        string? BatchNumber { get; set; }
        DateTime PurchaseDate { get; set; }
        DateTime ExpirationDate { get; set; }
        decimal BatchQuantity { get; set; }
        string? UnitType { get; set; }
        string? UnitMeasure {  get; set; }
        decimal MinStockLevel { get; set; }
        decimal MaxStockLevel { get; set; }
        decimal ReorderPoint { get; set; }
        int LeadTimeDays { get; set; }
        int TargetTurnoverDays { get; set; }
        decimal UnitCost { get; set; }
        string? Supplier {  get; set; }
        int EnableLowStockAlerts { get; set; }
    }
}
