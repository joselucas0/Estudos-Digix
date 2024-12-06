// using System;
// using System.Collections.Generic;

// namespace Padaria
// {
//     public class Produto
//     {
//         public string? NomeAlimento { get; set; }
//         public string Categoria { get; set; }
//         public double Preco { get; set; }
//         public DateTime Validade { get; set; }

//         public Produto(string? nomeAlimento, string categoria, double preco, DateTime validade)
//         {
//             NomeAlimento = nomeAlimento;
//             Categoria = categoria;
//             Preco = preco;
//             Validade = validade;
//         }

//         public override string ToString()
//         {
//             return $"Nome do Alimento: {NomeAlimento}, Categoria: {Categoria}, Preço: R$ {Preco}, Validade: {Validade.ToShortDateString()}";
//         }
//     }
    

//     public class Pedido
//     {
//         public int NumeroPedido { get; set; }
//         public DateTime DataHora { get; set; }
//         public List<(Produto Produto, int Quantidade)> Itens { get; set; }
//         public double Total { get; private set; }

//         public Pedido(int numeroPedido, DateTime dataHora)
//         {
//             NumeroPedido = numeroPedido;
//             DataHora = dataHora;
//             Itens = new List<(Produto, int)>();
//         }

//         public void AdicionarItem(Produto produto, int quantidade)
//         {
//             Itens.Add((produto, quantidade));
//             Total += produto.Preco * quantidade;
//         }

//         public void RemoverItem(string nomeProduto)
//         {
//             var item = Itens.Find(x => x.Produto.NomeAlimento == nomeProduto);
//             if (item.Produto != null)
//             {
//                 Itens.Remove(item);
//                 Total -= item.Produto.Preco * item.Quantidade;
//                 Console.WriteLine($"Item \"{nomeProduto}\" removido do pedido.");
//             }
//             else
//             {
//                 Console.WriteLine($"Item \"{nomeProduto}\" não encontrado.");
//             }
//         }

//         public double CalcularTotal()
//         {
//             return Total;
//         }

//         public void MostrarItens()
//         {
//             Console.WriteLine("Itens do Pedido:");
//             foreach (var item in Itens)
//             {
//                 Console.WriteLine($"- {item.Produto.NomeAlimento} (Quantidade: {item.Quantidade}, Preço Unitário: R$ {item.Produto.Preco})");
//             }
//         }

//         public void FinalizarPedido()
//         {
//             Console.WriteLine($"Pedido finalizado com número {NumeroPedido}. Total: R$ {Total:F2}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var produtos = new List<Produto>
//             {
//                 new Produto("Feijão", "Legumes", 4.50, DateTime.Now.AddDays(30)),
//                 new Produto("Arroz", "Cereais", 5.00, DateTime.Now.AddDays(60)),
//                 new Produto("Pão Francês", "Padaria", 0.50, DateTime.Now.AddDays(1)),
//                 new Produto("Baguete", "Padaria", 1.20, DateTime.Now.AddDays(2)),
//                 new Produto("Croissant", "Padaria", 2.00, DateTime.Now.AddDays(3)),
//                 new Produto("Leite Integral", "Laticínios", 3.50, DateTime.Now.AddDays(10)),
//                 new Produto("Queijo Mussarela", "Laticínios", 15.00, DateTime.Now.AddDays(20)),
//                 new Produto("Manteiga", "Laticínios", 6.00, DateTime.Now.AddDays(15)),
//                 new Produto("Presunto", "Carnes", 12.00, DateTime.Now.AddDays(25)),
//                 new Produto("Peito de Frango", "Carnes", 8.50, DateTime.Now.AddDays(5)),
//                 new Produto("Tomate", "Vegetais", 2.50, DateTime.Now.AddDays(7)),
//                 new Produto("Alface", "Vegetais", 1.80, DateTime.Now.AddDays(4)),
//                 new Produto("Banana", "Frutas", 1.20, DateTime.Now.AddDays(6)),
//                 new Produto("Maçã", "Frutas", 2.00, DateTime.Now.AddDays(8)),
//                 new Produto("Suco de Laranja", "Bebidas", 4.00, DateTime.Now.AddDays(12)),
//                 new Produto("Água Mineral", "Bebidas", 1.00, DateTime.Now.AddDays(30)),
//                 new Produto("Café", "Bebidas", 3.00, DateTime.Now.AddDays(40)),
//                 new Produto("Bolo de Chocolate", "Doces", 10.00, DateTime.Now.AddDays(2)),
//                 new Produto("Torta de Morango", "Doces", 12.50, DateTime.Now.AddDays(3)),
//                 new Produto("Cookies", "Doces", 5.00, DateTime.Now.AddDays(5))
       
//             };

//             // Criar pedido com produtos de índice ímpar
//             Pedido pedido1 = new Pedido(1, DateTime.Now);
//             for (int i = 0; i < produtos.Count; i++)
//             {
//                 if (i % 2 != 0) // Índices ímpares
//                 {
//                     pedido1.AdicionarItem(produtos[i], 1);
//                 }
//             }

//             // Mostrar itens do pedido
//             Console.WriteLine("\nItens do Pedido 1:");
//             pedido1.MostrarItens();

//             // Remover item do pedido
//             string itemRemovido = "Leite Integral";
//             Console.WriteLine($"\nRemovendo item: {itemRemovido}");
//             pedido1.RemoverItem(itemRemovido);

//             // Mostrar itens do pedido após remoção
//             Console.WriteLine("\nItens do Pedido 1 após remoção:");
//             pedido1.MostrarItens();

//             // Calcular total do pedido
//             Console.WriteLine($"\nTotal do Pedido 1: R$ {pedido1.CalcularTotal():F2}");

//             // Finalizar pedido
//             Console.WriteLine("\nFinalizando Pedido 1:");
//             pedido1.FinalizarPedido();
//         }
//     }
// }
