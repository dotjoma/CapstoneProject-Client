using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class Payment
    {
        public int paymentId { get; set; }
        public int transId { get; set; }
        public decimal amountPaid { get; set; }
        public string? paymentMethod { get; set; }
        public string? referenceNumber { get; set; }
        public DateTime paymentTime { get; set; }
        public decimal changeAmount { get; set; }
    }
}
