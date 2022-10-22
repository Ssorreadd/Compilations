using System;

namespace Compilation_1_Chapter_4_130
{
    class Program
    {
        static DateTime[] Birthdays { get; set; } 

        static void AddBirthday()
        {
            Console.Write("Введите день: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (Birthdays == null)
            {
                Birthdays = new DateTime[] { new DateTime(year, month, day) };
            }
            else
            {
                DateTime[] tmpArray = new DateTime[]
                {
                    Birthdays[0],
                    new DateTime(year, month, day)
                };

                Birthdays = tmpArray;
            }
        }

        static void WhoIsOlder()
        {
            Console.Write("Данные:\n" +
                $"1-й человек родился: {Birthdays[0].Date.ToShortDateString()}\n" +
                $"2-й человек родился: {Birthdays[1].Date.ToShortDateString()}\n\n");

            if (Birthdays[0].Year >= Birthdays[1].Year)
            {
                if (Birthdays[0].Month <= Birthdays[1].Month)
                {
                    if (Birthdays[0].Day < Birthdays[1].Day)
                    {
                        Console.WriteLine("1-й человек старше\n");
                        return;
                    }
                    else if (Birthdays[1].Day < Birthdays[0].Day)
                    {
                        Console.WriteLine("2-й человек старше\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Они одного возраста\n");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("2-й человек старше\n");
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите данные первого человека");
                    AddBirthday();

                    Console.WriteLine("\nВведите данные второго человека");
                    AddBirthday();

                    Console.Clear();
                    WhoIsOlder();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }
    }
}
