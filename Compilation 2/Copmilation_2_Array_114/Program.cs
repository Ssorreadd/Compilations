using System;

namespace Copmilation_2_Array_114
{
    class Program
    {
        static Random random = new Random();

        static void Swap(ref int arrayNum1, ref int arrayNum2)
        {
            int tmp = arrayNum1;
            arrayNum1 = arrayNum2;
            arrayNum2 = tmp;
        }
        static int[] InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;

                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
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
            int[] a = new int[6];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 1000);
            }

            Console.Write($"Исходная последовательность: ");
            Output(a);

            Console.Write($"\n\nОтсортированная последовательность: ");
            Output(InsertSort(a));

            Console.ReadKey();

        }
    }
}
