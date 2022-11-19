using System;

namespace Compilation_2_String_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            string[] subLine = line.Split(' ');

            int index = 0;
            int maxLength = 0;
            for (int i = 0; i < subLine.Length; i++)
            {
                if (subLine[i].Length > maxLength)
                {
                    index = i;
                    maxLength = subLine[i].Length;
                }
            }

            Console.WriteLine($"Самое длинное слово в предложении: {subLine[index]}");
            Console.ReadKey();
        }
    }
}
