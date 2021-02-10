using System;

namespace lesson2._1_5
{
    class Program
    {
        // Задаём тип перечисления, описываем элементы перечисления, устанавливаем 
        // отсчёт значений конcтант элементов с единицы.
        public enum Mounth : int
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октярь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {

            // Задание 1. Запросить у пользователя минимальную и максимальную 
            //температуру, расчитать и вывести среднесуточную температуру.

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 1. Запросить у пользователя минимальную и максимальную " +
                $"температуру, расчитать и \n вывести среднесуточную температуру.");

            Console.ResetColor();

            Console.WriteLine($"Введите максимальную температуру сегодня: ");

            int tempMax = Convert.ToInt32(Console.ReadLine()); // Запоминаем ввод из консоли, преобразуем в int;

            Console.WriteLine($"Введите минимальную температуру сегодня: ");

            int tempMin = Convert.ToInt32(Console.ReadLine()); // Запоминаем ввод из консоли, преобразуем в int;

            int tempMedium = (tempMax + tempMin) / 2; // Средняя температура равна сумме разделенной на кол-во измерений, т.е. два;

            Console.WriteLine($"Средняя температура сегодня {tempMedium}, (min = {tempMin}, max = {tempMax})");

            Console.ReadLine();


            // Задание 2. Запросить у пользователя порядковый номер текущего месяца, вывести его название.

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 2. Запросить у пользователя порядковый номер текущего месяца, \n вывести его название.");

            Console.ResetColor();

            Console.WriteLine($"Введите номер текущего месяца: ");

            int monthNumber = Convert.ToInt32(Console.ReadLine()); // Запоминаем ввод из консоли, преобразуем в int;

            if (monthNumber > 12 || monthNumber == 0) // Если номер месяца больше 12 или равен нулю, писать что такого месяца нет;

            {
                Console.WriteLine($"Такого месяца нет.");
            }
            else
            {
                // Для остальных значений (от 1 до 12), привожу monthNumber к типу Mounth, тогда mounthFromEnum 
                // будет соотвествовать элементу перечисления со значением базового типа равным monthNumber.
                Mounth mounthFromEnum = (Mounth)monthNumber;

                Console.WriteLine($"Сегодня месяц: {mounthFromEnum}.");
            }

            Console.ReadLine();


            // Задание 5. Если пользователь указал месяц из зимнего периода, 
            // а средняя температура > 0, вывести сообщение «Дождливая зима».

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Задание 5. Если пользователь указал месяц из зимнего " +
                $"периода, а средняя температура > 0, \n вывести сообщение «Дождливая зима».");

            Console.ResetColor();

            if (monthNumber <= 2 || monthNumber == 12) // Если месяц меньше/равен двум или равен 12 (зимние месяцы 1,2,12);
            {
                if (tempMediun > 0) // И если температура средняя больше нуля;
                {
                    Console.WriteLine($"Дождливая зима.");
                }
                else
                {
                    Console.WriteLine($"Снежная зима.");
                }
            }
            else
            {
                Console.WriteLine($"Зимы нет");
            }

            Console.ReadLine();


            // Задание 3. Определить, является ли введённое пользователем число чётным.

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Задание 3. Определить, является ли введённое пользователем число чётным.");

            Console.ResetColor();

            Console.WriteLine("Введите число: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} чётное.");
            }
            else
            {
                Console.WriteLine($"Число {number} нечётное.");
            }

            Console.ReadLine();


            // Задание 4. Вывод в консоль чека с заранее заполненными данными.
            // Записываем в переменные значения и выводим в консоль.

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Задание 4. Вывод в консоль чека с заранее заполненными данными.");

            Console.ResetColor();

            string name = "КАССОВЫЙ ЧЕК";

            string payFrom = "ОПЛАТА ОТ: ИВАНОВ ИВАН ИВАНОВИЧ";

            string sumWhithoutNDS = "Сумма без НДС:";

            float payWhithoutNDS = 91.2345F;

            string sumWhithNDS = "Сумма c НДС:";

            int payWhithNDS = 105;

            string payDate = "Дата и время:";

            DateTime date = new DateTime(2021, 01, 26, 17, 30, 00);

            string resident = "Налоговый резидент России:";

            bool residentCheck = true;

            string productName = "Наименование товара: ТОПЛИВО";

            string code = "Код товара:";

            int codeA = 5;

            long codeB = -273;

            ulong codeC = 5;

            char codeD = 'A';

            // Передаём значения переменных с помощью интерполяции; \n переносит на новоую строку.
            Console.WriteLine($"\n {name} \n {payFrom} \n {sumWhithoutNDS} {payWhithoutNDS} \n {sumWhithNDS} {payWhithNDS} " +
             $"\n {payDate} {date} \n {resident} {residentCheck} \n {productName} \n {code} {codeA}{codeB}{codeC}{codeD}");

            Environment.Exit(0);
        }
    }
}
