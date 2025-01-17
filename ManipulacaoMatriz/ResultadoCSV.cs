using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulacaoMatriz
{
    static class ResultadoCSV
    {
        public static void SalvarResultado(string descricao, int[] resultados)
        {
            try
            {
                using (var writer = new StreamWriter("resultado.csv", true))
                {
                    writer.WriteLine(descricao);
                    writer.WriteLine(string.Join(",", resultados));
                }
                Console.WriteLine("Resultados salvos em 'resultado.csv'.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro ao salvar no arquivo CSV: {ex.Message}");
            }
        }

        public static void SalvarMatriz(string descricao, int[,] matriz)
        {
            try
            {
                using (var writer = new StreamWriter("resultado.csv", true))
                {
                    writer.WriteLine(descricao);
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            writer.Write(matriz[i, j]);
                            if (j < matriz.GetLength(1) - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
                Console.WriteLine("Resultados salvos em 'resultado.csv'.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro ao salvar no arquivo CSV: {ex.Message}");
            }
        }
    }
}