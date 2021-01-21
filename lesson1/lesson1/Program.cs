using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Спрашиваем ввод имени:
            Console.Write("Введите своё имя: ");
            Console.ReadLine();

            // Сохраняем введённое имя:
            string name = Console.ReadLine();
            // Объявляем переменную  date, которая представляет из себя
            // структуру со свойством Now и метод форматирования ToShortDateString:
            string date = DateTime.Now.ToShortDateString();

            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Используем конкатенацию:");
            Console.ResetColor();
            // Используем конкатенацию (склеиваем) строки для вывода:
            Console.WriteLine("Доброго времени, " + name + ", сегодня " + date + "!");
            Console.ReadLine();

            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Используем интерполяцию:");
            Console.ResetColor();
            // Используем интерполяцию, помещаем переменные в текст:
            Console.WriteLine($"Доброго времени, {name}, сегодня {date}!");
            Console.ReadLine();

            // Завершаем работу вызываем метод exit с кодом 0:
            Console.WriteLine("Для закрытия нажмите Enter.");
            Console.ReadLine();
            Environment.Exit(0); 
        }
    }
}
