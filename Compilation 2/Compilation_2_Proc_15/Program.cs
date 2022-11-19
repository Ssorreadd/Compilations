using System;

namespace Compilation_2_Proc_15
{
    class Program
    {
        static Random random = new Random();

        static void Output(double[] series1, double[] series2)
        {
            Console.Write($"набор 1:\tнабор 2:\n" +
                $"A = {series1[0]}  \tA = {series2[0]}\n" +
                $"B = {series1[1]}  \tB = {series2[1]}\n" +
                $"C = {series1[2]}  \tC = {series2[2]}\n\n");
        }

        static void ShiftLeft3(ref double[] series)
        {
            double tmpNum = series[0];
            series[0] = series[1];
            series[1] = series[2];
            series[2] = tmpNum;
        }

        static void Main(string[] args)
        {
            double[] series1 = new double[3];
            double[] series2 = new double[3];

            for (int i = 0; i < 3; i++)
            {
                series1[i] = random.Next(1, 100);
                series2[i] = random.Next(1, 100);
            }

            Console.WriteLine("Исходные значения: ");
            Output(series1, series2);

            ShiftLeft3(ref series1);
            ShiftLeft3(ref series2);

            Console.WriteLine("Результат после процедуры:");
            Output(series1, series2);

            Console.ReadKey();
        }
    }
}
