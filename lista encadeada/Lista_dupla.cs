// using System;

// class No
// {
//     public string aluno_Nome; 
//     public No proximo;        
//     public No anterior;       

//     public No(string nome)
//     {
//         aluno_Nome = nome;
//         proximo = null;
//         anterior = null;
//     }
// }

// class ListaDuplamenteEncadeada
// {
//     private No inicio; // Início da lista

//     public ListaDuplamenteEncadeada()
//     {
//         inicio = null;
//     }

//     // Inserir um nome na lista em ordem alfabética
//     public void Inserir(string aluno_Nome)
//     {
//         No novo_No = new No(aluno_Nome);

//         if (inicio == null) // Lista vazia
//         {
//             inicio = novo_No;
//         }
//         else if (string.Compare(aluno_Nome, inicio.aluno_Nome, StringComparison.OrdinalIgnoreCase) <= 0) // Inserir no início
//         {
//             novo_No.proximo = inicio;
//             inicio.anterior = novo_No;
//             inicio = novo_No;
//         }
//         else
//         {
//             No atual = inicio;

//             // Encontrar a posição correta para inserir
//             while (atual.proximo != null && string.Compare(aluno_Nome, atual.proximo.aluno_Nome, StringComparison.OrdinalIgnoreCase) > 0)
//             {
//                 atual = atual.proximo;
//             }

//             novo_No.proximo = atual.proximo;
//             if (atual.proximo != null)
//             {
//                 atual.proximo.anterior = novo_No;
//             }

//             atual.proximo = novo_No;
//             novo_No.anterior = atual;
//         }
//     }

//     // Exibir a lista
//     public void Exibir()
//     {
//         No atual = inicio;
//         Console.WriteLine("Lista de Nomes Ordenada:");
//         while (atual != null)
//         {
//             Console.WriteLine(atual.aluno_Nome);
//             atual = atual.proximo;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();

//         Console.Write("Quantos nomes você deseja inserir? ");
//         int quantidade = int.Parse(Console.ReadLine());

//         for (int i = 0; i < quantidade; i++)
//         {
//             Console.Write($"Digite o nome do aluno {i + 1}: ");
//             string nome = Console.ReadLine();
//             lista.Inserir(nome);
//         }

//         Console.WriteLine();
//         lista.Exibir();
//     }
// }
