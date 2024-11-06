using System;

namespace MatrizSoma{
    class Program{
        static int GetLength(int[,,] matriz, int dimension){
            return matriz.GetLength(dimension);
        }

        static void Main(string[] args){
            int[,,] matriz = new int[3, 3, 3];
            int soma = 0;

            Console.WriteLine("Digite os elementos da matriz 3x3x3:");
            for (int i = 0; i < GetLength(matriz, 0); i++){
                for (int j = 0; j < GetLength(matriz, 1); j++){
                    for (int k = 0; k < GetLength(matriz, 2); k++){
                        Console.Write($"Elemento [{i+1},{j+1},{k+1}]: ");
                        matriz[i, j, k] = int.Parse(Console.ReadLine());
                        soma += matriz[i, j, k];  
                    }
                }
            }

            Console.WriteLine($"\nA soma de todos os elementos da matriz é: {soma}");
        }
    }
}
