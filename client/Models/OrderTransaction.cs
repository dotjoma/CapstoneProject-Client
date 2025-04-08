using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class OrderTransaction
    {
        public TransactionProcessing? Transaction { get; set; }
        public OrderProcessing? Order { get; set; }
        public PaymentProcessing? Payment { get; set; }

        public OrderTransaction(TransactionProcessing transaction, OrderProcessing order, PaymentProcessing payment)
        {
            Transaction = transaction;
            Order = order;
            Payment = payment;
        }
    }

    public class TransactionProcessing
    {
        public int TransId { get; set; }
        public int TransNo { get; set; }
        public decimal totalAmount { get; set; }
        public string? status { get; set; }
        public string? paymentMethod { get; set; }
    }

    public class OrderProcessing
    {
        public int OrderId { get; set; }
        public string? TransNo { get; set; }
        public int ProductId { get; set; }
        public int CashierId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount {  get; set; }
        public decimal TotalPrice { get; set; }
        public string? Notes { get; set; }
        public string? OrderType { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class PaymentProcessing
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
