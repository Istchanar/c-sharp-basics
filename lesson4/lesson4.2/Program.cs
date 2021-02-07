using System;

namespace lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 2. Написать программу, принимающую на вход строку — набор чисел, " +
                $"\nразделенных пробелом, и возвращающую число — сумму всех чисел в строке. " +
                $"\nВвести данные с клавиатуры и вывести результат на экран.");

            Print();

            Console.WriteLine($"Введите числа для суммирования: ");

            // Чтобы считалось правильно нужно менять на запятую;

            string sumString = Console.ReadLine().Replace('.', ',');

            // Создаем из строки массив подстрок, подстроки выбраны по принципу дробления строки на пробелы;

            string[] sumArray = sumString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Отдаём в метод sumCalc введённый массив sumArray;

            double sumTotal = SumCalc(sumArray);

            Console.WriteLine($"Сумма введённых чисел равна: {sumTotal}");

            Console.ReadLine();

        }

        static double SumCalc(string[] sumArray) // Считающий сумму и парсящий из массива строки метод;
        {
            // Стартовая сумма;

            double firstSum = 0;

            // Берём строку в массиве;

            foreach (string number in sumArray) 
            {
                double value;

                // Вернуть double.value, если он успешно распаршен из строки;

                bool succesParse = double.TryParse(number, out value);

                if (succesParse) // Если парсинг успешный (есть элементы в sumArray) - прибавить value к firstSum;

                {
                    // Пересчитываем firstSum;
                    firstSum += value;
                }

            }

            return firstSum;

            
        }
        static void Print()
        {
            Console.ResetColor();

            Console.WriteLine();
        }
    }
}
