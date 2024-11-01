/*using System;

namespace MatrizSomaMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

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

            // Inicializando o maior e o menor elemento com o primeiro valor da matriz
            int maior = matriz[0, 0];
            int menor = matriz[0, 0];

            // Encontrando o maior e o menor elemento na matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }

            // Calculando a soma do maior e do menor elemento
            int soma = maior + menor;

            // Exibindo os resultados
            Console.WriteLine($"\nMaior elemento: {maior}");
            Console.WriteLine($"Menor elemento: {menor}");
            Console.WriteLine($"Soma do maior com o menor elemento: {soma}");
        }
    }
}
*/