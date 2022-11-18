using System;

namespace Compilation_1_Capter_6_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предел интервала, начинающегося со 100: ");
            double rightLimit = double.Parse(Console.ReadLine());

            int countOfWritedNums = 0;

            Console.Write("\nЧисла, оканчивающиеся на 7 и кратные 9: ");

            for (int i = 100; i <= rightLimit; i++)
            {
                if (i % 10 == 7 && i % 9 == 0)
                {
                    Console.Write($" {i}");
                    countOfWritedNums++;
                }

                if (countOfWritedNums == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"\n\nВсего чисел, соответствующих условию, " +
                $"в интервале [100;{rightLimit}]: {countOfWritedNums}");
            Console.ReadKey();
        }
    }
}
