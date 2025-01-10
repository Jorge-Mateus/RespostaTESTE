using System;

namespace Repostssa
{
    public class PertenceAFibonacci
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonacci:");

            ImprimirFibonacci(numero);

            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }

        static bool PertenceFibonacci(int num)
        {
            int a = 0, b = 1;

            while (b < num)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == num;
        }

        static void ImprimirFibonacci(int limite)
        {
            int a = 0, b = 1;
            Console.Write(a + " " + b + " "); // Imprime os dois primeiros números

            while (b <= limite)
            {
                int temp = b;
                b = a + b;
                a = temp;

                if (b <= limite)
                {
                    Console.Write(b + " ");
                }
            }

            Console.WriteLine(); // Para quebrar a linha após a sequência
        }
    }
}
