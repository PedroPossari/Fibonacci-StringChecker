using Ex1;
using System;
using static Ex1.FibonacciApp;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Calcular a sequência de Fibonacci");
            Console.WriteLine("2 - Verificar a existência da letra 'a' em uma string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ExecuteFibonacci();
                    break;

                case 2:
                    ExecuteStringCheck();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        static void ExecuteFibonacci()
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

        static void ExecuteStringCheck()
        {
            Console.WriteLine("Informe uma string:");
            string inputString = Console.ReadLine();

            StringChecker stringChecker = new StringChecker();
            bool containsA = stringChecker.ContainsLetterA(inputString);
            int countA = stringChecker.CountLetterA(inputString);

            if (containsA)
                Console.WriteLine($"A string contém a letra 'a'. Ocorre {countA} vez(es).");
            else
                Console.WriteLine("A string não contém a letra 'a'.");
        }
    }
}