using System;

namespace Compilation_2_Minmax_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write($"Введите число B, меньшее {c}: ");
            int b = int.Parse(Console.ReadLine());

            int[] nums = new int[10];
            Console.WriteLine("Заполните набор: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                nums[i] = int.Parse(Console.ReadLine()); ;
            }

            int maxValue = 0;
            int indexMax = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = b; j <= c; j++)
                {
                    if (nums[i] == j && nums[i] > maxValue)
                    {
                        maxValue = nums[i];
                        indexMax = i + 1;
                    }
                }
            }

            Console.WriteLine(maxValue == 0 ? "\n0 0" :
                $"\nМаксимальный элемент в интервале [{b};{c}]: {maxValue}, его номер: {indexMax}");

            Console.ReadKey();
        }
    }
}
