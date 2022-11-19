using System;

namespace Compilation_2_Matrix_96
{
    class Program
    {
        static Random random = new Random();

        static void Swap(ref int el1, ref int el2)
        {
            int tmp = el1;
            el1 = el2;
            el2 = tmp;
        }

        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Исходные данные:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            string blackList = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (blackList.Contains($"{i};{j}") || blackList.Contains($"{j};{i}"))
                    {
                        continue;
                    }
                    else
                    {
                        Swap(ref array[i, j], ref array[j, i]);
                        blackList += $" {i};{j} {j};{i} ";
                    }

                }
            }

            Console.WriteLine("\nРезультат отраженной квадратной матрицы: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
