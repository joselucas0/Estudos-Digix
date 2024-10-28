using System;

namespace CalculadoraFinanceira
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Financeira");
                Console.WriteLine("1. Juros Simples");
                Console.WriteLine("2. Juros Compostos");
                Console.WriteLine("3. Valor Presente Líquido (VPL)");
                Console.WriteLine("4. Taxa Interna de Retorno (TIR)");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CalcularJurosSimples();
                        break;
                    case "2":
                        CalcularJurosCompostos();
                        break;
                    case "3":
                        CalcularVPL();
                        break;
                    case "4":
                        CalcularTIR();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine(); // Linha em branco para melhor visualização
            }
        }

        static void CalcularJurosSimples()
        {
            Console.Write("Capital Inicial (C): ");
            double capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de Juros (i) em %: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Tempo (t) em anos: ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            double montante = capital * (1 + taxa * tempo);
            Console.WriteLine($"Montante: R$ {montante:F2}");
        }

        static void CalcularJurosCompostos()
        {
            Console.Write("Capital Inicial (C): ");
            double capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de Juros (i) em %: ");
            double taxa = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Número de Períodos (n): ");
            int periodos = Convert.ToInt32(Console.ReadLine());

            double montante = capital * Math.Pow((1 + taxa), periodos);
            Console.WriteLine($"Montante: R$ {montante:F2}");
        }

        static void CalcularVPL()
        {
            Console.Write("Valor do Investimento (I): ");
            double investimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Taxa de Desconto (r) em %: ");
            double taxaDesconto = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Número de Fluxos de Caixa (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double vpl = -investimento;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Fluxo de Caixa {i}: ");
                double fluxo = Convert.ToDouble(Console.ReadLine());
                vpl += fluxo / Math.Pow((1 + taxaDesconto), i);
            }

            Console.WriteLine($"Valor Presente Líquido (VPL): R$ {vpl:F2}");
        }

        static void CalcularTIR()
        {
            Console.Write("Valor do Investimento (I): ");
            double investimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número de Fluxos de Caixa (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] fluxos = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Fluxo de Caixa {i + 1}: ");
                fluxos[i] = Convert.ToDouble(Console.ReadLine());
            }

            double tir = CalculaTIR(investimento, fluxos);
            Console.WriteLine($"Taxa Interna de Retorno (TIR): {tir * 100:F2}%");
        }

        static double CalculaTIR(double investimento, double[] fluxos)
        {
            double tir = 0.0;
            double erro = 0.0001;
            double taxaMin = 0.0;
            double taxaMax = 1.0;

            while (taxaMax - taxaMin > erro)
            {
                tir = (taxaMin + taxaMax) / 2.0;
                double npv = -investimento;

                for (int i = 0; i < fluxos.Length; i++)
                {
                    npv += fluxos[i] / Math.Pow((1 + tir), i + 1);
                }

                if (npv > 0)
                    taxaMin = tir;
                else
                    taxaMax = tir;
            }

            return tir;
        }
    }
}
