using System;

namespace Compilation_1_Chapter_2_15
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите трехзначное целочисленное число: ");
                    int newRequest = int.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine(GetNewNum(newRequest));

                }
                catch (Exception ex)
                {
                    Console.Clear();

                    Console.WriteLine(ex.Message.ToString() + "\n");
                }
            }
        }

        static string GetNewNum(int request)
        {
            string oldNum = request.ToString();

            if (oldNum.Length != 3)
            {
                Console.Clear();

                return "Входная строка имела неверный формат.\n";
            }

            string newNum = $"{oldNum[2]}{oldNum[0]}{oldNum[1]}";

            return $"Исходное значение: {oldNum}\n" +
                $"Новое значение: {newNum}\n";
        }
    }
}