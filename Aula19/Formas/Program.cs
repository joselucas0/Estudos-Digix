using System;
using Formas;
namespace Formas{
class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto Círculo
            Circulo circulo = new Circulo(5.5);

            // Exibindo informações do círculo
            circulo.ExibirInformacoes();

            Console.ReadKey();
        }
    }

}