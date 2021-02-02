using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 1. Написать метод GetFullName(string firstName, string lastName, string patronymic), " +
                $"\nпринимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. " +
                $"\nИспользуя метод, написать программу, выводящую в консоль 3–4 разных ФИО.");

            Console.ResetColor();

            Console.WriteLine();

            string[] info = new string[3];

            for (int i = 0; i < 3; i++) // Циклом перебираем каждый элемент;
            {
                info[i] = setUserData();
            }

            foreach (string fullLine in info)  // Для каждого элемнта в массиве вывести строку;
            {
                Console.WriteLine($"{fullLine}");
            }

            Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName, string patronymic) // Метод принимает три строки и отдаёт одну;
        {
            string fullNameString = ($"{firstName} {lastName} {patronymic}");

            return fullNameString;
        }

        static string setUserData()     // Устанавливаются данные пользователей;
        {
            string fstName = writeRead($"Введите имя: ");

            string lstName = writeRead($"Введите фамилию: ");

            string ptrNymic = writeRead($"Введите отчество: ");

            Console.WriteLine();

            string fullName = GetFullName(fstName, lstName, ptrNymic);

            return fullName;
        }
        static string writeRead(string data)  // Метод вывода/чтения;
        {
            Console.WriteLine(data);

            return Console.ReadLine();
        }
    }
}
