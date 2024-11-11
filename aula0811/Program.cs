using System;

class Program {
    // Função que determina se o número é par ou ímpar e imprime o resultado
    static int ParouImpar(int n) {
        if (n % 2 == 0) {
            return 1;
        } else {
            return 2;
        }
    }
     static int ParouImpar(double n) {
        if (n % 2 == 0) {
            return 1;
        } else {
            return 2;
        }
    }

    static void Main() {
        // Chama a função e exibe se o número é par ou ímpar
        ParouImpar(10);
    }
}
