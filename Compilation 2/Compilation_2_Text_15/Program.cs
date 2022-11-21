using System;
using System.IO;

namespace Compilation_2_Text_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subText;
            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text15.txt"))
            {
                subText = reader.ReadToEnd().Split('\n');
            }

            Console.Write("Введите номер строки, которую хотите удалить: ");
            int deleteIndex = int.Parse(Console.ReadLine());

            if (subText.Length > deleteIndex - 1)
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\d169\Desktop\text15.txt", false))
                {
                    for (int i = 0; i < subText.Length; i++)
                    {
                        if (i != deleteIndex - 1)
                        {
                            writer.WriteLine(subText[i]);
                        }
                    }
                }
            }

            Console.WriteLine("\nСтрока удалена!");
            Console.ReadKey();
        }
    }
}
