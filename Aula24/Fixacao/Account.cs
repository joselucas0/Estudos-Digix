using System;

namespace Fixacao
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public decimal Balance { get; private set; } // `private set` para impedir modificações externas

        // Construtor
        public Account(int number, string holder, decimal balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Método para depósito
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Erro: O valor do depósito deve ser maior que zero.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Depósito de {amount:C} realizado. Novo saldo é de: {Balance:C}");
        }

        // Método para saque
        public bool Withdraw(decimal amount)
        {
            try
            {
                if (amount > Balance)
                {
                    // Lança uma exceção se o valor do saque for maior que o saldo
                    throw new InvalidOperationException("Saldo insuficiente para o saque.");
                }

                if (amount <= 0)
                {
                    // Lança uma exceção para valores inválidos
                    throw new InvalidOperationException("O valor do saque deve ser maior que zero.");
                }

                // Subtrai o valor do saldo
                Balance -= amount;
                Console.WriteLine($"Saque de {amount:C} realizado. Novo saldo é de: {Balance:C}");
                return true; // Indica que o saque foi bem-sucedido
            }
            catch (InvalidOperationException e)
            {
                // Trata o erro de saldo insuficiente ou valor inválido
                Console.WriteLine($"Erro: {e.Message}");
                return false; // Indica que o saque falhou
            }
        }
    }
}
