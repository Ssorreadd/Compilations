using System;

namespace Compilation_1_Chapter_9_166
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string line = Console.ReadLine();

            string[] words = line.Split(' ');

            string tmpWord = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = tmpWord;

            line = "";
            for (int i = 0; i < words.Length; i++)
            {
                line += words[i] + " ";
            }

            Console.WriteLine($"\nРезультат: {line}");

            Console.ReadKey();
        }
    }
}
