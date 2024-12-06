namespace EstruturasDeControle
{
    public class Gerente : Funcionario
    {
        public string Setor { get; set; }

        public Gerente(string nome, double salario, string cpf, string setor)
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
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salário: {Salario}");
            System.Console.WriteLine($"Setor: {Setor}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao()}");
        }
    }
}
