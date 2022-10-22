using System;

namespace Compilation_1_Chapter_2_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        static void Start()
        {
            Console.WriteLine("Найти исходное трёхзначное число \"x\"\n");

            string finiteNumder = "546";
            Console.WriteLine($"Конечное число \"{finiteNumder}\"\n");

            string twoDigitNumber = finiteNumder.Remove(0, 1);
            char secondDigitX = finiteNumder[0];

            Console.WriteLine("К числу \"546\" слева приписали вторую цифру числа \"x\", следовательно,\n" +
                $"исходное двузначное число равно: {twoDigitNumber}, а вторая цифра числа \"x\" равна: {secondDigitX}\n");

            Console.WriteLine($"Т.к. из двузначного числа \"{twoDigitNumber}\" была убрана вторая цифра, вернув её получим " +
                $"исходное трехзначное число \"x\"\n");

            string x = $"{twoDigitNumber[0]}{secondDigitX}{finiteNumder[1]}";
            Console.WriteLine($"Ответ: x = {x}");
        }
    }
}