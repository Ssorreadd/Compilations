using System;
using System.IO;

namespace Compilation_2_Text_41
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file1;
            string[] file2;
            string[] file3;

            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text41(1).txt"))
            {
                file1 = reader.ReadToEnd().Split(' ');
            }

            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text41(2).txt"))
            {
                file2 = reader.ReadToEnd().Split(' ');
            }

            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\text41(3).txt"))
            {
                file3 = reader.ReadToEnd().Split(' ');
            }

            using (FileStream stream = new FileStream(@"C:\Users\d169\Desktop\text41(таблица).txt", FileMode.OpenOrCreate))
            { }

            using (StreamWriter writer = new StreamWriter(@"C:\Users\d169\Desktop\text41(таблица).txt", false))
            {
                string space = "                    ";

                for (int i = 0; i < file1.Length; i++)
                {
                    writer.WriteLine($"|{file1[i]}{space}{file2[i]}{space}{file3[i]}|");
                }
            }

            Console.ReadKey();
        }
    }
}
