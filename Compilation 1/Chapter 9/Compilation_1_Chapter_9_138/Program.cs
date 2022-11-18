using System;

namespace Compilation_1_Chapter_9_138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());

            Console.WriteLine(Char.IsDigit(symbol) ? $"\nСимвол {symbol} является цифрой" :
                $"\nСимвол {symbol} не является цифрой");

            Console.ReadKey();
        }
    }
}
