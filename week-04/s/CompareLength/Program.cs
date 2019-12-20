using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };

            if (p1.GetLength(0) < p2.GetLength(0))
            { 
                Console.WriteLine("p2 is longer");
            } else if (p1.GetLength(0) > p2.GetLength(0)) 
            {
                Console.WriteLine("p1 is longer");
            } else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
