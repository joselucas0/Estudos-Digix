// using System;

// class Program
// {
//     static void SelectionSort(string[] vetor) {
//         int n = vetor.Length;
//         for (int i = 0; i < n - 1; i++) {
//             int min = i;

//             for (int j = i + 1; j < n; j++) {
//                 if (string.Compare(vetor[j], vetor[min]) < 0) {
//                     min = j;
//                 }
//             }

//             string aux = vetor[i];
//             vetor[i] = vetor[min];
//             vetor[min] = aux;
//         }
//     }

//     static void Main()
//     {
//         string[] nomes = { "Ana", "Carlos", "Beatriz", "José", "Lucas", "Pedro", "Fernanda" };

//         Console.WriteLine("Lista de nomes antes da ordenação:");
//         foreach (var nome in nomes)
//         {
//             Console.WriteLine(nome);
//         }

//         SelectionSort(nomes);

//         Console.WriteLine("\nLista de nomes após a ordenação:");
//         foreach (var nome in nomes)
//         {
//             Console.WriteLine(nome);
//         }
//     }
// }
