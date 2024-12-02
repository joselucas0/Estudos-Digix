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
//     private No inicio;

//     public ListaDuplamenteEncadeada()
//     {
//         inicio = null;
//     }

//     // Inserir um nome na lista
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

//     // Inserir na posição específica
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

//     // Verificar se um valor está na lista
//     public bool Contem(string aluno_Nome)
//     {
//         No atual = inicio;
//         while (atual != null)
//         {
//             if (atual.aluno_Nome.Equals(aluno_Nome, StringComparison.OrdinalIgnoreCase))
//             {
//                 return true; // Valor encontrado
//             }
//             atual = atual.proximo;
//         }
//         return false; // Valor não encontrado
//     }

//     // Exibir a lista
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

//         // Exibindo a lista
//         Console.WriteLine("Lista Original:");
//         lista.Exibir();

//         // Verificando se um valor está presente na lista
//         Console.WriteLine("\nVerificando se o valor 20 está na lista:");
//         Console.WriteLine(lista.Contem("20") ? "Valor encontrado!" : "Valor não encontrado.");

//         Console.WriteLine("\nVerificando se o valor 40 está na lista:");
//         Console.WriteLine(lista.Contem("40") ? "Valor encontrado!" : "Valor não encontrado.");
//     }
// }
