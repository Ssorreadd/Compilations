using System;

namespace Compilation_2_Array_51
{
    class Program
    {
        static void SetValues(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                array[i] = Console.ReadLine();
            }
        }
        static void Output(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массивов: ");
            int n = int.Parse(Console.ReadLine());

            string[] a = new string[n];
            string[] b = new string[n];

            Console.WriteLine("\nЗаполните массив A: ");
            SetValues(a);

            Console.WriteLine("\nЗаполните массив B: ");
            SetValues(b);

            for (int i = 0; i < n; i++)
            {
                string tmpValue = a[i];
                a[i] = b[i];
                b[i] = tmpValue;
            }

            Console.Write("\nA: ");
            Output(a);

            Console.Write("\tB: ");
            Output(b);

            Console.ReadKey();
        }
    }
}
