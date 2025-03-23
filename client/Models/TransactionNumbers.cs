using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class TransactionNumbers
    {
        public int TransId { get; set; }
        public string? TransNumber { get; set; }
        public string? OrderNumber { get; set; }

        public TransactionNumbers(int transId, string transNumber, string orderNumber)
        {
            TransId = transId;
            TransNumber = transNumber;
            OrderNumber = orderNumber;
        }
    }
}
