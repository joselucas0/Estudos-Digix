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
//     private No inicio; // Corrigido: declaração da variável inicio

//     public ListaDuplamenteEncadeada()
//     {
//         inicio = null;
//     }

//     public void Inserir(string aluno_Nome)
//     {
//         No novo_No = new No(aluno_Nome);

//         if (inicio == null)
//         {
//             inicio = novo_No;
//         }
//         else if (string.Compare(aluno_Nome, inicio.aluno_Nome, StringComparison.OrdinalIgnoreCase) <= 0)
//         {
//             novo_No.proximo = inicio;
//             inicio.anterior = novo_No;
//             inicio = novo_No;
//         }
//         else
//         {
//             No atual = inicio;
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

//     public void InserirNaPosicao(string aluno_Nome, int posicao)
//     {
//         if (posicao < 0)
//         {
//             Console.WriteLine("Posição inválida.");
//             return;
//         }

//         No novo_No = new No(aluno_Nome);

//         if (posicao == 0)
//         {
//             novo_No.proximo = inicio;
//             if (inicio != null)
//             {
//                 inicio.anterior = novo_No;
//             }
//             inicio = novo_No;
//             return;
//         }

//         No atual = inicio;
//         int contador = 0;

//         while (atual != null && contador < posicao - 1)
//         {
//             atual = atual.proximo;
//             contador++;
//         }

//         if (atual == null)
//         {
//             Console.WriteLine("Posição inválida. A lista não possui tantos elementos.");
//             return;
//         }

//         novo_No.proximo = atual.proximo;
//         if (atual.proximo != null)
//         {
//             atual.proximo.anterior = novo_No;
//         }
//         atual.proximo = novo_No;
//         novo_No.anterior = atual;
//     }

//     public void Exibir()
//     {
//         No atual = inicio;
//         Console.WriteLine("Lista de Nomes:");
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

//         lista.Inserir("10");
//         lista.Inserir("20");
//         lista.Inserir("30");

//         Console.WriteLine("Lista Original:");
//         lista.Exibir();

//         Console.WriteLine("\nInserindo '25' na posição 2...");
//         lista.InserirNaPosicao("25", 2);
//         lista.Exibir();

//         Console.WriteLine("\nTentando inserir na posição inválida 10...");
//         lista.InserirNaPosicao("40", 10);
//         lista.Exibir();

//         Console.WriteLine("\nInserindo '5' na posição 0...");
//         lista.InserirNaPosicao("5", 0);
//         lista.Exibir();
//     }
// }
