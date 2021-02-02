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

            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine($"Введите числа для суммирования: ");

            string sumString = Console.ReadLine().Replace('.', ',');

            // Создаем из строки массив подстрок, подстроки выбраны по принципу дробления строки на пробелы;

            string[] sumArray = sumString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sumTotal = sumCalc(sumArray); // Отдаём в метод sumCalc введённый массив sumArray;

            Console.WriteLine($"Сумма введённых чисел равна: {sumTotal}");

            Console.ReadLine();

        }

        static double sumCalc(string[] sumArray) // Считающий сумму и парсящий из массива строки метод;
        {
            double firstSum = 0; // Стартовая сумма;

            foreach (string number in sumArray) // Берём строку в массиве;
            {
                double value;

                bool succesParse = double.TryParse(number, out value); // Вернуть double, если он успешно распаршен из строки;

                if (succesParse) // Если парсинг успешный - прибавить значения дабла к нулю;

                {
                    firstSum = firstSum + value; // Итоговое значение firstSum;
                }
            }

            return firstSum;
        }
    }
}
