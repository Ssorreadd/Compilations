using System;

namespace Compilation_2_Array_100
{
    class Program
    {
        static void SetValues(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Output(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("\nЗаполните массив: ");
            SetValues(nums);

            int newN = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                int repits = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && nums[j] != 0)
                    {
                        repits++;

                        if (repits == 2)
                        {
                            nums[i] = 0;
                            nums[j] = 0;

                            newN -= 2;
                            break;
                        }
                    }
                }
            }

            int[] newNums = new int[newN];
            int newNumsIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    newNums[newNumsIndex] = nums[i];
                    newNumsIndex++;
                }
            }

            Console.Write("\nВывод массива без встечающихся ровно 2 раза чисел: ");
            Output(newNums);

            Console.ReadKey();
        }
    }
}
