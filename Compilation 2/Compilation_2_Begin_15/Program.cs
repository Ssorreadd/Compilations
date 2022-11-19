using System;

namespace Compilation_2_Begin_15
{
    class Program
    {
        const double Pi = 3.14; 
        static void Main(string[] args)
        {
            Console.Write("Введите площадь круга: ");
            double S = double.Parse(Console.ReadLine());

            double R = Math.Sqrt(S / Pi);
            double L = 2 * Pi * R;

            Console.WriteLine($"\nДиаметр: {R / 2} и Длина окружности: {L}");
            Console.ReadKey();
        }
    }
}
