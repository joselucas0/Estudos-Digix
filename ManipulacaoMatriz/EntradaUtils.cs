using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulacaoMatriz
{
    static class EntradaUtils
    {
        public static int SolicitarValorPositivo()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0)
                    return valor;
                Console.Write("Entrada inválida! Digite um número inteiro positivo: ");
            }
        }

        public static void ExibirArray(int[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}