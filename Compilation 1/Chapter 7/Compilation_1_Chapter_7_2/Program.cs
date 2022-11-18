using System;

namespace Compilation_1_Chapter_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало диапозона: ");
            double start = double.Parse(Console.ReadLine());

            Console.Write("Введите лимит диапозона: ");
            double limit = double.Parse(Console.ReadLine());

            Console.Write($"Введите некоторое число, которому должны будут кратны числа в диапозоне [{start};{limit}]: ");
            double someNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nЧисла, кратные {someNum} в в диапозоне [{start};{limit}]:");
            Console.Write("\t");
            for (double i = start; i <= limit; i++)
            {
                if (i % someNum == 0)
                {
                    Console.Write($"{i}\t");
                }
            }

            Console.ReadKey();
        }
    }
}
