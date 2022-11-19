using System;

namespace Compilation_2_File_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Properties.Resources.file.Split(' ');

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += double.Parse(nums[i]);
                }
            }

            Console.WriteLine($"\nСумма чисел с четным номером: {sum}");
            Console.ReadKey();
        }
    }
}
