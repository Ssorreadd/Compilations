using System;
using System.Text;

namespace Compilation_1_Chapter_4_34
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Введите первое число: ");
                    double firstNum = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double secondNum = int.Parse(Console.ReadLine());

                    Console.ResetColor();

                    Console.Clear();

                    ColorOutput(DivisorCheck(firstNum, secondNum).ToString());
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "\n");
                }
            }
        }

        static void ColorOutput(string text)
        {
            string[] sub = text.Split('\n');

            foreach (var line in sub)
            {
                if (line.Contains("не является"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (line.Contains("является"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (line != "")
                {
                    Console.WriteLine(line);
                }
            }
        }

        static StringBuilder DivisorCheck(double firstNum, double secondNum)
        {
            StringBuilder result = new StringBuilder().AppendLine("Результаты вычислений");

            switch (firstNum % secondNum)
            {
                case 0:
                    result.AppendLine($"Число \"{secondNum}\" является делителем числа \"{firstNum}\"");
                    break;
                default:
                    result.AppendLine($"Число \"{secondNum}\" не является делителем числа \"{firstNum}\"");
                    break;
            }

            switch (secondNum % firstNum)
            {
                case 0:
                    result.AppendLine($"Число \"{firstNum}\" является делителем числа \"{secondNum}\"\n");
                    break;
                default:
                    result.AppendLine($"Число \"{firstNum}\" не является делителем числа \"{secondNum}\"\n");
                    break;
            }

            return result;
        }
    }
}