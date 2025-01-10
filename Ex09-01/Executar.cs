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
            try
            {
                // Criação do banco e adição de contas e clientes
                var bank = new Bank();
                var customer = new Customer("José Lucas", "Rua das Flores, 123", new DateTime(2000, 5, 20), 123456, "1234");

                var currentAccount = new CurrentAccount(101, 500);
                var savingAccount = new SavingAccount(102, 1000);

                bank.AddAccount(currentAccount);
                bank.AddAccount(savingAccount);

                Console.WriteLine("Bem-vindo ao sistema bancário!");
                Console.WriteLine("Por favor, insira seu cartão (Número do Cartão): ");
                int cardNumber = Convert.ToInt32(Console.ReadLine());

                // Autenticação do cliente
                if (cardNumber != customer.CardNumber)
                {
                    throw new Exceptio.AccountNotFoundException("Cartão não encontrado. Verifique o número digitado.");
                }

                Console.WriteLine("Insira seu PIN: ");
                string? pin = Console.ReadLine();

                if (!customer.VerifyPassword(pin))
                {
                    throw new Exceptio.AuthenticationException("Autenticação falhou. PIN incorreto.");
                }

                Console.WriteLine($"Bem-vindo, {customer.Name}!");

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nSelecione uma operação:");
                    Console.WriteLine("1. Depósito");
                    Console.WriteLine("2. Saque");
                    Console.WriteLine("3. Ver Histórico de Transações");
                    Console.WriteLine("4. Sair");
                    Console.Write("Opção: ");
                    string? option = Console.ReadLine();

                    switch (option)
                    {
                        case "1": // Depósito
                            Console.WriteLine("Selecione a conta (1: Conta Corrente, 2: Conta Poupança): ");
                            string? accountTypeDeposit = Console.ReadLine();

                            Console.Write("Digite o valor do depósito: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                            {
                                if (accountTypeDeposit == "1")
                                {
                                    currentAccount.Deposit(depositAmount);
                                    Console.WriteLine($"Depósito de {depositAmount:C} realizado na Conta Corrente.");
                                }
                                else if (accountTypeDeposit == "2")
                                {
                                    savingAccount.Deposit(depositAmount);
                                    Console.WriteLine($"Depósito de {depositAmount:C} realizado na Conta Poupança.");
                                }
                                else
                                {
                                    Console.WriteLine("Conta inválida.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;

                        case "2": // Saque
                            Console.WriteLine("Selecione a conta (1: Conta Corrente, 2: Conta Poupança): ");
                            string? accountTypeWithdraw = Console.ReadLine();

                            Console.Write("Digite o valor do saque: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                            {
                                try
                                {
                                    if (accountTypeWithdraw == "1")
                                    {
                                        currentAccount.Withdraw(withdrawAmount);
                                        Console.WriteLine($"Saque de {withdrawAmount:C} realizado na Conta Corrente.");
                                    }
                                    else if (accountTypeWithdraw == "2")
                                    {
                                        savingAccount.Withdraw(withdrawAmount);
                                        Console.WriteLine($"Saque de {withdrawAmount:C} realizado na Conta Poupança.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Conta inválida.");
                                    }
                                }
                                catch (Exceptio.InvalidTransactionException ex)
                                {
                                    Console.WriteLine($"Erro: {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;

                        case "3": // Histórico de Transações
                            Console.WriteLine("Selecione a conta (1: Conta Corrente, 2: Conta Poupança): ");
                            string? accountTypeHistory = Console.ReadLine();

                            if (accountTypeHistory == "1")
                            {
                                Console.WriteLine("Histórico de Transações - Conta Corrente:");
                                foreach (var transaction in currentAccount.GetTransactionHistory())
                                {
                                    Console.WriteLine(transaction);
                                }
                            }
                            else if (accountTypeHistory == "2")
                            {
                                Console.WriteLine("Histórico de Transações - Conta Poupança:");
                                foreach (var transaction in savingAccount.GetTransactionHistory())
                                {
                                    Console.WriteLine(transaction);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Conta inválida.");
                            }
                            break;

                        case "4": // Sair
                            exit = true;
                            Console.WriteLine("Obrigado por usar o sistema bancário. Até mais!");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}