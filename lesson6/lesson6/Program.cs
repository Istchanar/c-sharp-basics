using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 25);

            Process[] processes = Process.GetProcesses();

            Console.WriteLine(string.Format("|{0,-20}|{1,-20}|{2,-20}|{3,-60}|", "processTime", "processId", "processMemory", "processName"));

            for (int i = 0; i < processes.Length; i++)
            {

                try
                {
                    string processName = $"{processes[i].ProcessName}";
                    string processId = $"{processes[i].Id}";
                    string processMemory = $"{processes[i].VirtualMemorySize64}";
                    string processTime = $"{processes[i].StartTime}"; // Для некоторых процессов недоступно время, надо подумать как обработать;
                    Console.WriteLine(string.Format("|{0,-20}|{1,-20}|{2,-20}|{3,-60}|", processTime, processId, processMemory, processName));
                    //Console.WriteLine($"{processName} {processId} {processMemory}");
                }
                catch
                {
                    // Очень много времени занимает обработка в трай-кетч;
                    // Console.WriteLine("Ошибка");
                }
            }

            Console.WriteLine($"Общее кол-во процессов в системе {processes.Length}");

            Console.WriteLine($"Введите номер или имя процесса: ");

            string proc = Console.ReadLine(); // Получаю имя процесса;

            bool x = int.TryParse(proc, out int z); // пытаюсь парсить - распарсилось значит айди, нет - значит имя;

            if (x == true)
            {
                Process proccToKill = Process.GetProcessById(z); // убиваю по айди
                proccToKill.Kill();
            }
            else
            {
                foreach (var process in Process.GetProcessesByName(proc)) // ищу имя в списке всех процессов и убиваю по имени;
                {
                    process.Kill();
                }
            }

            Console.WriteLine("Процесс убит");

            Console.ReadKey();
        }
    }
}
