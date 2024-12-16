using System;
namespace Composicao{
    

    class Program
    {
        static void Main(string[] args)
        {
            // Criando um computador e ligando-o
            Computador computador = new Computador();
            computador.Ligar();
        }
    }
}