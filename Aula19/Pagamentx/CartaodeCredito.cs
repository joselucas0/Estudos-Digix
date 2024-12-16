namespace Aula19{
    using System;

public class CartaoCredito : IPagamento, IANuidade
    {
        // Propriedades de pagamento
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string Cvv { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        // Propriedades da anuidade
        public double ValorAnuidade { get; set; }
        public DateTime DataValidade { get; set; }

        // Construtor
        public CartaoCredito(string numeroCartao, string nomeTitular, string cvv)
        {
            NumeroCartao = numeroCartao;
            NomeTitular = nomeTitular;
            Cvv = cvv;
            DataPagamento = DateTime.Now;
            DataValidade = DateTime.Now.AddYears(1);
        }

        // Implementação de IPagamento
        public void RealizarPagamento()
        {
            Console.WriteLine($"Pagamento de R$ {Valor} realizado no cartão {NumeroCartao}.");
        }

        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante: Pagamento de R$ {Valor} em {DataPagamento}.");
        }

        // Implementação de IANuidade
        public void CalcularAnuidade()
        {
            Console.WriteLine($"Anuidade do cartão {NumeroCartao} é de R$ {ValorAnuidade}.");
        }

        public void ExibirDetalhesAnuidade()
        {
            Console.WriteLine($"Detalhes Anuidade - Valor: R$ {ValorAnuidade}, Validade: {DataValidade.ToShortDateString()}.");
        }
    }

}