using System;

namespace Compilation_1_Chapter_4_84
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите 4 целых числа(после ввода одного числа нажмите \"Enter\")");
                    int[] request = new int[]
                    { 
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()), 
                        int.Parse(Console.ReadLine())
                    };

                    Console.Clear();
                    Console.WriteLine(CheckNums(request));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        static string CheckNums(int[] array)
        {
            int sumOfMultiples = 0;
            string multiplesNums = "";
            string result = "";

            if (array[0] % 3 == 0)
            {
                sumOfMultiples += array[0];
                multiplesNums += $"{array[0]} ";
            }
            if (array[1] % 3 == 0)
            {
                sumOfMultiples += array[1];
                multiplesNums += $"{array[1]} ";
            }
            if (array[2] % 3 == 0)
            {
                sumOfMultiples += array[2];
                multiplesNums += $"{array[2]} ";
            }
            if (array[3] % 3 == 0)
            {
                sumOfMultiples += array[3];
                multiplesNums += $"{array[3]} ";
            }
            if (sumOfMultiples != 0)
            {
                result = $"Числа кратные трём: {multiplesNums}\n" +
                    $"Сумма этих чисел: {sumOfMultiples}\n";
            }
            if (sumOfMultiples == 0)
            {
                result = "Числа кратные трём отсутствуют\n";
            }

            return result;
        }
    }
}