using System;

namespace Compilation_1_Capter_5_95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите натуральное число: ");
            string value = Console.ReadLine();

            Console.Write($"Введите число последних чисел, которые хотите сложить: ");

            int result = 0;

            for (int i = value.Length - int.Parse(Console.ReadLine()); i < value.Length; i++)
            {
                result += int.Parse(value[i].ToString());
            }

            Console.Write($"Сумма последних чисел: {result}");
            Console.ReadKey();
        }
    }
}