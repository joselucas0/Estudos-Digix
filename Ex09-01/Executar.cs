using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Ex09_01
{
    class Program
{
      static void Main(string[] args)
      {
          Bank bank = new Bank();
  
          // Create Accounts
          var currentAccount = new CurrentAccount(101, 500);
          var savingAccount = new SavingAccount(102, 1000);
  
          bank.AddAccount(currentAccount);
          bank.AddAccount(savingAccount);
  
          // Perform Transactions
          try
          {
              currentAccount.Deposit(200);
              currentAccount.Withdraw(100);
  
              savingAccount.Deposit(500);
              savingAccount.Withdraw(300);
          }
          catch (Exceptio.InvalidTransactionException ex)
          {
              Console.WriteLine(ex.Message);
          }
  
          // Display Transaction History
          Console.WriteLine("\nTransacoes da conta corrente:");
          foreach (var transaction in currentAccount.GetTransactionHistory())
          {
              Console.WriteLine(transaction);
          }
  
          Console.WriteLine("\nSalvando trasacoes de conta:");
          foreach (var transaction in savingAccount.GetTransactionHistory())
          {
              Console.WriteLine(transaction);
          }
      }
  }
}