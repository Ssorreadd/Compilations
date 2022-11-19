using System;

namespace Compilation_2_Case_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Достоинство карты N(от 6 до 14): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите Масть карты M(от 1 до 4): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("\nРезультат: ");

            switch (n)
            {
                case 6:
                    Console.Write("шестёрка ");
                    break;
                case 7:
                    Console.Write("семёрка ");
                    break;
                case 8:
                    Console.Write("восьмёрка ");
                    break;
                case 9:
                    Console.Write("девятка ");
                    break;
                case 10:
                    Console.Write("десятка ");
                    break;
                case 11:
                    Console.Write("валет ");
                    break;
                case 12:
                    Console.Write("дама ");
                    break;
                case 13:
                    Console.Write("король ");
                    break;
                case 14:
                    Console.Write("туз ");
                    break;
            }

            switch (m)
            {
                case 1:
                    Console.Write("пик");
                    break;
                case 2:
                    Console.Write("треф");
                    break;
                case 3:
                    Console.Write("бубен");
                    break;
                case 4:
                    Console.Write("червей");
                    break;
            }

            Console.ReadKey();
        }
    }
}
