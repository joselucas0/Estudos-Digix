using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio2;


public class Program
{
    public static void Main(string[] args)
    {
        // Criando um objeto de Endereço
        Endereco endereco = new Endereco
        {
            Rua = "Rua Exemplo",
            Numero = 123,
            Bairro = "Centro",
            Cep = "79002-000",
            Cidade = new Cidade
            {
                Nome = "Campo Grande",
                Estado = new Estado { Nome = "Mato Grosso do Sul", Sigla = "MS" }
            }
        };

        // Criando um objeto de Vendedor
        Vendedor vendedor = new Vendedor
        {
            Nome = "José Lucas Rocha",
            Nascimento = new DateTime(2003, 1, 15),
            Cpf = "123.456.789-00",
            Enderecos = endereco,
            Equipe = new EquipeVenda { Nome = "Equipe Alpha" }
        };

        // Criando um objeto de Gerente
        Gerente gerente = new Gerente
        {
            Nome = "João Paulo",
            Nascimento = new DateTime(2000, 5, 10),
            Cpf = "987.654.321-00",
            Enderecos = endereco
        };

        // Exibindo informações do vendedor
        Console.WriteLine("=== Informações do Vendedor ===");
        Console.WriteLine($"Nome: {vendedor.GetNome()}");
        Console.WriteLine($"Salário: R$ {vendedor.GetSalario()}");
        Console.WriteLine($"Dias para receber: {vendedor.DiasParaReceberSalario()} dias");

        // Exibindo informações do gerente
        Console.WriteLine("\n=== Informações do Gerente ===");
        Console.WriteLine($"Nome: {gerente.GetNome()}");
        Console.WriteLine($"Salário: R$ {gerente.GetSalario()}");
        Console.WriteLine($"Dias para receber: {gerente.DiasParaReceberSalario()} dias");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}