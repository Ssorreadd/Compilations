using System;

namespace Compilation_1_Chapter_9_104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово из четного числа букв: ");
            string word = Console.ReadLine();

            char[] letters = word.ToCharArray();

            for (int i = 0; i < letters.Length / 2; i++)
            {
                char tmpWord = letters[i];
                letters[i] = letters[letters.Length - 1 - i];
                letters[letters.Length - 1 - i] = tmpWord;
            }

            word = "";
            for (int i = 0; i < letters.Length; i++)
            {
                word += letters[i];
            }

            Console.WriteLine($"\nНовое слово: {word}");
            Console.ReadKey();
        }
    }
}
