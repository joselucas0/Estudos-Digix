using System;

namespace CalculadoraCientifica
{
    // Classe base da Calculadora
    class Calculadora
    {
        public virtual double Adicionar(double a, double b) => a + b;

        public virtual double Subtrair(double a, double b) => a - b;

        public virtual double Multiplicar(double a, double b) => a * b;

        public virtual double Dividir(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Divisão por zero não é permitida.");

        public virtual double Potencia(double baseNum, double expoente) => Math.Pow(baseNum, expoente);
        
        public virtual double RaizQuadrada(double numero) => Math.Sqrt(numero);
    }

    // Classe para operações matemáticas
    class OperacoesMatematicas : Calculadora
    {
        public double CalcularSoma(double a, double b) => Adicionar(a, b);
        
        public double CalcularSubtracao(double a, double b) => Subtrair(a, b);
        
        public double CalcularMultiplicacao(double a, double b) => Multiplicar(a, b);
        
        public double CalcularDivisao(double a, double b) => Dividir(a, b);
        
        public double CalcularPotencia(double baseNum, double expoente) => Potencia(baseNum, expoente);
        
        public double CalcularRaizQuadrada(double numero) => RaizQuadrada(numero);
    }

    // Classe para funções trigonométricas
    class FuncoesTrigonometrica : Calculadora
    {
        public double Seno(double angulo) => Math.Sin(DegreesToRadians(angulo));

        public double Cosseno(double angulo) => Math.Cos(DegreesToRadians(angulo));

        public double Tangente(double angulo) => Math.Tan(DegreesToRadians(angulo));

        private double DegreesToRadians(double degrees) => degrees * (Math.PI / 180);
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesMatematicas operacoes = new OperacoesMatematicas();
            FuncoesTrigonometrica trigonometria = new FuncoesTrigonometrica();

            Console.WriteLine("Calculadora Científica");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Potência");
            Console.WriteLine("6. Raiz Quadrada");
            Console.WriteLine("7. Seno");
            Console.WriteLine("8. Cosseno");
            Console.WriteLine("9. Tangente");
            Console.WriteLine("0. Sair");

            while (true)
            {
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "0")
                    break;

                double resultado = 0;
                double a, b;

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o primeiro número: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        resultado = operacoes.CalcularSoma(a, b);
                        break;
                    case "2":
                        Console.Write("Digite o primeiro número: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        resultado = operacoes.CalcularSubtracao(a, b);
                        break;
                    case "3":
                        Console.Write("Digite o primeiro número: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        resultado = operacoes.CalcularMultiplicacao(a, b);
                        break;
                    case "4":
                        Console.Write("Digite o primeiro número: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            resultado = operacoes.CalcularDivisao(a, b);
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                            continue;
                        }
                        break;
                    case "5":
                        Console.Write("Digite a base: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o expoente: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        resultado = operacoes.CalcularPotencia(a, b);
                        break;
                    case "6":
                        Console.Write("Digite o número: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        resultado = operacoes.CalcularRaizQuadrada(a);
                        break;
                    case "7":
                        Console.Write("Digite o ângulo em graus: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        resultado = trigonometria.Seno(a);
                        break;
                    case "8":
                        Console.Write("Digite o ângulo em graus: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        resultado = trigonometria.Cosseno(a);
                        break;
                    case "9":
                        Console.Write("Digite o ângulo em graus: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        resultado = trigonometria.Tangente(a);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
