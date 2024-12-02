using System;

class No
{
    public string valor;
    public No proximo;

    public No(string valor)
    {
        this.valor = valor;
        this.proximo = null;
    }
}

class Fila
{
    private No inicio;
    private No fim;

    public Fila()
    {
        inicio = null;
        fim = null;
    }

    // Adicionar um elemento à fila
    public void Enfileirar(string valor)
    {
        No novoNo = new No(valor);
        if (fim != null)
        {
            fim.proximo = novoNo;
        }
        fim = novoNo;

        if (inicio == null)
        {
            inicio = novoNo;
        }
    }

    // Remover um elemento da fila
    public void Desenfileirar()
    {
        if (inicio != null)
        {
            inicio = inicio.proximo;
            if (inicio == null)
            {
                fim = null; // A fila ficou vazia
            }
        }
        else
        {
            Console.WriteLine("A fila está vazia.");
        }
    }

    // Exibir os elementos da fila
    public void Exibir()
    {
        No atual = inicio;
        Console.WriteLine("Fila:");
        while (atual != null)
        {
            Console.WriteLine(atual.valor);
            atual = atual.proximo;
        }
    }

    // Inserir os elementos de outra fila no final da fila atual
    public void InserirFila(Fila outraFila)
    {
        if (outraFila.inicio == null)
        {
            Console.WriteLine("A segunda fila está vazia.");
            return;
        }

        if (fim != null)
        {
            fim.proximo = outraFila.inicio;
        }
        else
        {
            inicio = outraFila.inicio; // Se a fila atual estava vazia
        }

        fim = outraFila.fim;
    }

    // Calcular o tamanho da fila
    public int Tamanho()
    {
        int contador = 0;
        No atual = inicio;
        while (atual != null)
        {
            contador++;
            atual = atual.proximo;
        }
        return contador;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fila fila1 = new Fila();

        // Enfileirando elementos na fila 1
        fila1.Enfileirar("10");
        fila1.Enfileirar("20");
        fila1.Enfileirar("30");

        // Exibindo a fila
        Console.WriteLine("Fila 1:");
        fila1.Exibir();

        Console.WriteLine($"\nTamanho da fila: {fila1.Tamanho()}");

        fila1.Desenfileirar();

    
        Console.WriteLine("\nFila 1 após desenfileirar um elemento:");
        fila1.Exibir();

   
        Console.WriteLine($"\nNovo tamanho da fila: {fila1.Tamanho()}");
    }
}
