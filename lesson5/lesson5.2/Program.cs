using System;
using System.IO;

namespace lesson5._2
{
    // Задание 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
    class Program
    {
        static void Main(string[] args)
        {
            Const(out string fileName, out string date);

            CreateFile(fileName, date);

            Console.ReadLine();
        }

        static void CreateFile(string fileName, string date)
        {
            File.AppendAllLines(fileName, new[] { date });

            File.AppendAllText(fileName, Environment.NewLine);
        }

        static void Const(out string fileName, out string date)
        {
            fileName = "startup.txt";

            date = Convert.ToString(DateTime.Now);

            Console.WriteLine($"{date}");
        }
    }
}
