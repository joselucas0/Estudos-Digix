namespace Polimorfismo
{
    public class Comissionado : Empregado
    {
        public double TotalVenda { get; set; }
        public double TaxaComissao { get; set; }

        public Comissionado(string nome, string sobrenome, string cpf, double totalVenda, double taxaComissao)
            : base(nome, sobrenome, cpf)
        {
            TotalVenda = totalVenda;
            TaxaComissao = taxaComissao;
        }

        public override double Vencimento()
        {
            return TotalVenda * TaxaComissao;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Total de Vendas: {TotalVenda:C}, Taxa de Comissão: {TaxaComissao:P}");
        }
    }
}
