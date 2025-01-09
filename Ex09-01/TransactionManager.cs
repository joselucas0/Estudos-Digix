using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
        public class TransactionManager
        {
        private List<TransactionHistory> transactions = new List<TransactionHistory>();

        public void AddTransaction(TransactionType type, decimal amount, decimal postBalance)
        {
            transactions.Add(new TransactionHistory(type, amount, postBalance));
        }

        public IEnumerable<TransactionHistory> GetTransactions()
        {
            return transactions;
        }
    }
}