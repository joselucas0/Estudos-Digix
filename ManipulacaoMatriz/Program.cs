using System;
using System.IO;

using System;

namespace ManipulacaoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas (N): ");
            int n = EntradaUtils.SolicitarValorPositivo();
            Console.Write("Digite o número de colunas (M): ");
            int m = EntradaUtils.SolicitarValorPositivo();

            int[,] matriz = MatrizUtils.GerarMatrizAleatoria(n, m);
            Console.WriteLine("\nMatriz Gerada:");
            MatrizUtils.ExibirMatriz(matriz);

            while (true)
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Soma das Linhas");
                Console.WriteLine("2 - Soma das Colunas");
                Console.WriteLine("3 - Transpor a Matriz");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");

                string? opcao = Console.ReadLine();
                if (opcao == "4")
                {
                    Console.WriteLine("Encerrando o programa.");
                    break;
                }

                try
                {
                    ProcessarOpcao(opcao, matriz);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        static void ProcessarOpcao(string opcao, int[,] matriz)
        {
            switch (opcao)
            {
                case "1":
                    var somaLinhas = OperacoesMatriz.CalcularSomaLinhas(matriz);
                    Console.WriteLine("\nSoma das Linhas:");
                    EntradaUtils.ExibirArray(somaLinhas);
                    ResultadoCSV.SalvarResultado("\nSoma das Linhas\n", somaLinhas);
                    break;

                case "2":
                    var somaColunas = OperacoesMatriz.CalcularSomaColunas(matriz);
                    Console.WriteLine("\nSoma das Colunas:");
                    EntradaUtils.ExibirArray(somaColunas);
                    ResultadoCSV.SalvarResultado("\nSoma das Colunas\n", somaColunas);
                    break;

                case "3":
                    var transposta = OperacoesMatriz.TransporMatriz(matriz);
                    Console.WriteLine("\nMatriz Transposta:");
                    MatrizUtils.ExibirMatriz(transposta);
                    ResultadoCSV.SalvarMatriz("\nMatriz Transposta\n", transposta);
                    break;

                default:
                    Console.WriteLine("Opção inválida! Escolha novamente.");
                    break;
            }
        }
    }
}