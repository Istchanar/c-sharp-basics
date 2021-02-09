using System;
using System.IO;
using System.Linq;

namespace lesson5._3
{
   // Задача 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bts = DecodeToByte();

            File.WriteAllBytes("bytes.bin", bts);

            byte[] fromFile = File.ReadAllBytes("bytes.bin");

            PrintByte(fromFile);
        }

        static byte[] DecodeToByte()
        {
            Console.WriteLine($"Введите числа через пробел: ");

            string array = Console.ReadLine();

            byte[] MyBytes = array.Split(' ').Select(byte.Parse).ToArray();

            return MyBytes;
        }
        static void PrintByte(byte[] fromFile)
        {
            Console.WriteLine();

            Console.WriteLine($"В .bin файле массив:");

            Console.WriteLine();
            
        for (int i = 0; i < fromFile.Length; i++)
        {
            Console.WriteLine($"{fromFile[i]}");
        }
        }
    }
}
