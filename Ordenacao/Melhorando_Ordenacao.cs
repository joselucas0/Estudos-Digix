using System;

class Program
{
    static void BubbleSort(int[] vetor)  //1 - 2
    {
        int n = vetor.Length;
        bool cont;
        for (int i = 0; i < n - 1; i++)
        {
            cont = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    int aux = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = aux;
                    cont = true;
                }
            }
            if (!cont)
            {
                break;  //interrompe a execução
            }
        }
    }

    static void SelectionSort(int[] vetor) //3
    {
        int n = vetor.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vetor[j] < vetor[min])
                {
                    min = j; // Atualiza o índice do menor elemento
                }
            }
            // Troca os elementos
            int aux = vetor[i];
            vetor[i] = vetor[min];
            vetor[min] = aux;
        }
    }

    static void Main()
    {
        Console.WriteLine("Escolha o algoritmo de ordenação:");
        Console.WriteLine("1. BubbleSort");
        Console.WriteLine("2. SelectionSort");

        int opcao = int.Parse(Console.ReadLine());

        int[] vetor = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("\nVetor antes da ordenação:");
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }

        switch (opcao)
        {
            case 1:
                BubbleSort(vetor);
                Console.WriteLine("\nVetor após a ordenação com BubbleSort:");
                break;
            case 2:
                SelectionSort(vetor);
                Console.WriteLine("\nVetor após a ordenação com SelectionSort:");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
    }
}
