namespace EstruturasDeControle
{
    public class Secretaria : Funcionario
    {
        public string Ramal { get; set; }

        public Secretaria(string nome, double salario, string cpf, string ramal)
            : base(nome, cpf, salario)
        {
            Ramal = ramal;
        }

        public override double CalcularAdicional()
        {
            return Salario * 0.05; // 5% de adicional para a secretaria
        }

        public override void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine($"Bonificação: {GetBonificacao()}");
            Console.WriteLine($"Ramal: {Ramal}");
        }

        public void AtenderTelefone()
        {
            Console.WriteLine("Atendendo telefone!");
        }
    }
}
