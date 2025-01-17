using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulacaoMatriz
{
    static class MatrizUtils
    {
        public static int[,] GerarMatrizAleatoria(int linhas, int colunas)
        {
            var random = new Random();
            int[,] matriz = new int[linhas, colunas];
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = random.Next(1, 101);
            return matriz;
        }

        public static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}