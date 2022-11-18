using System;

namespace Compilation_1_Chapter_6_60
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                int[] nums = new int[20];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = random.Next();
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

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 10 == 7)
                    {
                        Console.WriteLine($"\nПорядковый номер элемента, оканчивающегося цифрой 7: {i}");
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine($"\nВ последовательности нет элемента, оканчивающегося цифрой 7");
                }

                Console.ReadKey();
                Console.Clear();
            } 
        }
    }
}
