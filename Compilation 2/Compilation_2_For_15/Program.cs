using System;

namespace Compilation_2_For_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вещественное число A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите целое число N > 0: ");
            int n = int.Parse(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }

            Console.WriteLine($"\nЧисло {a} в степени {n} = {result}");
            Console.ReadKey();

        }
    }
}
