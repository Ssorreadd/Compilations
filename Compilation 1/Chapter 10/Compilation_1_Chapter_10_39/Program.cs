using System;

namespace Compilation_1_Chapter_10_39
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] triangle1 = new double[3];
            double[] triangle2 = new double[3];

            Console.WriteLine("Заполните стороны первого треугольника:");
            for (int i = 0; i < triangle1.Length; i++)
            {
                Console.Write($"Сторона {i + 1}: ");
                triangle1[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nЗаполните стороны второго треугольника:");
            for (int i = 0; i < triangle2.Length; i++)
            {
                Console.Write($"Сторона {i + 1}: ");
                triangle2[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nСумма периметров: {GetPerimeter(triangle1) + GetPerimeter(triangle2)}\n" +
                $"Сумма площадей: {GetSquare(triangle1) + GetSquare(triangle2)}");

            Console.ReadKey();
        }
        static double GetPerimeter(double[] triangle)
        {
            return triangle[0] + triangle[1] + triangle[2];
        }
        static double GetSquare(double[] triangle)
        {
            double p = GetPerimeter(triangle) / 2;

            return Math.Sqrt(p * (p - triangle[0]) * (p - triangle[1]) * (p - triangle[2]));
        }
    }
}
