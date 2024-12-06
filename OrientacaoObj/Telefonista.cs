namespace EstruturasDeControle
{
    public class Telefonista : Funcionario
    {
        public string EstacaoDeTrabalho { get; set; }

        public Telefonista(string nome, double salario, string cpf, string estacaoDeTrabalho)
            : base(nome, cpf, salario)
        {
            EstacaoDeTrabalho = estacaoDeTrabalho;
        }

        // Sobrescrevendo o método de bonificação
        public override double CalcularAdicional()
        {
            return Salario * 0.10; // 10% de adicional para a telefonista
        }


        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salário: {Salario}");
            System.Console.WriteLine($"Estação de Trabalho: {EstacaoDeTrabalho}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao()}");
        }
    }
}
