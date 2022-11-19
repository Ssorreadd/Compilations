using System;

namespace Compilation_2_Proc_51
{
    class Program
    {
        static void IncTime(ref int h, ref int m, ref int s, int t)
        {
            s += t;

            if (s >= 60)
            {
                while (s >= 60)
                {
                    s -= 60;
                    m++;
                }

                if (m >= 60)
                {
                    while (m >= 60)
                    {
                        m -= 60;
                        h++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите кол-во часов: ");
                int h = int.Parse(Console.ReadLine());

                Console.Write("Введите кол-во минут: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Введите кол-во секунд: ");
                int s = int.Parse(Console.ReadLine());

                Console.Write("Введите кол-во секунд, на которое хотите увеличить время: ");
                int t = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nИсходное время - {h}:{m}:{s}");

                IncTime(ref h, ref m, ref s, t);
                Console.WriteLine($"Время, после увеличения на {t} cек. - {h}:{m}:{s}");

                Console.ReadKey();
            }
        }
    }
}
