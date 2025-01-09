using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    public class TransactionHistory
    {
        public TransactionType Type { get; }
        public decimal Amount { get; }
        public decimal PostBalance { get; }
        public DateTime Date { get; }

        public TransactionHistory(TransactionType type, decimal amount, decimal postBalance)
        {
            Type = type;
            Amount = amount;
            PostBalance = postBalance;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Date}] {Type}: {Amount:C} | Saldo: {PostBalance:C}";
        }
        }
}