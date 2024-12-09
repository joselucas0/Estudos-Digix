namespace Polimorfismo
{
    public abstract class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        // Construtor para inicializar as propriedades
        protected Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }

        public abstract double Vencimento();

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} {Sobrenome}, CPF: {CPF}");
        }
    }
}
