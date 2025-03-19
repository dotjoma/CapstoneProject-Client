using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class TransactionNumbers
    {
        public string? TransNumber { get; set; }
        public string? OrderNumber { get; set; }

        public TransactionNumbers(string transNumber, string orderNumber)
        {
            TransNumber = transNumber;
            OrderNumber = orderNumber;
        }
    }
}
