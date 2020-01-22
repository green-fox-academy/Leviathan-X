using System;

namespace AppendAFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            string typo = "\nChinchill";
            AppendAFunc(typo);

        }
        static void AppendAFunc (string append)
        {
            Console.WriteLine(append + "a");
        }
    }
}
