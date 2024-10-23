using System;

class Pessoa
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public double Saldo { get; set; }
}

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite sua idade:");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu saldo:");
            pessoa.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nInformações:");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Saldo: {pessoa.Saldo:C}");
            Console.WriteLine($"Tipo da Idade: {pessoa.Idade.GetType()}"); 
        }
    }
}
