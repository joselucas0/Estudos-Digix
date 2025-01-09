using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    public enum TransactionType
    {
        Deposit,
        Withdraw
    }
    public abstract class Account
{
    public int Number { get; }
    public decimal Balance { get; protected set; }
    private TransactionManager transactionManager = new TransactionManager();

    public Account(int number, decimal initialBalance)
    {
        Number = number;
        Balance = initialBalance;
    }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);

    public void AddTransaction(TransactionType type, decimal amount)
    {
        transactionManager.AddTransaction(type, amount, Balance);
    }

    public IEnumerable<TransactionHistory> GetTransactionHistory()
    {
        return transactionManager.GetTransactions();
    }
}
}