using System;

namespace Compilation_1_Chapter_10_15
{
    class Program
    {
        public static bool CheckForPrimeNum(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int primeCount = 0;
            int num = 100;

            Console.WriteLine("Трехзначные простые числа:");

            Console.Write("\t");
            while (primeCount < 1000)
            {
                num++;
                if (num.ToString().Length == 3)
                {
                    if (CheckForPrimeNum(num))
                    {
                        Console.Write($"{num}\t");
                        primeCount++;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
