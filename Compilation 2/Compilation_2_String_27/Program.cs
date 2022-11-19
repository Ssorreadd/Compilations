using System;

namespace Compilation_2_String_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительно число n1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Введите строку s1: ");
            string s1 = Console.ReadLine();

            Console.Write("Введите целое положительно число n2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Введите строку s2: ");
            string s2 = Console.ReadLine();

            Console.WriteLine($"\nИз строки s1: {s1.Remove(s1.Length - 1 - n1)}\n" +
                $"Из строки s2: {s2.Remove(0, s2.Length - n2)}");

            Console.ReadKey();
        }
    }
}
