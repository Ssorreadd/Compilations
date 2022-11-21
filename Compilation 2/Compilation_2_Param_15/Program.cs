using System;


namespace Compilation_2_Param_15
{
    class Program
    {
        static void Split2(int[] a, int nA, out int[] b, out int nB, out int[] c, out int nC)
        {
            nB = 0;
            nC = 0;

            for (int i = 0; i < nA; i++)
            {
                if (a[i] % 2 == 0)
                {
                    nB++;
                }
                else
                {
                    nC++;
                }
            }

            b = new int[nB];
            c = new int[nC];

            int bCount = 0;
            int cCount = 0;

            for (int i = 0; i < nA; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[bCount] = a[i];
                    bCount++;
                }
                else
                {
                    c[cCount] = a[i];
                    cCount++;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int nA = a.Length;

            int[] b;
            int nB;
            int[] c;
            int nC;

            Split2(a, nA, out b, out nB, out c, out nC);

            Console.Write($"Массив B(кол-во элементов: {nB}): ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i]} ");
            }

            Console.Write($"\n\nМассив C(кол-во элементов: {nC}): ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"{c[i]} ");
            }

            Console.ReadKey();
        }
    }
}
