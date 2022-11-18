using System;

namespace Compilation_1_Chapter_8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] salary = new double[12, 3];

            Console.WriteLine("Заполните зарплаты работников:\n");

            for (int i = 0; i < salary.GetLength(0); i++)
            {
                for (int j = 0; j < salary.GetLength(1); j++)
                {
                    Console.Write($"Работник {i + 1} Месяц {j + 1}: ");
                    salary[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            double fullSalary = 0;
            double[] salaryOfWorkers = new double[12];
            double[] salaryOfMonth = new double[3];

            for (int i = 0; i < salary.GetLength(0); i++)
            {
                for (int j = 0; j < salary.GetLength(1); j++)
                {
                    fullSalary += salary[i, j];
                    salaryOfWorkers[i] += salary[i, j];

                    salaryOfMonth[j] += salary[i, j];
                }
            }

            Console.WriteLine($"\nОбщая сумма, выплаченная за квартал всем работникам: {fullSalary} руб.\n");
           
            for (int i = 0; i < salaryOfWorkers.Length; i++)
            {
                Console.Write($"{i + 1}й работник получил за квартал: {salaryOfWorkers[i]} руб.\n");
            }

            Console.WriteLine("\nОбщая зарплата работников за:\n" +
                $"1й месяц: {salaryOfMonth[0]} руб.\n" +
                $"2й месяц: {salaryOfMonth[1]} руб.\n" +
                $"3й месяц: {salaryOfMonth[2]} руб.");

            Console.ReadKey();
        }
    }
}
