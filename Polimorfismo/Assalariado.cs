namespace Polimorfismo
{
    public class Assalariado : Empregado
    {
        public double Salario { get; set; }

        public Assalariado(string nome, string sobrenome, string cpf, double salario)
            : base(nome, sobrenome, cpf)
        {
            Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Salário: {Salario:C}");
        }
    }
}
