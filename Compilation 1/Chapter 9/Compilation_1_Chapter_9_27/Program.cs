using System;

namespace Compilation_1_Chapter_9_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "программа";

            string rom = $"{source[1]}{source[2]}{source[6]}";
            string rampa = $"{source[1]}{source[5]}{source[6]}{source[0]}{source[8]}";

            Console.WriteLine($"Исходное слово: {source}\n" +
                $"Получено: {rom}, {rampa}");

            Console.ReadKey();
        }
    }
}
