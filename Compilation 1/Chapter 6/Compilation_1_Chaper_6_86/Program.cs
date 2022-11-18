using System;

namespace Compilation_1_Chaper_6_86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натурально число: ");
            string value = Console.ReadLine();

            Console.Write("Введите цифру a: ");
            char a = char.Parse(Console.ReadLine());

            Console.Write("Введите цифру b: ");
            char b = char.Parse(Console.ReadLine());

            if (value.Contains(a.ToString()) && value.Contains(b.ToString()))
            {
                int indexA = 0;
                int indexB = 0;

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == a)
                    {
                        indexA = i;
                    }
                    else if (value[i] == b)
                    {
                        indexB = i;
                    }
                }

                Console.WriteLine(indexA > indexB ? $"\nЦифра {a} расположена правее в числе {value}, чем число {b}" : 
                    $"\nЦифра {b} расположена правее в числе {value}, чем число {a}");
            }
            else
            {
                Console.WriteLine($"\nЧисло {value} не содержит в себе обеих цифр {a} и {b}, выполнение программы невозможно");
            }

            Console.ReadKey();
        }
    }
}
