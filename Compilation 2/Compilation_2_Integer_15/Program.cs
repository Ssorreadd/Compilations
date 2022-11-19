using System;


namespace Compilation_2_Integer_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3х значное число: ");
            string value = Console.ReadLine();

            string newNum = $"{value[1]}{value[0]}{value[2]}";
            Console.WriteLine($"\nНовое число: {newNum}");

            Console.ReadKey();
        }
    }
}
