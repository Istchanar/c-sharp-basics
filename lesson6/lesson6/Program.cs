using System;
using System.Diagnostics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(130, 25);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine(string.Format("|{0,20}|{1,20}|{2,20}|{3,50}|", "PROCESSTIME", "PROCESSID", "PROCESSMEMORY", "PROCESSNAME"));

            ProcessList();

            Console.ResetColor();

            Notification($"Введите номер или имя процесса:");

            string processName = Console.ReadLine(); // Получаю имя процесса;

            bool parseId = int.TryParse(processName, out int id); // пытаюсь парсить - распарсилось значит айди, нет - значит имя;

            GetByNameOrId(parseId, id, processName);

            Console.ReadKey();
        }

        //Метод выполняет два метода, принимая три переменных

        static void GetByNameOrId(bool parseId, int id, string processName)
        {
            if (parseId == true)
            {
                GetById(id);
            }
            else
            {
                GetByName(processName);
            }

        }

        //Метод по name завершает процесс:

        static void GetByName(string processName)
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {

                    process.Kill();

                    Notification($"Процесс name={processName} завершён.");
                }
            }
            catch
            {
                Notification($"Процесса name={processName} не существует.");
            }


        }

        // Метод по id завершает процесс:

        static void GetById(int id)
        {
            try
            {
                Process process = Process.GetProcessById(id);

                process.Kill();

                Notification($"Процесс pid={id} завершён.");
            }
            catch
            {
                Notification($"Процесса pid={id} не существует.");
            }

        }

        // Метод сообщений:

        static void Notification(string information)
        {
            Console.WriteLine();

            Console.WriteLine(information);
        }

        static void ProcessList()
        {

            Process[] processes = Process.GetProcesses();

            uint error = 0;

            foreach (Process targetProcess in processes)
            {
                try
                {
                    Console.Write(string.Format("|{0,20}|", DateTime.Now.Subtract(targetProcess.StartTime).TotalMinutes.ToString("F2")));
                }
                catch (Exception ex)
                {
                    Console.Write(string.Format("|{0,20}|", ex.Message));

                    error++;

                }


                try
                {
                    Console.Write(string.Format("{0,20}|", targetProcess.Id.ToString()));
                }
                catch (Exception ex)
                {
                    Console.Write(string.Format("{0,20}|", ex.Message));

                    error++;
                }

                try
                {
                    // Из long превращаем int, и делим на 1000000 получаем память. 

                    int mBite = (int)targetProcess.VirtualMemorySize64 / 1000000;

                    Console.Write(string.Format("{0,20}|", mBite.ToString(), "mb"));
                }
                catch (Exception ex)
                {
                    Console.Write("{0, 20}|", ex.Message);

                    error++;
                }

                Console.Write("{0,50}|", targetProcess.ProcessName);

                Console.WriteLine();
            }

            Notification($"Процессов: {processes.Length}, ошибок доступа: {error}");
        }
    }
}

