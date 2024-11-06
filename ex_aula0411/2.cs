    using System;

    namespace ex_2{
        class Program{

            //definindo delegate
            delegate void Funcao(int [,] matriz);

            // função para preencher a matriz com valores aleatórios
            static void PreencherMatriz(int [,] matriz){

                Random rnd = new Random();
                    for (int i = 0; i < matriz.GetLength(0); i++){
                        for (int j = 0; j < matriz.GetLength(1); j++){
                            matriz[i, j] = rnd.Next(1, 101); // Valores aleatórios entre 1 e 100
                        }
                    }
            }

            // função para calcular e exibir a soma das linhas da matriz
            static void CalcularSomaLinhas(int[,] matriz){
                for (int i = 0; i < matriz.GetLength(0); i++){
                    int somaLinhas = 0;
                    for (int j = 0; j < matriz.GetLength(1); j++){
                        somaLinhas += matriz[i, j];
                    }
                    Console.WriteLine($"Soma da linha {i + 1}: {somaLinhas}");
                }
            }

            static void Main(string[] args){
                //criar matriz
                int[,] matriz = new int[4, 4];
                Funcao preencher = new Funcao(PreencherMatriz);
                preencher(matriz);
            

                Console.WriteLine("Matriz 4x4 com valores aleatórios:");
                for (int i = 0; i < matriz.GetLength(0); i++){
                    for (int j = 0; j < matriz.GetLength(1); j++){
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // calcular e exibir a soma das linhas
                
                Console.WriteLine("\nSoma dos elementos de cada linha:");
                Funcao calcular = new Funcao(CalcularSomaLinhas);
                calcular(matriz);
            }
        }
    }