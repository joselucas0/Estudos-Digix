using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            
            // Preenchendo a matriz com valores fornecidos pelo usuário
            Console.WriteLine($"Digite os elementos da matriz {n}x{n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            // Calculando a soma das diagonais principal e secundária
            for (int i = 0; i < n; i++)
            {
                somaDiagonalPrincipal += matriz[i, i]; // Diagonal principal
                somaDiagonalSecundaria += matriz[i, n - i - 1]; // Diagonal secundária
            }

            // Exibindo os resultados
            Console.WriteLine($"\nSoma da diagonal principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
        }
    }
}
