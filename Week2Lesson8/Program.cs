using System;
using System.Linq;

namespace Week2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Console.ReadLine();
            Exercise2();
            Console.ReadLine();
            Exercise3();
            Console.ReadLine();
            Exercise4();
            Console.ReadLine();
            Exercise5();
            Console.ReadLine();
            Exercise6();
            Console.ReadLine();
            Exercise7();
            Console.ReadLine();
            Exercise8();
            Console.ReadLine();
            Exercise9();
            Console.ReadLine();
            Exercise10();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1:");

            var primeCounter = 0;

            for (int i = 1; i <= 100; i++)
            {
                int helperCounter = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        helperCounter++;
                        break;
                    }
                }

                if (helperCounter == 0 && i != 1)
                {
                    primeCounter++;
                }
            }
            Console.WriteLine($"Between 0 and 100 there is {primeCounter} prime numbers");
        }

        public static void Exercise2()
        {
            Console.WriteLine("Exercise 2:");

            int number = 0;
            int counter = 0;

            do
            {
                if (number % 2 == 0)
                {
                    counter++;
                }
                ++number;
            } while (number <= 1000);

            Console.WriteLine($"I've found {counter} even numbers between 0 and 1000.");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Exercise 3:");

            Console.Write("Enter length for Fibonacci sequence: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
                Console.WriteLine($"{FibonacciGenerator(i)}");
        }

        private static int FibonacciGenerator(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int fibonacciNumber = 0;

            if (number == 0)
                return 0;

            if (number == 1)
                return 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacciNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibonacciNumber;
            }
            return fibonacciNumber;
        }

        public static void Exercise4()
        {
            Console.WriteLine("Exercise 4:");

            Console.Write("Please enter an integer number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int counter = 1;
            for (int i = 0; i < inputNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{counter} ");
                    counter++;

                    if (counter > inputNumber)
                        break;
                }

                Console.WriteLine();

                if (counter > inputNumber)
                    break;
            }

        }

        public static void Exercise5()
        {
            Console.WriteLine("Exercise 5:");

            int[] numbers = Enumerable.Range(1, 20).ToArray();

            foreach (var number in numbers)
                Console.WriteLine(Math.Pow(number, 3));

        }

        public static void Exercise6()
        {
            Console.WriteLine("Exercise 6:");

            double sum = 0;

            for (double i = 1; i <= 20; i++)
            {
                sum += 1 / i;
            }

            Console.WriteLine($"The result is: {sum:N2}");
        }

        public static void Exercise7()
        {
            Console.WriteLine("Exercise 7:");

            Console.WriteLine("Please type number of star diagonal:");
            int starDiagonal = int.Parse(Console.ReadLine());

            int space = 0, row = 0;

            while (row <= starDiagonal)
            {
                for (int column = 0; column < starDiagonal / 2 - space; column++)
                    Console.Write(" ");

                for (int column = 0; column <= row; column++)
                    Console.Write("*");

                row += 2;
                space++;
                Console.WriteLine();
            }

            row -= 2;
            space--;

            while (row >= 0)
            {
                for (int column = 0; column < starDiagonal / 2 - space + 1; column++)
                    Console.Write(" ");

                for (int column = 0; column < row - 1; column++)
                    Console.Write("*");

                row -= 2;
                space--;
                Console.WriteLine();
            }
        }

        public static void Exercise8()
        {
            Console.WriteLine("Exercise 8:");

            Console.WriteLine("Please type some word and I'll display for you a mirror:):");
            string input = Console.ReadLine();

            string reverseInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseInput += input[i];
            }

            Console.WriteLine($"Mirror: {reverseInput}");
        }

        public static void Exercise9()
        {
            Console.WriteLine("Exercise 9:");

            Console.WriteLine("Please type a number for binary conversion:");
            int number = int.Parse(Console.ReadLine());

            string binary = string.Empty;

            for (int i = 0; number > 0; i++)
            {
                binary = number % 2 + binary;
                number /= 2;
            }
            Console.WriteLine($"Binary result: {binary}");
        }

        public static void Exercise10() 
        {
            Console.WriteLine("Exercise 10:");

            Console.WriteLine("Please type first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int maximumRange;
            maximumRange = (firstNumber > secondNumber) ? firstNumber : secondNumber;

            int lowestCommonMultiple;        

            for (int i = maximumRange; ; i += maximumRange)
            {
                if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    lowestCommonMultiple = i;
                    break;
                }
            }
            Console.WriteLine($"Lowest common multiple for {firstNumber} and {secondNumber} is {lowestCommonMultiple}");
        }      
    }
}
