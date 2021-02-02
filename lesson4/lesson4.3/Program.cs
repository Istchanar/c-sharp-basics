using System;

namespace lesson4._3
{
    enum Season
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

            Season season;

            GetSeason(mounth, out season);

            Console.WriteLine(GetTransSeason(season));
        }

        static void GetSeason(int monthNumber, out Season season)
        {
            season = Season.Autumn;

            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    season = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Season.Autumn;
                    break;
            }
        }

        static string GetTransSeason(Season season)
        {

            string[] translateSeasons = { "Зима",
                                         "Весна",
                                         "Лето",
                                         "Осень" };

            int seasonsNumber = (int)season;

            if (seasonsNumber > 0 && seasonsNumber < 13)

            {
                return $"Сезон {translateSeasons[seasonsNumber]} соответствуют номеру месяца.";
            }

            return "Ошибка: введите число от 1 до 12!";
        }
    }
}
