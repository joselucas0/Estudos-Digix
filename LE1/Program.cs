using System;

class Program
{
    static void Main(string[] args)
    {
        // Recebe até 10 inteiros positivos
        int[] numeros = new int[10];
        int i = 0;

        while (i < numeros.Length)
        {
            Console.Write($"Digite o {i + 1}º número (ou -1 para sair): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= -1)
            {
                break;
            }

            numeros[i] = numero;
            i++;
        }

        // Chama a função apenas se houver entradas válidas
        if (i > 0)
        {
            Console.WriteLine($"O menor número é: {CalculaMenor(numeros, i)}");
        }
        else
        {
            Console.WriteLine("Nenhum número válido foi inserido.");
        }
    }

    // Função que calcula o menor número considerando o número de entradas válidas
    static int CalculaMenor(int[] numeros, int quantidade)
    {
        int menor = numeros[0];
        for (int i = 1; i < quantidade; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return menor;
    }
}
