using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex09_01
{
    public class ATM
{
    public string? Location { get; }
    public Bank ManagedBy { get; }

    public ATM(string location, Bank bank)
    {
        Location = location;
        ManagedBy = bank;
    }

    public void PerformTransaction(int accountNumber, string pin, TransactionType type, decimal amount)
    {
        var account = ManagedBy.FindAccountByNumber(accountNumber);

        // assumindo que a autenticacao do cliente aconteceu antes
        switch (type)
        {
            case TransactionType.Deposit:
                account.Deposit(amount);
                break;

            case TransactionType.Withdraw:
                account.Withdraw(amount);
                break;
        }

        Console.WriteLine("Transacao feita com sucesso.");
    }
}
}