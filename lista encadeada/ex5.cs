// using System;

// class No
// {
//     public string valor;
//     public No proximo;

//     public No(string valor)
//     {
//         this.valor = valor;
//         this.proximo = null;
//     }
// }

// class Fila
// {
//     private No inicio;
//     private No fim;

//     public Fila()
//     {
//         inicio = null;
//         fim = null;
//     }
// }
//     // Adicionar um elemento à fila
//     public void Enfileirar(string valor)
//     {
//         No novoNo = new No(valor);
//         if (fim != null)
//         {
//             fim.proximo = novoNo;
//         }
//         fim = novoNo;

//         if (inicio == null)
//         {
//             inicio = novoNo;
//         }
//     }

//     public void Desenfileirar()
//     {
//         if (inicio != null)
//         {
//             inicio = inicio.proximo;
//             if (inicio == null)
//             {
//                 fim = null; 
//             }
//         }
//         else
//         {
//             Console.WriteLine("A fila está vazia.");
//         }
//     }

//     public void Exibir()
//     {
//         No atual = inicio;
//         Console.WriteLine("Fila:");
//         while (atual != null)
//         {
//             Console.WriteLine(atual.valor);
//             atual = atual.proximo;
//         }
//     }

//     public void InserirFila(Fila outraFila)
//     {
//         if (outraFila.inicio == null)
//         {
//             Console.WriteLine("A segunda fila está vazia.");
//             return;
//         }

//         if (fim != null)
//         {
//             fim.proximo = outraFila.inicio;
//         }
//         else
//         {
//             inicio = outraFila.inicio; 

//         fim = outraFila.fim;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Fila fila1 = new Fila();
//         Fila fila2 = new Fila();

//         // Enfileirando elementos na fila 1
//         fila1.Enfileirar("10");
//         fila1.Enfileirar("20");

//         // Enfileirando elementos na fila 2
//         fila2.Enfileirar("30");
//         fila2.Enfileirar("40");

//         // Exibindo as filas antes da inserção
//         Console.WriteLine("Fila 1 antes de inserir os elementos da Fila 2:");
//         fila1.Exibir();
//         Console.WriteLine("Fila 2:");
//         fila2.Exibir();

//         // Inserindo os elementos da fila 2 no final da fila 1
//         fila1.InserirFila(fila2);

//         // Exibindo a fila 1 após a inserção
//         Console.WriteLine("\nFila 1 após inserir os elementos da Fila 2:");
//         fila1.Exibir();
//     }
// }
