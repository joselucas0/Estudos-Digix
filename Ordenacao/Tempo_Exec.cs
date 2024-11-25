using System;
using System.Diagnostics;

class Program
{
    // Função para ordenar o vetor usando o algoritmo Bubble Sort
    static void BubbleSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    int aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                }
            }
        }
    }

    // Função para ordenar o vetor usando o algoritmo Selection Sort
    static void SelectionSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] < vetor[min])
                {
                    min = j;
                }
            }
            int aux = vetor[i];
            vetor[i] = vetor[min];
            vetor[min] = aux;
        }
    }

    // Função para ordenar o vetor usando o algoritmo Insertion Sort
    static void InsertionSort(int[] vetor)
    {
        int n = vetor.Length;
        for (int i = 1; i < n; i++)
        {
            int key = vetor[i];
            int j = i - 1;
            while (j >= 0 && vetor[j] > key)
            {
                vetor[j + 1] = vetor[j];
                j = j - 1;
            }
            vetor[j + 1] = key;
        }
    }

    static void Main()
    {
        // Gerando lista de 100 números aleatórios
        Random rand = new Random();
        int[] lista = new int[1000];
        for (int i = 0; i < lista.Length; i++)
        {
            lista[i] = rand.Next(1, 1000);
        }

        // Solicitando ao usuário qual algoritmo ele deseja usar
        Console.WriteLine("Escolha o algoritmo de ordenação:");
        Console.WriteLine("1 - Bubble Sort");
        Console.WriteLine("2 - Selection Sort");
        Console.WriteLine("3 - Insertion Sort");
        int escolha = int.Parse(Console.ReadLine());

        // Clonando a lista original para cada algoritmo não afetar o outro
        int[] listaCopia = new int[lista.Length];
        Array.Copy(lista, listaCopia, lista.Length);

        // Medindo o tempo de execução
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        // Executando o algoritmo escolhido
        switch (escolha)
        {
            case 1:
                BubbleSort(listaCopia);
                break;
            case 2:
                SelectionSort(listaCopia);
                break;
            case 3:
                InsertionSort(listaCopia);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        stopwatch.Stop();

        // Mostrando o tempo de execução
        Console.WriteLine("Tempo de execução: " + stopwatch.ElapsedMilliseconds + "ms");
    }
}
