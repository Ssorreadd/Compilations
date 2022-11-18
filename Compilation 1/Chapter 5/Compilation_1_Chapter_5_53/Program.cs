using System;


namespace Compilation_1_Chapter_5_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценки ученика:");

            double[] grades = new double[10];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Оценка по предмету {i + 1}: ");
                grades[i] = double.Parse(Console.ReadLine());
            }

            double average = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }

            Console.WriteLine($"\nСредняя оценка ученика: {average / grades.Length}");
            Console.ReadKey();
        }
    }
}
