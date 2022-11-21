using System;
using System.IO;

namespace Compilation_2_Text_57
{
    class Program
    {
        static void Main(string[] args)
        {
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            string subText;

            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text57.txt"))
            {
                subText = reader.ReadToEnd().Trim();
            }

            using (FileStream stream = new FileStream(@"C:\Users\d169\Desktop\text57(result).txt", FileMode.OpenOrCreate)) { }

            using (StreamWriter writer = new StreamWriter(@"C:\Users\d169\Desktop\text57(result).txt", false))
            {
                int wordCounter = 0;

                for (int i = 0; i < alf.Length; i++)
                {
                    for (int j = 0; j < subText.Length; j++)
                    {
                        if (alf[i].Equals(subText[j]))
                        {
                            wordCounter++;
                        }
                    }

                    writer.WriteLine($"{alf[i]} - {wordCounter}");
                    wordCounter = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
