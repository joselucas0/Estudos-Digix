/*using System;

namespace ex_1
{
    class Program
    {
        // Definindo o delegate
        delegate void Funcao(int[] vetor);

        // Função para ler os valores do vetor
        static void LerValores(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }

        // Função para exibir os valores do vetor
        static void ExibirValores(int[] vetor)
        {
            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        // Função para calcular a média dos valores do vetor
        static double CalcularMedia(int[] vetor)
        {
            double soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            return soma / vetor.Length;
        }

        static void Main(string[] args)
        {
            // Criando o vetor de 10 elementos
            int[] vetor = new int[10];

            // Definindo delegados para cada função
            Funcao ler = new Funcao(LerValores);
            Funcao exibir = new Funcao(ExibirValores);

            // Chamando as funções usando o delegate
            ler(vetor);  // Chama a função de leitura
            exibir(vetor);  // Chama a função de exibição

            // Calculando e exibindo a média
            double media = CalcularMedia(vetor);
            Console.WriteLine($"Média dos valores: {media}");
        }
    }
}
*/