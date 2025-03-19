using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class CartItem
    {
        public int productId { get; set; }
        public string? productName { get; set; }
        public decimal productPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => productPrice * Quantity;
    }
}
