using System;
using System.Linq;

namespace Compilation_1_Chapter_7_66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] classes = new int[20];

            Console.WriteLine("Заполните кол-во учеников к классах:");
            for (int i = 0; i < classes.Length; i++)
            {
                Console.Write($"Учеников в классе {i + 1}: ");
                classes[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nЧисленность самого большого класса({classes.Max()}) " +
                $"превышает численность самого маленького класса({classes.Min()}) на {classes.Max() - classes.Min()} учеников");
           
            Console.ReadKey();
        }
    }
}