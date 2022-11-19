using System;

namespace Compilation_2_Series_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число K: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Введите последовательность ненулевых целых чисел через пробел: ");
            string line = Console.ReadLine();

            string[] nums = line.Split(' ');

            for (int i = 0; i < nums.Length; i++)
            {
                if (int.Parse(nums[i]) > k)
                {
                    Console.WriteLine($"\nНомер первого числа в наборе, большего {k}: {i}");
                    break;
                }
                if (i == nums.Length - 1)
                {
                    Console.WriteLine("\n0");
                }
            }

            Console.ReadKey();
        }

    }
}
