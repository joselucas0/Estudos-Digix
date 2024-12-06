// using System;
// using System.Linq;

// namespace Aula_15_OO
// {
//     public interface IProduto
//     {
//         string Nome { get; }
//         double Preco { get; }
//         int Quantidade { get; }
//         double CalcularEstoque();
//     }

//     public class Petiscos : IProduto
//     {
//         public string Nome { get; set; } = string.Empty;
//         public double Preco { get; set; } = 0.0;
//         public int Quantidade { get; set; } = 0;

//         public Petiscos() { }

//         public Petiscos(string nome, double preco, int quantidade)
//         {
//             Nome = nome;
//             Preco = preco;
//             Quantidade = quantidade;
//         }

//         public double CalcularEstoque()
//         {
//             return Preco * Quantidade;
//         }
//     }

//     public class Limpeza : IProduto
//     {
//         public string Nome { get; set; } = string.Empty;
//         public double Preco { get; set; } = 0.0;
//         public int Quantidade { get; set; } = 0;

//         public Limpeza() { }

//         public Limpeza(string nome, double preco, int quantidade)
//         {
//             Nome = nome;
//             Preco = preco;
//             Quantidade = quantidade;
//         }

//         public double CalcularEstoque()
//         {
//             return Preco * Quantidade;
//         }
//     }

//     public record Laticinios : IProduto
//     {
//         public string Nome { get; set; } = string.Empty;
//         public double Preco { get; set; } = 0.0;
//         public int Quantidade { get; set; } = 0;

//         public Laticinios() { }

//         public Laticinios(string nome, double preco, int quantidade)
//         {
//             Nome = nome;
//             Preco = preco;
//             Quantidade = quantidade;
//         }

//         public double CalcularEstoque()
//         {
//             return Preco * Quantidade;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Criação dos objetos
//             Petiscos coxinha = new Petiscos("Coxinha", 1.50, 100);
//             Limpeza limpeza = new Limpeza("Shampoo", 2.00, 50);
//             Laticinios laticinios = new Laticinios("Leite", 3.00, 200);

//             // Calcular estoque
//             Console.WriteLine($"Coxinha: R$ {coxinha.CalcularEstoque():F2}");
//             Console.WriteLine($"Limpeza: R$ {limpeza.CalcularEstoque():F2}");
//             Console.WriteLine($"Laticínios: R$ {laticinios.CalcularEstoque():F2}");

//             // Atualizar estoque
//             coxinha.Quantidade += 10;
//             limpeza.Quantidade -= 5;
//             laticinios.Quantidade += 30;

//             // Encontrar o maior estoque
//             var maiorEstoque = new IProduto[] { coxinha, limpeza, laticinios }
//                 .OrderByDescending(item => item.Quantidade)
//                 .First();

//             // Exibir o maior estoque
//             Console.WriteLine($"Maior estoque: {maiorEstoque.Nome}");
//             Console.WriteLine($"Quantidade: {maiorEstoque.Quantidade}");
//             Console.WriteLine($"Valor total: R$ {maiorEstoque.CalcularEstoque():F2}");
//         }
//     }
// }
