using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ex09_01
{
    public class CurrentAccount : Account
{
    public CurrentAccount(int number, decimal initialBalance) : base(number, initialBalance) { }

    public override void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new Exceptio.InvalidTransactionException("Valor de deposito deve ser maior que zero.");

        Balance += amount;
        AddTransaction(TransactionType.Deposit, amount);
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new Exceptio.InvalidTransactionException("Saque deve ser maior que zero.");
        if (amount > Balance)
            throw new Exceptio.InvalidTransactionException("Saldo insuficiente.");

        Balance -= amount;
        AddTransaction(TransactionType.Withdraw, amount);
        }
    }
}