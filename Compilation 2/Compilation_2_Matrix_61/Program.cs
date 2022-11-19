using System;

namespace Compilation_2_Matrix_61
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

            Console.Write("\nВведите номер строки, которыю хотите удалить: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("\nРезультат: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == k - 1)
                    continue;

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
