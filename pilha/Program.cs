namespace DadosAbstratos
{
    public class Program
    {
        public class Pilha
        {
            static int[] pilha = new int[10];
            static int topo = -1; // Indica a posição do topo da pilha (inicialmente vazia)

            // Método para inserir um valor na pilha
            static void Inserir(int valor)
            {
                // Verifica se a pilha não está cheia
                if (topo < pilha.Length - 1)
                {
                    topo++; // Move o topo para a próxima posição
                    pilha[topo] = valor; // Insere o valor no topo da pilha
                }
                else
                {
                    System.Console.WriteLine("Pilha cheia, não é possível inserir.");
                }
            }

            // Método para remover um valor da pilha (LIFO)
            static void Remover()
            {
                // Verifica se a pilha não está vazia
                if (topo >= 0)
                {
                    System.Console.WriteLine($"Removido: {pilha[topo]}");
                    topo--; // Decrementa o topo para remover o valor
                }
                else
                {
                    System.Console.WriteLine("Pilha vazia, não há elementos para remover.");
                }
            }

            // Método para listar os elementos da pilha
            static void Listar()
            {
                // Percorre a pilha do topo até a base
                for (int i = topo; i >= 0; i--)
                {
                    System.Console.WriteLine(pilha[i]);
                }
            }

            public static void Main()
            {
                Inserir(5);
                Inserir(3);
                Inserir(7);
                Inserir(1);
                Inserir(2);
                Listar(); // Mostra os elementos na pilha
                Remover(); // Remove o topo da pilha
                Listar(); // Mostra os elementos restantes
            }
        }
    }
}
