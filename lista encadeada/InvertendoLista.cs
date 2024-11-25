using System;

struct No
{
    public int Valor;
    public No* prox;
    public No* ant;
}

unsafe struct Lista
{
    public No* Inicio;
}

unsafe class Program
{
    static void ReverterLista(ref Lista lista)
    {
        if (lista.Inicio == null)
        {
            return; // Lista vazia
        }

        No* atual = lista.Inicio;
        No* temp = null;

        // Inverter os ponteiros 'prox' e 'ant' para cada nó
        while (atual != null)
        {
            temp = atual->ant;
            atual->ant = atual->prox;
            atual->prox = temp;

            // Avançar para o próximo nó (usando o ponteiro já invertido)
            atual = atual->ant;
        }

        // Ajustar o ponteiro de início da lista
        if (temp != null)
        {
            lista.Inicio = temp->ant;
        }
    }

    static void Main()
    {
        // Alocação manual para criar os nós
        No no1, no2, no3;

        no1.Valor = 1;
        no2.Valor = 2;
        no3.Valor = 3;

        no1.prox = &no2;
        no1.ant = null;

        no2.prox = &no3;
        no2.ant = &no1;

        no3.prox = null;
        no3.ant = &no2;

        // Criar a lista
        Lista lista;
        lista.Inicio = &no1;

        // Reverter a lista
        ReverterLista(ref lista);

        // Mostrar os valores após a reversão
        No* atual = lista.Inicio;
        while (atual != null)
        {
            Console.WriteLine(atual->Valor);
            atual = atual->prox;
        }
    }
}
