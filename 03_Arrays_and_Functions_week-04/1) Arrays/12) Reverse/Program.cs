using System;

namespace _12__Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = new int[] { 3, 4, 5, 6, 7 };
            foreach (int el in aj)
            {
                Console.Write("{0}, ", el);
            }

            Console.WriteLine();
            Array.Reverse(aj);

            foreach (int el in aj)
            {
                Console.Write("{0}, ", el);
            }
            Console.WriteLine();


        }
    }
}
