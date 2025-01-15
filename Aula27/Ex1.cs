using System;
using System.IO;
using System.Globalization;

namespace CsvProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho completo do arquivo .csv:");
            string sourceFilePath = Console.ReadLine();

            // Caminho para o arquivo de saída
            string outputDirectory = Path.Combine(Path.GetDirectoryName(sourceFilePath), "out");
            Directory.CreateDirectory(outputDirectory);
            string outputFilePath = Path.Combine(outputDirectory, "summary.csv");

            try
            {
                // Processar o arquivo CSV
                string[] lines = File.ReadAllLines(sourceFilePath);

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        // Extrair os campos
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        // Calcular o total
                        double total = price * quantity;

                        // Escrever no arquivo de saída
                        writer.WriteLine($"{name},{total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                Console.WriteLine("Arquivo 'summary.csv' gerado com sucesso na pasta 'out'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
