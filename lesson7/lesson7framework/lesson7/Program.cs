using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = Properties.Settings.Default.Hi;

            Console.WriteLine($"{greeting}");

            SetUserName();

            SetUserAge();

            SetProfession();

            string userName = Properties.Settings.Default.UserName;

            string userAge = Properties.Settings.Default.UserAge;

            string profession = Properties.Settings.Default.Profession;

            Console.WriteLine();

            Console.WriteLine($"В настройках сейчас {userName}, {userAge}, {profession}");

            Console.ReadLine();

        }

        static void SetUserName()
        { 
        
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))

            {

                Console.WriteLine("Введите имя пользователя:");

                Console.WriteLine();

                Properties.Settings.Default.UserName = Console.ReadLine();

                Console.WriteLine();

                Properties.Settings.Default.Save();
            }
}

        static void SetUserAge()
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserAge))

            {

                Console.WriteLine("Введите имя пользователя:");

                Console.WriteLine();

                Properties.Settings.Default.UserAge = Console.ReadLine();

                Console.WriteLine();

                Properties.Settings.Default.Save();
            }

        }

        static void SetProfession()
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.Profession))

            {

                Console.WriteLine("Введите профессию");

                Console.WriteLine();

                Properties.Settings.Default.Profession=Console.ReadLine();

                Console.WriteLine();

                Properties.Settings.Default.Save();
            }
        }
    }
}
