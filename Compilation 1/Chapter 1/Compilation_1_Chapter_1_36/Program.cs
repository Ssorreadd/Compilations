using System;

namespace _1_36
{
    class Program
    {
        static void Main()
        {
            do
            {
                try
                {
                    Console.WriteLine("Для выхода из программы введите \"-0\"\n");

                    Console.Write("Введите радиус внешней окружности: ");
                    double bigR = double.Parse(Console.ReadLine());

                    if (INeedToGo(bigR))
                        break;

                    Console.Write("Введите радиус внутренней окружности: ");
                    double smallR = double.Parse(Console.ReadLine());

                    if (INeedToGo(smallR))
                        break;

                    Console.Clear();

                    ChangeColor("answer");
                    Console.Write("Ответ:");

                    Console.ResetColor();

                    Console.WriteLine($" Площадь кольца при R = {bigR}; r = {smallR}, равна: {GetAnswer(bigR, smallR)}\n\n");
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    ChangeColor("ex");

                    Console.WriteLine(ex.Message.ToString() + "\n");
                    Console.ResetColor();
                }

            } while (true);
        }

        static void ChangeColor(string logic)
        {
            switch (logic)
            {
                case "ex":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "answer":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
        }

        static double GetAnswer(double bigR, double smallR)
        {
            double answer = Math.Round(Math.PI * (Math.Pow(bigR, 2) - Math.Pow(smallR, 2)), 2);

            return answer;
        }

        static bool INeedToGo(double value)
        {
            switch (value)
            {
                case -0:
                    return true;

                default:
                    return false;
            }
        }
    }
}