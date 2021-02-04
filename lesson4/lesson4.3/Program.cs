using System;

namespace lesson4._3
{
    /*
    Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
    На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод, 
    принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
    Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
    Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
    enum Season
    */

    enum SeasonOfTheYear:int
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите порядковый номер месяца: ");

            int mounth = Convert.ToInt32(Console.ReadLine());

            GetSeason(mounth, out SeasonOfTheYear setSeason); // Вызывает GetSeason, отдаём номер месяца и получаем setSeason;

            string result = GetTransSeason(mounth, setSeason); // Получаем строку от метода GetTransSeason, отдаём туда месяц и setSeason;

            Console.WriteLine($"{result}"); // Выводим результат.
        }

        static void GetSeason(int mounth, out SeasonOfTheYear setSeason) // GetSeason устанавливаем номер сезона из enum по месяцу;
        {

            setSeason = SeasonOfTheYear.Winter; // Присваиваем стартовое значение;

            switch (mounth)
            {
                case 12:
                case 1:
                case 2:
                    setSeason = SeasonOfTheYear.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    setSeason = SeasonOfTheYear.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    setSeason = SeasonOfTheYear.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    setSeason = SeasonOfTheYear.Autumn;
                    break;
            }
        }

        static string GetTransSeason(int mounth, SeasonOfTheYear setSeason) 
        {

            string[] translateSeason = { "Зима", "Весна", "Лето", "Осень" }; // Создаём массив русских названий;

            int numberFromEnum = (int)setSeason; //Берём номер сезона из enum'a;

            if (mounth > 0 && mounth <= 12) //Проверяем номер месяца, что он в диапазоне;

            {
                string russianName = translateSeason[numberFromEnum]; //Берём номер элемента в массиве с русскими названиями по индедксу из enum;

                string message = $"Номеру месяца {mounth} соответствует сезону {russianName}.";

                return message; //Выводим сообщение;
            }

            string error = "Ошибка: введите число от 1 до 12!";

            return error;       // Выводим ошибку.
        }
    }
}
