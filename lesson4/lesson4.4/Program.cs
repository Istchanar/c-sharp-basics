using System;

namespace lesson4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 4. Написать программу, вычисляющую число Фибоначчи для " +
                $"\nзаданного значения рекурсивным способом.");

            Line();

            int number = Convert.ToInt32(Console.ReadLine());

            int x = FibonacciNumCalc(number);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Число Фибоначчи равно {x} для значения {number}");

            Console.ReadLine();
        }

        static int FibonacciNumCalc(int number)
        {
            if (number == 0)
            {
               return 0;
            }

            if (number == 1)
            {
               return 1;
            }

            return FibonacciNumCalc(number - 1) + FibonacciNumCalc(number - 2);

        }


        static void Line()
        {
            Console.ResetColor();

            Console.WriteLine();
        }

    }
}
