using System;

namespace Compilation_2_Proc_30
{
    class Program
    {
        static int DigitN(int k, int n)
        {
            if (k.ToString().Length < n)
            {
                return -1;
            }

            string result = k.ToString();

            return int.Parse(result[n - 1].ToString());
        }

        static void Main(string[] args)
        {
            Console.Write("Введите последовательность из пяти целых чисел через пробел: ");
            string line = Console.ReadLine();

            string[] nums = line.Split(' ');

            Console.Write("\nРезультат: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{DigitN(int.Parse(nums[i]), i + 1)}");

                if (i != 4)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}
