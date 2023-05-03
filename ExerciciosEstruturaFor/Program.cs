using System;
using System.Globalization;

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
             * essas informações seguinto 'in' para dentro do intervalo e 'out' para fora do intervalo. 

            Console.Write("Quantos números você vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    dentro++; 
                }
                else {
                    fora++;
                }
            }

            Console.WriteLine("In: " + dentro);
            Console.WriteLine("Out: " + fora); */


            /* Exercício 03 - Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.


            Console.Write("Olá, quantos testes serão realizados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5) / 10;

                Console.WriteLine("Média: " + media.ToString("F1", CultureInfo.InvariantCulture));
            } */


            /* Exercício 04 - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
             * segundo. Se o denominador for igual a zero, mostrar a mensagem "Divisão impossível". */

            /*Console.Write("Quantas divisões serão realizadas? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                int a = int.Parse(valores[0]);
                int b = int.Parse(valores[1]);

                if (a < 0) {
                    Console.WriteLine("Divisão impossível.");
                }
                else {
                    double divisao = (double)a / b;
                    Console.WriteLine("Resultado: " + divisao);
                }
            } */

            /* Exercício 05 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3)* .. * 1;.
             * Lembrando que, por definição, fatorial de 0 é 1;
             */

            /* Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= n; i++) {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial); */

            /* Exercício 06 - Ler um número inteiro N e calcular todos os seus divisores. */

            /* Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            } */

            /* Exercício 07 - Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
             * começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor. */

            /*Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0) {
                for (int i = 1; i <= n; i++) {
                    Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                }
            }
            else {
                Console.WriteLine("Número menor ou igual a zero, impossível calcular!");
            } */







        }
    }
}