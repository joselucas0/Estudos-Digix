using System;

namespace ex3
{
    class Program
    {
        static bool EhPalindromo(int numero)
        {
            // armazena o número original para comparação
            int original = numero;
            int reverso = 0;

            // reverte o número
            while (numero > 0)
            {
                int digito = numero % 10;
                reverso = (reverso * 10) + digito;
                numero /= 10;
            }

            // verificar se o número original é igual ao seu reverso
            return original == reverso;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (EhPalindromo(numero))
            {
                Console.WriteLine($"O número {numero} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é um palíndromo.");
            }
        }
    }
}
