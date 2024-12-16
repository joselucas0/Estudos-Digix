using System;
namespace Aula19{

class Program
{
    static void Main(string[] args)
    {
        // Pagamento com Cartão de Crédito
        CartaoCredito cartao = new CartaoCredito("1234-5678-9101-1121", "José Lucas", "123");
        cartao.Valor = 500.00;
        cartao.ValorAnuidade = 600.00;

        Console.WriteLine("Pagamento com Cartão de Crédito:");
        cartao.RealizarPagamento();
        cartao.ExibirComprovante();
        cartao.CalcularAnuidade();
        cartao.ExibirDetalhesAnuidade();

        Console.WriteLine("\nPagamento via Pix:");
        // Pagamento com Pix
        Pix pagamentoPix = new Pix("jose.pix@banco.com", "José Lucas", "123.456.789-00", 200.00);
        pagamentoPix.RealizarPagamento();
        pagamentoPix.ExibirComprovante();

        Console.ReadKey();
    }
}

}