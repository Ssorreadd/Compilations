using System;

namespace Compilation_1_Chapter_7_28
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите натуральное число n: ");
                int[] nums = new int[int.Parse(Console.ReadLine())];

                Console.Write("Введите число p: ");
                double p = double.Parse(Console.ReadLine());

                Console.Write("Введите число k: ");
                double k = double.Parse(Console.ReadLine());

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

                Console.WriteLine("\nИсходная последовательность:");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.WriteLine($"{i}) {nums[i]}");
                }


                int countNumsBiggerThanP = 0;
                int countNumsEndsFive = 0;
                int countNumsMultipliesK = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > p)
                    {
                        countNumsBiggerThanP++;
                    }
                    if (nums[i] % 10 == 5)
                    {
                        countNumsEndsFive++;
                    }
                    if (nums[i] % k == 0)
                    {
                        countNumsMultipliesK++;
                    }
                }

                Console.WriteLine($"\nКол-во чисел, которые больше {p}: {countNumsBiggerThanP}\n" +
                    $"Кол-во чисел, которые оканчиваются цифрой 5: {countNumsEndsFive}\n" +
                    $"Кол-во чисел, которые кратны числу {k}: {countNumsMultipliesK}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
