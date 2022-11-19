using System;
using System.Collections.Generic;
using System.IO;

namespace Compilation_2_File_50
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Properties.Resources.s1.Split(' ');
            string[] s2 = Properties.Resources.s2.Split(' ');

            List<double> list = new List<double>();

            for (int i = 0; i < s1.Length; i++)
            {
                list.Add(double.Parse(s1[i]));
            }

            for (int i = 0; i < s2.Length; i++)
            {
                list.Add(double.Parse(s2[i]));
            }

            list.Sort();

            string line = "";
            for (int i = 0; i < list.Count; i++)
            {
                line += $"{list[i]} ";
            }

            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\s3.txt", line);
        
        }
    }
}
