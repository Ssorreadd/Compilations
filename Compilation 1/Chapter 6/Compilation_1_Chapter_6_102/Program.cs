using System;

namespace Compilation_1_Chapter_6_102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое натуральное число: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе натуральное число: ");
            int value2 = int.Parse(Console.ReadLine());

            int result = 1;

            while (true)
            {
                if (result % value1 == 0 && result % value2 == 0)
                {
                    Console.Write($"Наименьшее общее кратное чисел {value1} и {value2}: {result}");
                    break;
                }
                else
                {
                    result++;
                }
            }

            Console.ReadKey();
        }
    }
}
