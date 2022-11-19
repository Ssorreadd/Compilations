using System;

namespace Compilation_2_Boolean_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите целое число A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write($"Введите целое число B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write($"Введите целое число C: ");
            int c = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0 || a > 0 && c > 0 || c > 0 && b > 0)
            {
                Console.WriteLine("\nВысказывание: «Ровно два из чисел A, B, C являются положительными» - истинно");
            }
            else
            {
                Console.WriteLine("\nВысказывание: «Ровно два из чисел A, B, C являются положительными» - ложно");
            }

            Console.ReadKey();
        }
    }
}
