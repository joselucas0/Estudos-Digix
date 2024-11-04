    using System;

    namespace ex_1{
        class Program{
            //criar vetor de 10
            static void Main(string[] args){
                int[] vetor = new int[10];
                //ler valores do teclado
                for (int i = 0; i < 10; i++){
                    Console.Write($"Digite o {i+1}º número: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }
                //mostrar valores do vetor
                Console.WriteLine("Valores do vetor:");
                for (int i = 0; i < 10; i++){
                    Console.WriteLine(vetor[i]);
                }
                //calcular a media dos valores do vetor
                double media = 0;
                for (int i = 0; i < 10; i++){
                    media += vetor[i];
                }
                media /= 10;
                Console.WriteLine($"Média dos valores: {media}");
            }
        }
    }