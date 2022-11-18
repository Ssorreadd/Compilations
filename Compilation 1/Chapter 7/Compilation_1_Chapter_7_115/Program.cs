using System;

namespace Compilation_1_Chapter_7_115
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                int[] nums = new int[12];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = random.Next(0, 10000);
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length - 1 - i; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            var tmp = nums[j + 1];
                            nums[j + 1] = nums[j];
                            nums[j] = tmp;
                        }
                    }
                }

                Console.WriteLine("Исходная последовательность:");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine($"{i}) {nums[i]}");
                }

                bool flag = false;
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        sum += nums[i];
                        flag = true;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine($"\nВ последовательности нет элемента, оканчивающегося цифрой 7");
                }
                else
                {
                    Console.WriteLine($"\nСреднее арифметическое четных чисел последовательности: {sum / 12}");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
