using System;

namespace Compilation_2_If_15
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

            int sum = 0;

            if (a > c && b > c )
            {
                sum = a + b;
            }
            else if (a > b && c > b)
            {
                sum = a + c;
            }
            else if (b > a && c > a)
            {
                sum = b + c;
            }

            Console.WriteLine($"\nСумма двух наибольших чисел: {sum}");
            Console.ReadKey();
        }
    }
}
