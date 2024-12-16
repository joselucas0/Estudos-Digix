using System;
namespace Aula19{
    

public class Pix : IPagamento
    {
        public string ChavePix { get; set; }
        public string NomeTitular { get; set; }
        public string Cpf { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        // Construtor
        public Pix(string chavePix, string nomeTitular, string cpf, double valor)
        {
            ChavePix = chavePix;
            NomeTitular = nomeTitular;
            Cpf = cpf;
            Valor = valor;
            DataPagamento = DateTime.Now;
        }

        // Implementação de IPagamento
        public void RealizarPagamento()
        {
            Console.WriteLine($"Pagamento Pix no valor de R$ {Valor} para {NomeTitular} ({ChavePix}) realizado.");
        }

        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante Pix: Valor R$ {Valor}, Data: {DataPagamento}");
        }
    }

}