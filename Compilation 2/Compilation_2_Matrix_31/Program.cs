using System;


namespace Compilation_2_Matrix_31
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 100);
                    sum += array[i, j];
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

            double average = sum / (array.GetLength(0) * array.GetLength(1));
            Console.WriteLine($"\nСреднее арифметическое: {average}");

            int row = 0;
            int column = 0;
            int closerNum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < average && array[i, j] > closerNum)
                    {
                        row = i;
                        column = j;
                        closerNum = array[i, j];
                    }
                }
            }

            Console.Write($"\nЭлемент({closerNum}) [{row};{column}] наиболее близок к ср. арифметическому");

            Console.ReadKey();
        }
    }
}
