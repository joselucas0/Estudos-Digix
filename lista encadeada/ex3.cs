// using System;

// class No
// {
//     public string aluno_Nome;
//     public No proximo;

//     public No(string nome)
//     {
//         aluno_Nome = nome;
//         proximo = null;
//     }
// }

// class Pilha
// {
//     private No topo;

//     public Pilha()
//     {
//         topo = null;
//     }

//     // Adicionar um elemento à pilha
//     public void Empilhar(string aluno_Nome)
//     {
//         No novo_No = new No(aluno_Nome);
//         novo_No.proximo = topo;
//         topo = novo_No;
//     }

//     public void Desempilhar()
//     {
//         if (topo != null)
//         {
//             topo = topo.proximo;
//         }
//         else
//         {
//             Console.WriteLine("A pilha está vazia.");
//         }
//     }

    
//     public string VerTopo()
//     {
//         if (topo != null)
//         {
//             return topo.aluno_Nome;  
//         }
//         else
//         {
//             return "A pilha está vazia.";
//         }
//     }

//     // Exibir os elementos da pilha
//     public void Exibir()
//     {
//         No atual = topo;
//         Console.WriteLine("Pilha:");
//         while (atual != null)
//         {
//             Console.WriteLine(atual.aluno_Nome);
//             atual = atual.proximo;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Pilha pilha = new Pilha();

//         // Empilhando alguns elementos
//         pilha.Empilhar("10");
//         pilha.Empilhar("20");
//         pilha.Empilhar("30");

//         // Exibindo a pilha
//         Console.WriteLine("Pilha Original:");
//         pilha.Exibir();

//         // Verificando o topo da pilha sem remover
//         Console.WriteLine("\nVerificando o topo da pilha:");
//         Console.WriteLine($"Topo: {pilha.VerTopo()}");

//         // Desempilhando um elemento
//         pilha.Desempilhar();
//         Console.WriteLine("\nApós desempilhar:");
//         pilha.Exibir();

//         // Verificando o topo novamente
//         Console.WriteLine("\nVerificando o topo da pilha após desempilhar:");
//         Console.WriteLine($"Topo: {pilha.VerTopo()}");
//     }
// }
