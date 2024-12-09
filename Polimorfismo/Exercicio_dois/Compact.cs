namespace Exercicio_dois
{
    public class CompactDisc : Produto
    {
        public string Artista { get; set; }
        public string Gravadora { get; set; }

        public CompactDisc(int codigo, double preco, string artista, string gravadora)
            : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public void SetArtista(string artista)
        {
            Artista = artista;
        }

        public string GetArtista()
        {
            return Artista;
        }

        public void SetGravadora(string gravadora)
        {
            Gravadora = gravadora;
        }

        public string GetGravadora()
        {
            return Gravadora;
        }

        public override void AtualizaPreco(double preco)
        {
            Preco = preco;
        }

        public override string ToString()
        {
            return base.ToString() + $", Artista: {Artista}, Gravadora: {Gravadora}";
        }
    }
}
