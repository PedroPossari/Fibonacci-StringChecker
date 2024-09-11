using System;
using static Ex1.FibonacciApp;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int number = int.Parse(Console.ReadLine());

            FibonacciSequence fibonacci = new FibonacciSequence();

            var sequence = fibonacci.GenerateFibonacci(number);

            bool isInSequence = fibonacci.IsNumberInFibonacci(number, sequence);

            Console.WriteLine("Sequência de Fibonacci até " + number + ": " + string.Join(", ", sequence));

            if (isInSequence)
                Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {number} não pertence à sequência de Fibonacci.");
        }
    }
}