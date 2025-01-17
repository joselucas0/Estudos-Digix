using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulacaoMatriz
{
    static class OperacoesMatriz
    {
        public static int[] CalcularSomaLinhas(int[,] matriz)
        {
            int[] somaLinhas = new int[matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    somaLinhas[i] += matriz[i, j];
            return somaLinhas;
        }

        public static int[] CalcularSomaColunas(int[,] matriz)
        {
            int[] somaColunas = new int[matriz.GetLength(1)];
            for (int j = 0; j < matriz.GetLength(1); j++)
                for (int i = 0; i < matriz.GetLength(0); i++)
                    somaColunas[j] += matriz[i, j];
            return somaColunas;
        }

        public static int[,] TransporMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] transposta = new int[colunas, linhas];
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    transposta[j, i] = matriz[i, j];
            return transposta;
        }
    }
}
