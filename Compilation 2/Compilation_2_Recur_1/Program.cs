using System;

namespace Compilation_2_Recur_1
{
    class Program
    {
        static double Fact(int n)
        {
            if (n <= 1)
            {
                return 1; 
            }

            return n * Fact(n - 1);
        }

        static void Main(string[] args)
        {
            int[] nums = new int[5];

            Console.WriteLine("Введите 5 чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nРезультаты вычисления факториалов:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]}: {Fact(nums[i])}");
            }

            Console.ReadKey();
        }
    }
}
