using System;
using System.IO;

namespace Compilation_2_Text_38
{
    class Program
    {
        static void Main(string[] args)
        {
            string subText;
            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text38.txt"))
            {
                subText = reader.ReadToEnd().Trim();
            }

            Console.Write("Введите максимальную ширину строки (>25): ");
            int weight = int.Parse(Console.ReadLine());

            using (FileStream stream = new FileStream(@"C:\Users\d169\Desktop\text15(edit).txt", FileMode.OpenOrCreate))
            { }
            using (StreamWriter writer = new StreamWriter(@"C:\Users\d169\Desktop\text15(edit).txt", false))
            {
                int lineCounter = 0;

                for (int i = 0; i < subText.Length; i++)
                {
                    if (subText[i].Equals('\n') || subText[i].Equals('\r'))
                    {
                        lineCounter = 0;
                    }
                    if (lineCounter > weight)
                    {
                        writer.WriteLine();
                        lineCounter = 0;
                    }

                    writer.Write(subText[i]);
                    lineCounter++;
                }
            }

            Console.WriteLine("\nШирина изменена!");
            Console.ReadKey();
        }
    }
}
