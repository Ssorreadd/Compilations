using System;

namespace Compilation_2_While_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во процентов P(0 < P < 25): ");
            double p = double.Parse(Console.ReadLine());

            int k = 0;
            double s = 1000;

            while (s < 1100)
            {
                s = s + (s * (p / 100));
                k++;
            }

            Console.WriteLine($"\nИтоговая сумма вклада: {s}, месяцев прошло: {k}");
            Console.ReadKey();
        }
    }
}
