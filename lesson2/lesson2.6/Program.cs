using System;

namespace lesson2._6
{
    class Program
    {

        // Задание 6.  Универсальная структура расписания рабочей недели двух фирм,
        // с вводом дня недели от пользователя, и выдача ему рабочих и нерабочих дней,
        // а также дней, когда работают обе фирмы.

        public enum Week:int 
            //  Зададим в перечислении битовую маску каждого числа, зафиксируем 
            // десятичную форму маски. Это нужно для дальнейших преобразований.
        {
            Понедельник = 0b_0000001, //1
            Вторник     = 0b_0000010, //2
            Среда       = 0b_0000100, //4
            Четверг     = 0b_0001000, //8
            Пятница     = 0b_0010000, //16
            Суббота     = 0b_0100000, //32
            Воскрсенье  = 0b_1000000, //64
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Задание 4. Вывод в консоль чека с заранее заполненными данными.");

            Console.ResetColor();

            Console.WriteLine("Введите день недели: ");

            int day = Convert.ToInt32(Console.ReadLine()); // Запоминаем значение из консоли, переводим в int;

            if (day >= 8 || day == 0) // В недели дни пронумерованы от 1 до 7 включительно, исключаем остальное.
            {
                Console.WriteLine("Такого дня нет");
            }
            else // Если дни входят в облась [1-7], продожаем выполнение.
            {
                // Т.к. в перечислении у нас int'ы элементов имеют значения 2^(day-1), расчитываем
                // dayConvert.
                // day-1 т.к пользователь вводит 1, но для понедельника у нас значение int в enam'e 
                // равно 1=2^0, и так далее для каждого дня; поэтому мы уменьшаем на 1 показатель степени.

                int dayConvert = Convert.ToInt32(Math.Pow(2, day - 1));

                // Вводим dayCastom, который будет представлять из себя элемент enam'a, имеющий int 
                // совпадающий с dayConvert, который в свою очередь через степень двойки связан с тем,
                // что ввёл пользователь.

                Week dayCastom = (Week)dayConvert; 

                Console.WriteLine($"Пользователь выбрал {dayCastom}.");

                // Записываем маски фирм.

                Week Firm1 = Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница;

                Week Firm2 = Week.Понедельник | Week.Вторник | Week.Среда | Week.Четверг | Week.Пятница | Week.Суббота | Week.Воскрсенье;

                // Для удобства выводим расписание фирм на экран.

                Console.WriteLine($"Firm1 расписание Вторник, Среда, Четверг, Пятница.");

                Console.WriteLine($"Firm2 расписание Поенедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье");

                // Побитово сравниваем с помощью оператора "или", есть ли введённый пользователем день в расписании фирмы.
                // Если день есть, то на выходе мы получим значение firmDay1 отличное от маски firmWork1 и т.д.

                Week firmWork1 = dayCastom | Firm1;  

                Week firmWork2 = dayCastom | Firm2;

                bool firmOpen1 = firmWork1 == Firm1; // Проверяем истинность совпадения firmWork1 с Firm1;

                bool firmOpen2 = firmWork2 == Firm2; // Проверяем истинность совпадения firmWork2 с Firm2;

                if (firmOpen1)

                {
                    Console.WriteLine($"Firm1 работает в {dayCastom};");
                }

                else

                {
                    Console.WriteLine($"Firm1 заткрыта в {dayCastom};");
                }

                if (firmOpen2)

                {
                    Console.WriteLine($"Firm2 работает в {dayCastom};");
                }

                else

                {
                    Console.WriteLine($"Firm2 заткрыта в {dayCastom};");
                }

                // Если firmOpen1 и firmOpen2 верны, то открыты обе фирмы.

                if (firmOpen1)

                {
                    if (firmOpen2)

                    {
                        Console.WriteLine($"Открыты обе фирмы в {dayCastom};");
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}    
