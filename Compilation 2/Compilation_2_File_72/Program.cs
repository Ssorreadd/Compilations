using System;
using System.Collections.Generic;
using System.IO;

namespace Compilation_2_File_72
{
    class Program
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        static void Main()
        {
            List<Program> dates = new List<Program>();

            string[] sub;
            using (StreamReader reader = new StreamReader(@"C:\Users\d169\Desktop\file72.txt"))
            {
                sub = reader.ReadToEnd().Split(' ');
            }

            for (int i = 0; i < sub.Length; i++)
            {
                string[] subDate = sub[i].Split('/');

                Program date = new Program()
                {
                    Day = int.Parse(subDate[0]),
                    Month = int.Parse(subDate[1]),
                    Year = int.Parse(subDate[2])
                };

                dates.Add(date);
            }

            string pastAutumnDate = "00/00/0000";
            for (int i = 0; i < dates.Count; i++)
            {
                string[] subAutumn = pastAutumnDate.Split('/');

                if ((dates[i].Month == 9 || dates[i].Month == 10 || dates[i].Month == 11))
                {
                    if (dates[i].Year >= int.Parse(subAutumn[2]))
                    {
                        if (dates[i].Month >= int.Parse(subAutumn[1]))
                        {
                            if (dates[i].Day > int.Parse(subAutumn[0]))
                            {
                                pastAutumnDate = $"{dates[i].Day}/{dates[i].Month}/{dates[i].Year}";
                            }
                        }
                    }
                }
            }

            Console.WriteLine(pastAutumnDate);
            Console.ReadKey();
        }
    }
}
