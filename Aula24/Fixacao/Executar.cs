using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fixacao
{
    class Program
        {
        static void Main(string[] args)
        {
            // Criação da conta
            Account myAccount = new Account(12345, "José Lucas", 1000m); // Saldo inicial: R$ 1.000,00

            // Depósito
            Console.WriteLine("\nTentando depositar R$ 500...");
            myAccount.Deposit(500m);

            // Saque bem-sucedido
            Console.WriteLine("\nTentando sacar R$ 800...");
            myAccount.Withdraw(800m);

            // Tentativa de saque com saldo insuficiente
            Console.WriteLine("\nTentando sacar R$ 1.000...");
            myAccount.Withdraw(1000m);

            // Tentativa de saque com valor negativo
            Console.WriteLine("\nTentando sacar um valor negativo...");
            myAccount.Withdraw(-200m);

            // Tentativa de depósito com valor zero
            Console.WriteLine("\nTentando depositar R$ 0...");
            myAccount.Deposit(0m);
        }
}

}