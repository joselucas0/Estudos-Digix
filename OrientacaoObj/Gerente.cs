namespace EstruturasDeControle
{
    public class Gerente : Funcionario
    {
        public string Setor { get; set; }

        public Gerente(string nome, string cpf, double salario, string setor)
            : base(nome, cpf, salario)
        {
            Setor = setor;
        }

        public override double CalcularAdicional()
        {
            return Salario * 0.20; // 20% de adicional para o gerente
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {Cpf}");
            System.Console.WriteLine($"Salário: {Salario}");
            System.Console.WriteLine($"Setor: {Setor}");
            System.Console.WriteLine($"Bonificação: {CalcularAdicional()}");
        }
    }
}
