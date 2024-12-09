namespace Polimorfismo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando objetos de diferentes tipos de empregados
            Empregado assalariado = new Assalariado("José", "Silva", "123.456.789-00", 3000.00);
            Empregado horista = new Horista("Ana", "Oliveira", "987.654.321-00", 50.00, 160);
            Empregado comissionado = new Comissionado("Carlos", "Santos", "456.789.123-00", 20000.00, 0.10);

            // Imprimindo os dados
            assalariado.ImprimirDados();
            System.Console.WriteLine($"Vencimento: {assalariado.Vencimento():C}\n");

            horista.ImprimirDados();
            System.Console.WriteLine($"Vencimento: {horista.Vencimento():C}\n");

            comissionado.ImprimirDados();
            System.Console.WriteLine($"Vencimento: {comissionado.Vencimento():C}\n");
        }
    }
}
