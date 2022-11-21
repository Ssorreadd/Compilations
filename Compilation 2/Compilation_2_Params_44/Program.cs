using System;

namespace Compilation_2_Params_44
{
    class Program
    {
        static string DecToBin(int n)
        {
            return Convert.ToString(n, 2);
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

            Console.WriteLine("\nРезультаты перевода в двоичную систему:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]}: {DecToBin(nums[i])}");
            }

            Console.ReadKey();
        }
    }
}
