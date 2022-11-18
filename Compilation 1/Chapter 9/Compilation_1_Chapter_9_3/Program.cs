using System;

namespace Compilation_1_Chapter_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string secondName = Console.ReadLine();

            Console.WriteLine($"\n{firstName} {secondName}");
            Console.ReadKey();
        }
    }
}
