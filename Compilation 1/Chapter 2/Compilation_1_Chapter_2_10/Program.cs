using System;

namespace Compilation_1_Chapter_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        static void Start()
        {
            bool haveEx = false;

            do
            {
                try
                {
                    Console.Write("Введите двузначное число: ");
                    int value = int.Parse(Console.ReadLine());

                    OutputAll(value);

                    haveEx = true;
                }
                catch (Exception ex)
                {
                    Console.Clear();

                    //Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(ex.Message + "\n");

                    Console.ResetColor();
                }
                 
            } while (!haveEx);
        }

        static void OutputAll(int value)
        {
            Console.Clear();

            MathControls mathControls = new MathControls(value.ToString());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Исходное значение: {mathControls.FirstDigit}{mathControls.SecondDigit}\n");
            Console.ResetColor();

            Console.WriteLine($"Число десятков: {mathControls.GetDecimals()}");
            Console.WriteLine($"Число единиц: {mathControls.GetUnits()}");

            Console.WriteLine($"Сумма цифр: {mathControls.GetSum()}");
            Console.WriteLine($"Произведение цифр: {mathControls.GetMultiplication()}");
        }
    }
}