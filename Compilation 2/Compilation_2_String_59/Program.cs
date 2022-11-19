using System;

namespace Compilation_2_String_59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полное имя файла: ");
            string fileName = Console.ReadLine();

            Console.Write("\nРасширение файла: ");

            bool flag = false;
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i].Equals('.'))
                {
                    flag = true;
                    continue;
                }
                if (flag)
                {
                    Console.Write(fileName[i]);
                }

            }

            Console.ReadKey();
        }
    }
}
