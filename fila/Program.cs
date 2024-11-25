    namespace fila
{
    public class Program
    {
        public class Fila
        {
            static int[] fila = new int[10];
            static int ant = 0; // Indica a posição da ant da fila
            static int prox = 0;   // Indica a posição do final da fila

            // Método para inserir um valor na fila
            static void Inserir(int valor)
            {
                // Verifica se a fila não está cheia
                if (prox < fila.Length)
                {
                    fila[prox] = valor; // Insere o valor no final da fila
                    prox++; // Incrementa a posição do final
                }
                else
                {
                    System.Console.WriteLine("Fila cheia, não é possível inserir.");
                }
            }

            // Método para remover um valor da fila (FIFO)
            static void Remover()
            {
                // Verifica se a fila não está vazia
                if (ant < prox)
                {
                    System.Console.WriteLine($"Removido: {fila[ant]}");
                    ant++; // Move a ant da fila para a próxima posição
                }
                else
                {
                    System.Console.WriteLine("Fila vazia, não há elementos para remover.");
                }
            }

            // Método para listar os elementos da fila
            static void Listar()
            {
                // Percorre da ant até o final da fila
                for (int i = ant; i < prox; i++)
                {
                    System.Console.WriteLine(fila[i]);
                }
            }

            public static void Main()
            {
                Inserir(5);
                Inserir(3);
                Inserir(7);
                Inserir(1);
                Inserir(2);
                Listar(); // Mostra os elementos na fila
                Remover(); // Remove o primeiro elemento
                Listar(); // Mostra os elementos restantes
            }
        }
    }
}
