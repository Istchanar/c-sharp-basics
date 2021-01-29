using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Написать программу, выводящую элементы двухмерного массива по диагонали.


            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 1. Написать программу, выводящую элементы двухмерного массива по диагонали.");

            Console.ResetColor();

            Console.WriteLine();

            // Объявляю две переменные: размер массива и число по диагонал.
            // Их значения определяю в циклах.

            int size;

            int number;

            // Цикл для проверки, является ли размер массива больше, чем 15;

            do
            {
                Console.WriteLine($"Введите размер массива (не более 15): ");

                Console.WriteLine();

                size = Convert.ToInt32(Console.ReadLine());
            }
            while (size > 15);

            Console.WriteLine();

            // Цикл для проверки, является ли число по диагонали больше, чем 9;

            do
            {

                Console.WriteLine($"Введите число диаганали (положительное, не более 9): ");

                Console.WriteLine();

                number = Convert.ToInt32(Console.ReadLine());

            }
            while (number > 9);

            Console.WriteLine();

            int[,] arr = new int[size, size];              // Объявляем массив размера size;

            for (int i = 0; i < arr.GetLength(0); i++)     // Условия циклов для вывода столбцов и строчек, начиная от левого угла 0х0,
            {                                              // сравниваем с максимальной длинной измерения 0 и 1 и выводим в консоль символ;
                for (int j = 0; j < arr.GetLength(1); j++)

                {
                    if (i == j)   // Если строка равна столбцу выводим число number;
                    {
                        arr[i, j] = number;

                        Console.Write($"{arr[i, j]} ");
                    }
                    else       // В противном случае выводим отступы;
                    {
                        Console.Write($"  ");
                    }

                }

                Console.WriteLine();

            }


            // Задание 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, 
            // хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, " +
                $"хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.");

            Console.ResetColor();

            Console.WriteLine();

            string[,] book = new string[5, 2]; // Объявляем строковый массив book, который будет хранить данные;

            for (int i = 0; i < book.GetLength(0); i++) // Пока i меньше 5 переберём все значения массива для запроса фамилии и имени;

            {
                Console.WriteLine($"Введите ФИО для контакта №{i + 1}: ");

                book[i, 0] = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine($"Номер телефона или e-mail контакта №{i + 1}: ");

                book[i, 1] = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < book.GetLength(0); i++) // Пока i меньше 5 переберём все значения массива для вывода фамилии и имени;
            {
                Console.WriteLine($"ФИО контакта №{i + 1}: {book[i, 0]} \n" +
                    $"Номер телефона или e-mail контакта №: {book[i, 1]}");
            }

            Console.ReadLine();

            Console.WriteLine();


            // Задание 3. Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 3. Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).");

            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine($"Введите строку:");

            string invert = Console.ReadLine(); // Сохраняю строку;

            Console.WriteLine();

            Console.WriteLine($"Ваша перевёрнутая строка:");

            // Так как строка по ряду свойств близка к массиву из char, переберу
            // каждый символ, с учётом того, что индексация символов начинается с нуля.

            for (int i = invert.Length - 1; i < invert.Length; i--) // Отнимает 1 от длинны строки, т.к. индексация char в строке идёт с нуля;
            {
                Console.Write(invert[i]); // Пишу символ в терминал;
                if (i == 0)           // Если i доходит до нуля (а длинна массива меньше нуля не может быть), выхожу из цикла;
                {
                    break;
                }
            }

            Console.ReadLine();

            Console.WriteLine();


            // Задание 4. «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, 
            // где Х — элементы кораблей, а О — свободные клетки.


            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 4. «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O," +
                $"\nгде Х — элементы кораблей, а О — свободные клетки.");

            Console.ResetColor();

            Console.WriteLine();

            char[,] seaBattle = new char[10, 10] {
                                                  { 'X', 'O', 'O', 'X', 'X', 'O', 'O', 'O', 'X', 'O'},
                                                  { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                                                  { 'X', 'O', 'O', 'X', 'O', 'O', 'X', 'X', 'O', 'O'},
                                                  { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                                                  { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                                                  { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                                                  { 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'O', 'X'},
                                                  { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X'},
                                                  { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'X'},
                                                  { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X'}
                                                  };

            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    Console.Write(seaBattle[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"Для удобства, выведем только корабли:\n");

            for (int i = 0; i < seaBattle.GetLength(0); i++)     // Переберём по размеру массива и выведем только корабли;
            {                                                  
                for (int j = 0; j < seaBattle.GetLength(1); j++)

                {
                    if (seaBattle[i, j] == 'X') // Если символы Х - выводим их;
                    {
                        Console.Write($"{seaBattle[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"  "); // В противном случае выводим двойные отступы;
                    }

                }

                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
