using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            
            // preenchendo a matriz com valores fornecidos pelo usuário
            Console.WriteLine($"Digite os elementos da matriz {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write($"Elemento [{i + 1},{x + 1}]: ");
                    matriz[i, x] = int.Parse(Console.ReadLine());
                }
            }

            // criando uma nova matriz para armazenar a rotação
            int[,] matrizRotacionada = new int[n, n];

            // rotacionando a matriz 90 graus no sentido horário
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    matrizRotacionada[x, n - i - 1] = matriz[i, x];
                }
            }

            // exibindo a matriz rotacionada
            Console.WriteLine("\nMatriz rotacionada 90 graus no sentido horário:");
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write(matrizRotacionada[i, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
