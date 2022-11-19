using System;

namespace Compilation_2_Array_32
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

            int localMinIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
                    {
                        localMinIndex = i + 1;
                        break;
                    }
                }
                catch (Exception)
                {
                }
            }

            Console.WriteLine($"\nНомер локального минимума: {localMinIndex}");
            Console.ReadKey();
        }
    }
}
