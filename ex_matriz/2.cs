/*using System;

namespace MaiorMenorVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            // Lendo o vetor com 10 inteiros
            Console.WriteLine("Digite 10 números inteiros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Inicializando maior e menor com o primeiro elemento do vetor
            int maior = numeros[0];
            int menor = numeros[0];

            // Encontrando o maior e o menor valor
            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            // Exibindo os resultados
            Console.WriteLine($"\nMaior elemento: {maior}");
            Console.WriteLine($"Menor elemento: {menor}");
        }
    }
}
*/