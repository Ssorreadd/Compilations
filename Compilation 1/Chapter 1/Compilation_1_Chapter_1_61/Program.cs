using System;


namespace C_1_61
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

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        GetAnswer(value, 4);
                        break;
                    case 2:
                        GetAnswer(value, 6);
                        break;
                    case 3:
                        GetAnswer(value, 7);
                        break;
                    case 4:
                        GetAnswer(value, 8);
                        break;
                    case 5:
                        GetAnswer(value, 9);
                        break;
                    case 6:
                        GetAnswer(value, 10);
                        break;
                    case 7:
                        GetAnswer(value, 13);
                        break;
                    case 8:
                        GetAnswer(value, 15);
                        break;
                    case 9:
                        GetAnswer(value, 21);
                        break;
                    case 10:
                        GetAnswer(value, 28);
                        break;
                    case 11:
                        GetAnswer(value, 64);
                        break;
                }

            } while (true);
        }

        static void GetAnswer(double value, int degree)
        {
            int subDegree = 0;
            double answer = 1;
            int countOfOperation = 0;

            while (degree % 2 != 0)
            {
                degree--;
                subDegree++;
            }

            for (int i = 1; i <= degree / 2; i++)
            {
                answer *= value * Math.Pow(value, subDegree);

                countOfOperation++;
            }

            if (subDegree != 0)
            {
                countOfOperation++;
            }

            Console.Clear();
            Console.WriteLine($"Ответ: {answer}; Операций: {countOfOperation}\n");
        }
    }
}