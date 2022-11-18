using System;

namespace Compilation_1_Chapter_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите вещественное число a: ");
            double a = double.Parse(Console.ReadLine());

            double n = 1;

            Console.Write($"Числа, которые меньше {a}:");

            for (double i = 2; n <= a; i++)
            {
                Console.Write($" {n}");
                n += 1d / i;
            }

            Console.ReadKey();
        }
    }
}
