using System;

namespace EstruturasDeControle
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
        }

        // Definindo o método virtual para ser sobrescrito pelas classes derivadas
        public virtual double CalcularAdicional()
        {
            // Exemplo de cálculo simples de adicional
            double adicional = Salario * 0.10; // 10% de adicional
            return Salario + adicional;
        }

        // Definindo o método virtual para ser sobrescrito pelas classes derivadas
        public virtual void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Salário: {Salario:F2}");
        }

        // Método Main, onde você cria os objetos e chama os métodos
        public static void Main(string[] args)
        {
            // Criação dos funcionários
            Funcionario funcionario = new Funcionario("José Lucas", "123.456.789-00", 3000.00);
            Gerente gerente = new Gerente("Maria Silva", "987.654.321-00", 5000.00, "TI");
            Telefonista telefonista = new Telefonista("Ana Souza", "456.789.123-00", 2500.00, "Estação 3");
            Secretaria secretaria = new Secretaria("Carlos Oliveira", "321.654.987-00", 2000.00, "Ramal 101");

            // Exibindo dados do funcionário
            Console.WriteLine("Dados do Funcionário:");
            funcionario.ImprimirDados();
            Console.WriteLine();

            // Exibindo dados do gerente
            Console.WriteLine("Dados do Gerente:");
            gerente.ImprimirDados();
            Console.WriteLine();

            // Exibindo dados da telefonista
            Console.WriteLine("Dados da Telefonista:");
            telefonista.ImprimirDados();
            Console.WriteLine();

            // Exibindo dados da secretaria
            Console.WriteLine("Dados da Secretaria:");
            secretaria.ImprimirDados();
        }
    }
}
