using System;

namespace Compilation_2_String_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            int countUpLetters = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsUpper(line[i]))
                {
                    countUpLetters++;
                }
            }

            Console.WriteLine($"\nКол-во прописных букв: {countUpLetters}");
            Console.ReadKey();
        }
    }
}
