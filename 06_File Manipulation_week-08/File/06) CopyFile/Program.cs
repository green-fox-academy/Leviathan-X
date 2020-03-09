using System;
using System.IO;

namespace _06__CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string pathioEins = @"C:\Users\Leviathan\Desktop\C# Recap\03) File Manipulation\06) CopyFile\DerFileEins.txt";
            string pathioZwei = @"C:\Users\Leviathan\Desktop\C# Recap\03) File Manipulation\06) CopyFile\DerFileZwei.txt";

            Console.WriteLine($"\nIs ze copying zucces? : {CopyFile(pathioEins, pathioZwei)}"); 
        }

        public static bool CopyFile(string path1, string path2)
        {
            bool ztatuz = false;
            try
            {
                string[] text = File.ReadAllLines(path1);

                File.WriteAllLines(path2, text);
                ztatuz = true;
            }
            catch
            {
                Console.WriteLine("\nNein!");
            }
            return ztatuz;
        }
    }
}
