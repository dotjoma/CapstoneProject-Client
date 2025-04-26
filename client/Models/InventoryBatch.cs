using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class InventoryBatch
    {
        public int BatchId { get; set; }
        public string? BatchNumber { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal InitialQuantity { get; set; }
        public decimal CurrentQuantity { get; set; }
        public decimal UnitCost { get; set; }
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? Status { get; set; }
        public int IsActive { get; set; }
    }
}
