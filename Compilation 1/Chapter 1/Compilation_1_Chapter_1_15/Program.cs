using System;

namespace Сhapter_01
{
    class Program
    {
        private static bool ShouldExit { get; set; }

        private static void Main()
        {
            ShouldExit = false;

            do
            {
                Console.Write("Выберите действие:\n" +
                    "1) Вывести выражение \"а\"\n" +
                    "2) Вывести выражение \"б\"\n" +
                    "3) Вывести выражение \"в\"\n" +
                    "4) Вывести выражение \"г\"\n" +
                    "5) Вывести выражение \"д\"\n" +
                    "6) Вывести выражение \"е\"\n" +
                    "7) Вывести выражение \"ж\"\n" +
                    "8) Вывести выражение \"з\"\n" +
                    "9) Вывести выражение \"и\"\n" +
                    "10) Вывести выражение \"к\"\n" +
                    "0) Выход\n\n" +
                    "Ваш выбор: ");

                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            ExpressionFirst();
                            break;
                        case 2:
                            ExpressionSecond();
                            break;
                        case 3:
                            ExpressionThird();
                            break;
                        case 4:
                            ExpressionFourth();
                            break;
                        case 5:
                            ExpressionFifth();
                            break;
                        case 6:
                            ExpressionSixth();
                            break;
                        case 7:
                            ExpressionSeventh();
                            break;
                        case 8:
                            ExpressionEeighth();
                            break;
                        case 9:
                            ExpressionNinth();
                            break;
                        case 10:
                            ExpressionTenth();
                            break;
                        case 0:
                            ShouldExit = true;
                            break;
                        default:
                            Console.WriteLine("Такого действия не существует.\n");
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Такого действия не существует.\n");
                }

            } while (!ShouldExit);
        }

        private static void ExpressionFirst()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "-1 / (x^2)\n");
        }

        private static void ExpressionSecond()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "a / (b*c)\n");
        }

        private static void ExpressionThird()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "(a*c) / b\n");
        }

        private static void ExpressionFourth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "(a + b) / 2\n");
        }

        private static void ExpressionFifth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "5,45 * ((a + 2*b) / (2 - a))\n");
        }

        private static void ExpressionSixth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "(-b + √(b^2-4*a*c)) / (2 * a)\n");
        }

        private static void ExpressionSeventh()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "(-b + (1/a)) / (2/c)\n");
        }

        private static void ExpressionEeighth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "1 / (1 + ((a + b) / 2))\n");
        }

        private static void ExpressionNinth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "1 / (1 + (1 / (2 + (1 / 2 + (3/5)))))\n");
        }

        private static void ExpressionTenth()
        {
            Console.Clear();
            Console.WriteLine("Вывод:\n" + "      " + "2^(m^n)\n");
        }
    }
}