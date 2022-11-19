using System;

namespace Compilation_2_Array_79
{
    class Program
    {
        static void SetValues(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                array[i] = double.Parse(Console.ReadLine());
            }
        }
        static void Output(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массивов: ");
            int n = int.Parse(Console.ReadLine());

            double[] nums = new double[n];

            Console.WriteLine("\nЗаполните массив: ");
            SetValues(nums);

            double nextValue = 0;
            double prevValue = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prevValue = nextValue;

                nextValue = nums[i];

                nums[i] = prevValue;
            }

            Console.Write("\nВывод: ");
            Output(nums);

            Console.ReadKey();
        }
    }
}
