namespace Aula19{
    public interface IANuidade
    {
        double ValorAnuidade { get; set; }
        DateTime DataValidade { get; set; }
        void CalcularAnuidade();
        void ExibirDetalhesAnuidade();
    }


}