using System;


namespace Compilation_1_Chapter_8_32
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
            int num = 1;

            Console.WriteLine("Первые 100 простых чисел:");

            Console.Write("\t");
            while (primeCount < 100)
            {
                num++;

                if (CheckForPrimeNum(num))
                {
                    Console.Write($"{num}\t");
                    primeCount++;
                }
            }

            Console.ReadKey();
        }
    }
}