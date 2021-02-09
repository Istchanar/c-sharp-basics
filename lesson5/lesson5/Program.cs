using System;
using System.IO;

namespace lesson5
{
    class Program
    {
        // Задача 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

        static void Main(string[] args)
        {
            string nameForFile = GetFileName();

            GetText(out string text);

            string createFile = CreateAndWriteFile(nameForFile, text);

            string fileText = File.ReadAllText(createFile);

            Console.WriteLine($"В вашем файле записано: \n{fileText}");
        }

        static string GetFileName()
        {
            string fileName;

            do
            {
                Console.WriteLine($"Введите имя файла (не больше 15 символов): ");

                Console.WriteLine();

                fileName = Console.ReadLine();

                Console.WriteLine();

            } while (fileName.Length >= 15 || fileName.Length == 0);

            return fileName;
        }

        static void GetText(out string text)
        {

            Console.WriteLine($"Введите текст, который будет в файле: ");

            Console.WriteLine();

            text = Console.ReadLine();

            Console.WriteLine();

        }

        static string CreateAndWriteFile(string fileName, string text)
        {
            string file = $"{fileName}.txt";

            File.WriteAllText(file, $"{text}");

            return file;
        }
    }
}
