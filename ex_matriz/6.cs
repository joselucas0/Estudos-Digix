/*using System;

namespace ProdutoDuasMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int[,] produtoMatrizes = new int[4, 4];

            // Lendo a primeira matriz
            Console.WriteLine("Digite os elementos da matriz A (4x4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento A[{i + 1},{j + 1}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Lendo a segunda matriz
            Console.WriteLine("\nDigite os elementos da matriz B (4x4):");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento B[{i + 1},{j + 1}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculando o produto das duas matrizes
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    produtoMatrizes[i, j] = 0; // Inicializa a posição com 0
                    for (int k = 0; k < 4; k++)
                    {
                        produtoMatrizes[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            // Exibindo o resultado do produto
            Console.WriteLine("\nProduto das Matrizes A e B:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(produtoMatrizes[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/