namespace Polimorfismo
{
    public class Horista : Empregado
    {
        public double PrecoHora { get; set; }
        public double HorasTrabalhadas { get; set; }

        public Horista(string nome, string sobrenome, string cpf, double precoHora, double horasTrabalhadas)
            : base(nome, sobrenome, cpf)
        {
            PrecoHora = precoHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Preço por Hora: {PrecoHora:C}, Horas Trabalhadas: {HorasTrabalhadas}");
        }
    }
}
