using System;

namespace Compilation_1_Chapter_3_15
{
    class Program
    {
        public static bool A { get; set; }
        public static bool B { get; set; }

        static void DefaultLogic()
        {
            A = false;
            B = false;
        }
        static void ChangeLogic()
        {
            if (A == false && B == false)
            {
                A = true;
                B = true;
                return;
            }
            else if (A == true)
            {
                A = false;
                return;
            }
            else if (B == true && A == false)
            {
                A = true;
                B = false;
                return;
            }
        }

        static void Main()
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }

        static void Calculate()
        {
            bool[][] results = new bool[3][] { ExA(), ExB(), ExC() };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат всех вычислений\n");
            Console.ResetColor();

            Console.WriteLine("Значения логических выражений при условии \"не А или не В\"");
            for (int i = 0; i < results.Length + 1; i++)
            {
                Console.Write($"При A = {A}\tB = {B}:\t");
                ChangeColors(results[0][i]);

                Console.WriteLine($"{results[0][i]}");
                Console.ResetColor();

                ChangeLogic();
            }
            DefaultLogic();
            
            Console.WriteLine("\nЗначения логических выражений при условии \"А и (А или не В)\"");
            for (int i = 0; i < results.Length + 1; i++)
            {
                Console.Write($"При A = {A}\tB = {B}:\t");
                ChangeColors(results[1][i]);

                Console.WriteLine($"{results[1][i]}");
                Console.ResetColor();

                ChangeLogic();
            }
            DefaultLogic();

            Console.WriteLine("\nЗначения логических выражений при условии \"(не А или В) и В\"");
            for (int i = 0; i < results.Length + 1; i++)
            {
                Console.Write($"При A = {A}\tB = {B}:\t");
                ChangeColors(results[2][i]);

                Console.WriteLine($"{results[2][i]}");
                Console.ResetColor();

                ChangeLogic();
            }
            DefaultLogic();
        }

        static void ChangeColors(bool value)
        {
            switch (value)
            {
                case true:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case false:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }

        static bool[] ExA()
        {
            bool[] resultsExA = new bool[4];

            for (int i = 0; i < resultsExA.Length; i++)
            {
                resultsExA[i] = !A || !B;
                ChangeLogic();
            }

            DefaultLogic();
            return resultsExA;
        }

        static bool[] ExB()
        {
            bool[] resultsExB = new bool[4];

            for (int i = 0; i < resultsExB.Length; i++)
            {
                resultsExB[i] = A && (A || !B);
                ChangeLogic();
            }

            DefaultLogic();
            return resultsExB;
        }

        static bool[] ExC()
        {
            bool[] resultsExC = new bool[4];

            for (int i = 0; i < resultsExC.Length; i++)
            {
                resultsExC[i] = (!A || B) && B;
                ChangeLogic();
            }

            DefaultLogic();
            return resultsExC;
        }
    }
}