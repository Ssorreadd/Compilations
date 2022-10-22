using System;

namespace Compilation_1_Chapter_4_106
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите порядковый номер месяца: ");
                    int monthNum = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine(GetSeasonName(monthNum));
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        static string GetSeasonName(int monthNum)
        {
            string result = "Введено неверное значение месяца\n";
            switch (monthNum)
            {
                case 1:
                    result = "Время года: Зима\n";
                    break;
                case 2:
                    goto case 1;
                case 3:
                    result = "Время года: Весна\n";
                    break;
                case 4:
                    goto case 3;
                case 5:
                    goto case 3;
                case 6:
                    result = "Время года: Лето\n";
                    break;
                case 7:
                    goto case 6;
                case 8:
                    goto case 6;
                case 9:
                    result = "Время года: Осень\n";
                    break;
                case 10:
                    goto case 9;
                case 11:
                    goto case 9;
                case 12:
                    goto case 1;
            }

            return result;
        }
    }
}
