using System;

namespace ExerciciosEstruturaFor {
    class Program {
        static void Main(string[] args) {

            /* Exercício 01 - Leia uma valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
             * X, se for o caso. 

            Console.Write("Digite um valor inteiro entre 0 e 1000: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            } */

            /* Exercício 02 - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
             * essas informações seguinto 'in' para dentro do intervalo e 'out' para fora do intervalo. */

            Console.Write("Quantos números você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++) {
                n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20) {
                    dentro++; 
                }
                else {
                    fora++;
                }
            }

        }
    }
}