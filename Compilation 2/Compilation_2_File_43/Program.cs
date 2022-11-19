using System.IO;

namespace Compilation_2_File_43
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"C:\Users\d169\Desktop\file.txt", @"C:\Users\d169\Desktop\NEWFILE.txt", false);
        }
    }
}
