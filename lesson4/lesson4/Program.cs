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

            string[] info = new string[3];

            for (int i = 0; i < 3; i++) // Циклом перебираем каждый элемент и присваиваем значение строки полученной при роботе метода SetUserData;
            {
                info[i] = SetUserData();
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

        static string SetUserData()     // Устанавливаются данные пользователей ;
        {
            string fstName = WriteRead($"Введите имя: "); // Вызываем WriteLine передав строку, и результат сохраняем в fstName;

            string lstName = WriteRead($"Введите фамилию: ");

            string ptrNymic = WriteRead($"Введите отчество: ");

            Console.WriteLine();

            string fllName = GetFullName(fstName, lstName, ptrNymic); // Используем GetFullName;

            return fllName;
        }
        static string WriteRead(string data)  // Метод вывода/чтения c параметром data для передачи строки;

        {
            Console.WriteLine(data);

            return Console.ReadLine();
        }   
    }
}
