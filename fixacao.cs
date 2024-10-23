using System;

namespace fixacao
{
    internal class Program{
        static void Mainn(string[] args){
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo preco é: ${preco1}");
            Console.WriteLine($"{produto2}, cujo preco é: ${preco2}");
            Console.WriteLine($"Registro {idade} anos de idade, {codigo} e {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais:): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("C", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}