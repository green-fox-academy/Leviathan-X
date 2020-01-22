using System;

namespace _17__Compare_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print "p2 is longer" if `p2` has more elements than `p1`

            int[] p1 = new int[] {1, 2, 3};

            int[] p2 = new int[] { 4, 5 };

            if (p1.Length > p2.Length)
            {
                Console.WriteLine("\np2 has more elements than p1");
            }

        }
    }
}
