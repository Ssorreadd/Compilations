using System;

namespace Compilation_1_Chapter_9_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string line = Console.ReadLine();

            Console.Write("Введите первый символ: ");
            char firstLetter = char.Parse(Console.ReadLine());

            Console.Write("Введите второй символ: ");
            char secondLetter = char.Parse(Console.ReadLine());

            int countFirstLetter = 0;
            int countSecondLetter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == firstLetter)
                {
                    countFirstLetter++;
                }
                if (line[i] == secondLetter)
                {
                    countSecondLetter++;
                }
            }

            Console.WriteLine($"\nВхождений символа \"{firstLetter}\": {countFirstLetter}" +
                $"\nВхождений символа \"{secondLetter}\": {countSecondLetter}");

            Console.ReadKey();
        }
    }
}
