using System;

namespace MatrizSoma{
    class Program{
        // Função para obter o comprimento de uma dimensão específica da matriz
        static int GetLength(int[,] matriz, int dimension){
            return matriz.GetLength(dimension);
        }

        static void Main(string[] args){
            int[,] matriz = new int[4, 4];
            int soma = 0;

            Console.WriteLine("Digite os elementos da matriz 4x4:");
            for (int i = 0; i < GetLength(matriz, 0); i++){
                for (int j = 0; j < GetLength(matriz, 1); j++){
                    Console.Write($"Elemento [{i+1},{j+1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    soma += matriz[i, j];  // Soma os elementos conforme eles são inseridos
                }
            }

            Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
        }
    }
}
