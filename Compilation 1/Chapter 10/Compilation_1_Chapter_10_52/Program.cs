using System;

namespace Compilation_1_Chapter_10_52
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Результат: ");
            ReverseNum(num);

            Console.ReadKey();
        }

        static void ReverseNum(int num)
        {
            int newNum = num % 10;

            Console.Write(newNum);

            num /= 10;

            if (num > 0)
            {
                ReverseNum(num);
            }
        }
    }
}
