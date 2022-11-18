using System;

namespace Compilation_1_Chapter_11_29
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 100);
            }

            int sum = 0;
            int sumDegreeNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sumDegreeNum += (int)Math.Pow(nums[i], 2);
            }

            Console.WriteLine(sum % 2 == 0 ? $"Сумма({sum}) элементов - четная" : $"Сумма({sum}) элементов - нечетная");
            Console.WriteLine(sumDegreeNum.ToString().Length == 5 ? $"Сумма квадратов({sumDegreeNum}) - пятизначное число" : $"Сумма квадратов({sumDegreeNum}) - не пятизначное число");

            Console.ReadKey();
        }
    }
}
