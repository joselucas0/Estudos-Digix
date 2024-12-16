namespace Aula19{
    public interface IPagamento
    {
        double Valor { get; set; }
        DateTime DataPagamento { get; set; }
        void RealizarPagamento();
        void ExibirComprovante();
    }

}