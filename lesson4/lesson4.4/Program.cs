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

            Console.ResetColor();

            Console.WriteLine();

            int number = GetNumber(); // Вызываем метод GetNumber;

            int fibonacci = FibonacciNumCalc(number, 0); // Отдаём в метод значения number и ноль;

            Console.WriteLine();

            Console.WriteLine($"Значение: {fibonacci}");

            Console.ReadLine();
        }

        static int GetNumber()
        {
            Console.WriteLine($"Введите номер для вычисления значения: ");

            Console.WriteLine();

            int fibonacciNum; // Номер числа Фибоначчи;

            int fibonacciTryParse; // Резульат парсинга введённого числа;

            bool fibonacciParse = int.TryParse(Console.ReadLine(), out fibonacciTryParse);

            if (fibonacciParse) // Если всё хорошо, то номер равен результату парсинга, если нет - нулю;
            {
                fibonacciNum = fibonacciTryParse;
            }
            else
            {
                fibonacciNum = 0;
            }


            return fibonacciNum;
        }

        static int FibonacciNumCalc(int number, int i)
        {

            if (i == number)
            {
                return i;
            }

            return i + FibonacciNumCalc(number, ++i);
        }

    }
}
