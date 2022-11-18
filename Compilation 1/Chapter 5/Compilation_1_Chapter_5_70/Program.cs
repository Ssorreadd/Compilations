using System;

namespace Compilation_1_Chapter_5_70
{
    class Program
    {
        static void Main(string[] args)
        {
            int cells = 2;
            int timePeriodForDevision = 3;

            for (int i = 3; i <= 24; i += 3)
            {
                Console.WriteLine($"Через {i} часа клеток будет: {Math.Pow(cells, i / timePeriodForDevision)}");
            }

            Console.ReadKey();

        }
    }
}
