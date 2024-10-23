using System;

namespace Teste
{
    internal class Teste
    {
        static void Mainnn(string[] args)
        {
            // Criando variáveis
            string nome = "José";
            int idade = 25;
            double altura = 1.75;
            bool estudante = true;
            char inicialDoNome = 'J';
            decimal saldo = 1500.50m;

            Console.WriteLine($"Nome: {nome}" + ", Idade: " + idade + ", Altura: " + altura + 
                              $", Estudante: {estudante}" + ", Inicial do Nome: " + inicialDoNome + 
                              ", Saldo: " + saldo);
        }
    }
}
