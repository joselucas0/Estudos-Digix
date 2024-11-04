using System;

namespace ex_2{
    class Program{
        // Criar matriz 4x4
        static int[,] matriz = new int[4, 4];
        // Gerador de números aleatórios
        static Random rnd = new Random();

        // Função para preencher a matriz com valores aleatórios
        static void PreencherMatriz(){
            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    matriz[i, j] = rnd.Next(1, 101); // Valores aleatórios entre 1 e 100
                }
            }
        }

        // Função para calcular e exibir a soma das linhas da matriz
        static void CalcularSomaLinhas(){
            for (int i = 0; i < matriz.GetLength(0); i++){
                int somaLinhas = 0;
                for (int j = 0; j < matriz.GetLength(1); j++){
                    somaLinhas += matriz[i, j];
                }
                Console.WriteLine($"Soma da linha {i + 1}: {somaLinhas}");
            }
        }

        static void Main(string[] args){
            // Preencher a matriz com valores aleatórios
            PreencherMatriz();

            // Exibir a matriz
            Console.WriteLine("Matriz 4x4 com valores aleatórios:");
            for (int i = 0; i < matriz.GetLength(0); i++){
                for (int j = 0; j < matriz.GetLength(1); j++){
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Calcular e exibir a soma das linhas
            Console.WriteLine("\nSoma dos elementos de cada linha:");
            CalcularSomaLinhas();
        }
    }
}
