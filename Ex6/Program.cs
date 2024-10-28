using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para inserir um número
        Console.Write("Digite um número para ver sua tabuada: ");
        int numero, a, b;
        //ler o número digitado
        numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Indique onde vai começar e terminar a tabuada: ");
        //ler os limites da tabuada
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

       
        // Imprime a tabuada
        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = a; i <= b; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
