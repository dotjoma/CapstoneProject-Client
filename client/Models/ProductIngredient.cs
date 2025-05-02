using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class ProductIngredient
    {
        public int InventoryItemId { get; set; }
        public decimal Quantity { get; set; }
        public string? MeasureSymbol { get; set; }
    }
}
