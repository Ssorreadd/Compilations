using System;

namespace Compilation_2_For_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число А: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Результат: ");

            int repits = 1;
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < repits; j++)
                {
                    Console.Write($"{i} ");
                }

                Console.Write(" ");
                repits++;
            }

            Console.ReadKey();
        }
    }
}
