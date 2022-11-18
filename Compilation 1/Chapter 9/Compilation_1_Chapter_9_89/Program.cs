using System;

namespace Compilation_1_Chapter_9_89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, в котором встречается одна буква \"с\" и одна буква \"т\": ");
            string line = Console.ReadLine();

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'с')
                {
                    Console.WriteLine("\nБуква \"с\" встречается раньше, чем буква \"т\"");
                    break;
                }
                else if (line[i] == 'т')
                {
                    Console.WriteLine("\nБуква \"т\" встречается раньше, чем буква \"с\"");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
