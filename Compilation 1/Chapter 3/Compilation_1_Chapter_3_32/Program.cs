using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilation_1_Chapter_3_32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }

        static void Start()
        {
            Console.Write("Введите значение точки x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение точки y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(FindCorrectCoordinates(x, y).ToString());
        }

        static StringBuilder FindCorrectCoordinates(double x, double y)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Попадания точки [{x};{y}] в заштрихованные участки:\n");
            
            if ((x <= -2) && (y >= 1))
            {
                result.AppendLine("График \"а\"");
            }
            if ((x <= 0 || x >= 0) && ((y >= -2 && y <= 1.5) || (y <= 1.5 && y >= -2)))
            {
                result.AppendLine("График \"б\"");
            }
            if (((x <= 2 && x >= 1) || (x >= 1 && x <= 2)) && ((y >= 1.5 && y <= 4) || (y <= 4 && y >= 1.5)))
            {
                result.AppendLine("График \"в\"");
            }
            if ((x >= 1) && ((y >= 2 && y <= 4) || (y <= 4 && y >= 2)))
            {
                result.AppendLine("График \"г\"");
            }
            if ((x >= 2 && y >= 0) || (x >= 1 && y <= -1))
            {
                result.AppendLine("График \"д\"");
            }
            if ((x >= 2 && y >= 1) || (x >= 2 && y <= -1.5))
            {
                result.AppendLine("График \"е\"");
            }
            if (((x <= 1 && x >= 3) || (x >= 3 && x <= 1)) && ((y >= 2 && y <= -1) || (y <= -1 && y >= 2)))
            {
                result.AppendLine("График \"ж\"");
            }
            if ((((y >= 0.5 && y <= 1.5) || ( y <= 1.5 && y >= 0.5) && x <= 2)) || (y >= 1.5 || y <= 0.5) && x >= 2)
            {
                result.AppendLine("График \"з\"");
            }
            if (result.Length < 50)
            {
                result.Clear();
                result.AppendLine($"Попадания точки [{x};{y}] в заштрихованные участки не зафиксированы.\n");
            }

            return result;
        }
    }
}