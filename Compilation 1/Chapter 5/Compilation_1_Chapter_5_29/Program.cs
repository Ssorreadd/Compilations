using System;

namespace Compilation_1_Chapter_5_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Среднее арифметическое всех целых чисел от 1 до 1000: {Average(1, 1000)}\n");

            Console.Write("Введите значение b, которое больше или равно 100: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое всех целых чисел от 100 до {b}: {Average(1, (int)b)}\n");

            Console.Write("Введите значение a, которое меньше или равно 200: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое всех целых чисел от {a} до 200: {Average((int)a, 200)}\n");

            Console.Write("Введите значение a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write($"Введите значение b, которое больше или равно {a}: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Среднее арифметическое всех целых чисел от {a} до {b}: {Average((int)a, (int)b)}\n");
            Console.ReadKey();
        }

        static double Average(int firstNum, int secondNum)
        {
            double result = 0;
            int allNums = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                result += i;
                allNums++;
            }

            result /= allNums;
            return result;
        }
    }
}
