using System;


namespace Compilation_1_Chapter_1_61
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Введите вещественное число: ");
                double value = double.Parse(Console.ReadLine());

                Console.Write("\nВыберите степень:\n" +
                    "1) 4\n" +
                    "2) 6\n" +
                    "3) 7\n" +
                    "4) 8\n" +
                    "5) 9\n" +
                    "6) 10\n" +
                    "7) 13\n" +
                    "8) 15\n" +
                    "9) 21\n" +
                    "10) 28\n" +
                    "11) 64\n\n" +
                    "Ваш выбор: ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Ответ: {GetCase1(value)}\n");
                        break;
                    case 2:
                        Console.WriteLine($"Ответ: {GetCase2(value)}\n");
                        break;
                    case 3:
                        Console.WriteLine($"Ответ: {GetCase3(value)}\n");
                        break;
                    case 4:
                        Console.WriteLine($"Ответ: {GetCase4(value)}\n");
                        break;
                    case 5:
                        Console.WriteLine($"Ответ: {GetCase5(value)}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Ответ: {GetCase6(value)}\n");
                        break;
                    case 7:
                        Console.WriteLine($"Ответ: {GetCase7(value)}\n");
                        break;
                    case 8:
                        Console.WriteLine($"Ответ: {GetCase8(value)}\n");
                        break;
                    case 9:
                        Console.WriteLine($"Ответ: {GetCase9(value)}\n");
                        break;
                    case 10:
                        Console.WriteLine($"Ответ: {GetCase10(value)}\n");
                        break;
                    case 11:
                        Console.WriteLine($"Ответ: {GetCase11(value)}\n");
                        break;
                }

            } while (true);
        }

        static string GetCase1(double value)
        {
            double res = value * value;
            return $"{res * res}";
        }
        static string GetCase2(double value)
        {
            double res = value * value;
            res *= value;
            return $"{res * res}";
        }
        static string GetCase3(double value)
        {
            double res = value * value;
            res *= value * value;
            res *= value * value;
            return $"{res * value}";
        }
        static string GetCase4(double value)
        {
            double res = value * value;
            res = res * res;
            return $"{res * res}";
        }
        static string GetCase5(double value)
        {
            double res = value * value;
            res *= value;
            res = res * res * res;
            return $"{res}";
        }
        static string GetCase6(double value)
        {
            double sqrt = value * value;
            double res = sqrt * sqrt;
            res = res * res * sqrt;
            return $"{res}";
        }
        static string GetCase7(double value)
        {
            double res = value * value;
            res *= value;
            res = res * res;
            res *= res;
            return $"{res * value}";
        }
        static string GetCase8(double value)
        {
            double res = value * value;
            res = res * res * value;
            return $"{res * res * res}";
        }
        static string GetCase9(double value)
        {
            double res = value * value * value;
            res = res * res * value;
            return $"{res * res * res}";
        }
        static string GetCase10(double value)
        {
            double res = value * value * value;
            res = res * res * value;
            res = res * res;
            return $"{res * res}";
        }
        static string GetCase11(double value)
        {
            double res = value * value;
            res = res * res;
            res = res * res;
            res = res * res;
            res = res * res;
            return $"{res * res}";
        }
    }
}