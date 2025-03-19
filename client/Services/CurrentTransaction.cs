using client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Services
{
    public class CurrentTransaction
    {
        private static TransactionNumbers? _currentTransaction;
        private static List<TransactionNumbers> _allTransactions = new List<TransactionNumbers>();

        public static TransactionNumbers? Current => _currentTransaction;
        public static List<TransactionNumbers> AllTransactions => _allTransactions;

        public static void SetTransactions(List<TransactionNumbers> transactions)
        {
            _allTransactions = transactions ?? new List<TransactionNumbers>();
            _currentTransaction = null;
        }

        public static void SetCurrentTransaction(TransactionNumbers? transaction)
        {
            _currentTransaction = transaction;
        }

        public static void Clear()
        {
            _currentTransaction = null;
            _allTransactions.Clear();
        }
    }
}
