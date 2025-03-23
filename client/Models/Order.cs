using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int transNo { get; set; }
        public int productId { get; set; }
        public int cashierId { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice { get; set; }
        public string? notes { get; set; }
        public string? orderType { get; set; }
    }
}
