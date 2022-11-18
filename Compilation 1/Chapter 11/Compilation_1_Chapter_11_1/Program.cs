using System;

namespace Compilation_1_Chapter_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8] { 37, 0, 50, 46, 34, 46, 0, 13 };

            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{i + 1} элемент: {nums[i]}");
            }

            Console.ReadKey();
        }
    }
}
