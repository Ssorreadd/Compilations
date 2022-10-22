using System;
using SsorreaddDev.ColorManager;

namespace Compilation_1_Chapter_2_6
{
    class Program
    {
        static void SetSeconds()
        {
            try
            {
                Console.Clear();

                Console.Write("Введите целочисленное значение секунд: ");
                TimeManager.SetSeconds(int.Parse(Console.ReadLine()));

                Console.Clear();

                ChangeConsoleColor.WellDoneColor();
                Console.WriteLine("Новое значение секунд установлено!\n");

                ChangeConsoleColor.Reset();
            }
            catch (Exception ex)
            {
                Console.Clear();

                ChangeConsoleColor.ExceptionColor();

                Console.WriteLine(ex.Message + "\n");

                ChangeConsoleColor.Reset();
            }
        }

        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Выберите действие:\n" +
                           "1) Установить значение n-секунд.\n" +
                           "2) Перейти на страницу вычислений.\n\n" +
                           "Ваш выбор: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            SetSeconds();
                            break;
                        case 2:
                            CalculationPage();
                            break;
                        default:
                            ActionDoesntExist();
                            break;
                    }
                }
                catch
                {
                    ActionDoesntExist();
                }
            }
        }

        static void ActionDoesntExist()
        {
            Console.Clear();

            ChangeConsoleColor.ExceptionColor();

            Console.WriteLine("Такого действия не существует\n");

            ChangeConsoleColor.Reset();
        }

        static void CalculationPage()
        {
            Console.Clear();

            bool isExit = false;

            while (!isExit)
            {
                try
                {
                    if (TimeManager.CountOfSeconds == 0)
                    {
                        ChangeConsoleColor.ExceptionColor();
                        Console.WriteLine("Значение секунд не установлено.\n");

                        ChangeConsoleColor.Reset();
                        return;
                    }

                    Console.Write("Выберите действие:\n" +
                           "1) Показать сколько полных часов прошло с начала суток.\n" +
                           "2) Показать сколько полных минут прошло с начала очередного часа.\n" +
                           "3) Показать сколько полных секунд прошло с начала очередной минуты.\n" +
                           "4) Вернуться в главное меню.\n\n" +
                           "Ваш выбор: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            GetFullHours();
                            break;
                        case 2:
                            GetFullMinutes();
                            break;
                        case 3:
                            GetFullSeconds();
                            break;
                        case 4:
                            isExit = true;
                            break;
                        default:
                            ActionDoesntExist();
                            break;
                    }
                }
                catch
                {
                    ActionDoesntExist();
                }
            }

            Console.Clear();
        }

        static void GetFullHours()
        {
            Console.Clear();

            Console.WriteLine($"Установленное значение секунд: {TimeManager.CountOfSeconds}\n");

            ChangeConsoleColor.WellDoneColor();
            Console.WriteLine($"Полных часов прошло с начала суток: {TimeManager.GetFullHours()}\n");
            ChangeConsoleColor.Reset();
        }

        static void GetFullMinutes()
        {
            Console.Clear();

            Console.WriteLine($"Установленное значение секунд: {TimeManager.CountOfSeconds}\n");

            ChangeConsoleColor.WellDoneColor();
            Console.WriteLine($"Полных минут прошло с начала очередного часа: {TimeManager.GetFullMinutes()}\n");
            ChangeConsoleColor.Reset();
        }

        static void GetFullSeconds()
        {
            Console.Clear();

            Console.WriteLine($"Установленное значение секунд: {TimeManager.CountOfSeconds}\n");

            ChangeConsoleColor.WellDoneColor();
            Console.WriteLine($"Полных секунд прошло с начала очередной минуты: {TimeManager.GetFullSeconds()}\n");
            ChangeConsoleColor.Reset();
        }
    }
}