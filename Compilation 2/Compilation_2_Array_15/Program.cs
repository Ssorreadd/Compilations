using System;

namespace Compilation_2_Array_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("\nЗаполните массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nВывод: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if ((i - 1) % 2 == 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
