namespace Exercicio_dois
{
    public abstract class Produto
    {
        public int Codigo { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public abstract void AtualizaPreco(double preco);

        public override string ToString()
        {
            return $"Código: {Codigo}, Preço: {Preco:C}";
        }
    }
}
