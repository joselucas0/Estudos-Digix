/*using System;

namespace MatrizDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int somaDiagonalPrincipal = 0;

            // Lendo os elementos da matriz 4x4
            Console.WriteLine("Digite os elementos da matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculando a soma dos elementos da diagonal principal
            for (int i = 0; i < 4; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
            }

            // Exibindo o resultado
            Console.WriteLine($"\nSoma dos elementos da diagonal principal: {somaDiagonalPrincipal}");
        }
    }
}*/
