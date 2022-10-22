using System;

namespace Compilation_1_Chapter_5_15
{
    class Program
    {
        static bool CheckNum(int num)
        {
            if (num >= 1 && num <= 9)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите целое число от 1 до 9: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine($"Таблица умножения на число \"{num}\"\n\n" +
                        $"{GetMultiplicationTable(num)}");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        static string GetMultiplicationTable(int num)
        {
            if (!CheckNum(num))
                throw new Exception("Необходимо ввести целое значение от 1 до 9");

            string result = "";

            for (int i = 1; i <= 9; i++)
            {
                result += $"\t  {num} * {i} = {num * i}\n";
            }

            return result;
        }
    }
}