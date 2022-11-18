using System;

namespace Compilation_1_Chapter_7_90
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                int[] febNow = new int[28];
                int[] febPast = new int[28];

                for (int i = 0; i < febNow.Length; i++)
                {
                    febNow[i] = random.Next(0, 100);
                    febPast[i] = random.Next(0, 100);
                }

                int febNowValueSum = 0;
                int febPastValueSum = 0;

                for (int i = 0; i < febPast.Length; i++)
                {
                    febNowValueSum += febNow[i];
                    febPastValueSum += febPast[i];
                }

                Console.WriteLine("Исходные данные: ");
                for (int i = 0; i < 28; i++)
                {
                    Console.WriteLine($"Осадки {i + 1} ферваля этого года: {febNow[i]}");
                    Console.WriteLine($"Осадки {i + 1} ферваля прошлого года: {febNow[i]}\n");
                }

                Console.WriteLine(febNowValueSum > febPastValueSum ? $"\nКол-во осадков({febNowValueSum}) за этот месяц превысило кол-во прошлого года({febPastValueSum})" :
                    $"\nКол-во осадков({febNowValueSum}) за этот месяц не превысило кол-во прошлого года({febPastValueSum})");

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
