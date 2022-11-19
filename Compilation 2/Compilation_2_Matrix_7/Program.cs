using System;

namespace Compilation_2_Matrix_7
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];

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

            Console.Write("\nВведите номер строки, которую хотите вывести: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("\nРезультат: ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[k - 1, j]} ");
            }

            Console.ReadKey();
        }
    }
}
