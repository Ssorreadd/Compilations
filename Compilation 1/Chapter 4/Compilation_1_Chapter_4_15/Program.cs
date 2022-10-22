using System;

namespace Compilation_1_Chapter_4_15
{
    class Program
    {
        static DateTime DateNow { get; set; }
        static bool DateLogicChanged { get; set; }

        static void ActionWarning(string text)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{text}\n");

            Console.ResetColor();
        }
        static void ActionSuccessfully(string text)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{text}\n");

            Console.ResetColor();
        }
        static void ActionError(string text)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{text}\n");

            Console.ResetColor();
        }

        static void ManualDateAdjustment()
        {
            Console.Clear();

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц(число): ");
            int month = int.Parse(Console.ReadLine());

            DateNow = new DateTime(year, month, 1);

            ActionSuccessfully("Режим определения времени: Ручной");
        }
        static void EditLogic()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Страница выбора режима определения даты\n");
            Console.ResetColor();

            Console.Write("1) Автоматическое определение даты.\n" +
                    "2) Установить дату вручную.\n\n" +
                    "Ваш выбор: ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    DateNow = DateTime.Now;
                    ActionSuccessfully("Режим определения времени: Автоматический");
                    break;
                case 2:
                    ManualDateAdjustment();
                    break;
                default:
                    ActionWarning("Такого действия не существует");
                    break;
            }
            DateLogicChanged = true;
        }

        static void GetAge()
        {
            if (!DateLogicChanged)
            {
                ActionWarning("Режим определения даты не установлен");
                return;
            }

            Console.Clear();


            Console.Write("Введите год рождения человека: ");
            int bornYear = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц(число) рождения человека: ");
            int bornMonth = int.Parse(Console.ReadLine());

            DateTime bornDate = new DateTime(bornYear, bornMonth, 1);

            int age = DateNow.Year - bornDate.Year;

            ActionSuccessfully("Итог расчетов");

            Console.WriteLine($"Текщая дата: {DateNow.Month}.{DateNow.Year}\n" +
                $"Человек родился: {bornDate.Month}.{bornDate.Year}\n" +
                $"Полных лет: {age}\n");
        }

        static void Main()
        {
            DateLogicChanged = false;
            while (true)
            {
                try
                {
                    Console.Write("1) Перейти на страницу выбора режима определения времени.\n" +
                        "2) Перейти на страницу выполнения программы.\n\n" +
                        "Ваш выбор: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            EditLogic();
                            break;
                        case 2:
                            GetAge();
                            break;
                        default:
                            ActionWarning("Такого действия не существует");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ActionError(ex.Message);
                }
            }
        }
    }
}