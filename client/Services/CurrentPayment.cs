using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentPayment
    {
        private static Payment? _currentPayment;
        private static List<Payment> _allPayments = new List<Payment>();

        public static Payment? Current => _currentPayment;

        public static List<Payment> AllPayments => _allPayments;

        public static void SetPayments(List<Payment> payments)
        {
            _allPayments = payments ?? new List<Payment>();
            _currentPayment = null;
        }

        public static void SetCurrentPayment(Payment? payment)
        {
            _currentPayment = payment;
        }

        public static Payment? GetPaymentById(int id)
        {
            return AllPayments.FirstOrDefault(p => p.paymentId == id);
        }

        public static void Clear()
        {
            _currentPayment = null;
            _allPayments.Clear();
        }
    }
}
