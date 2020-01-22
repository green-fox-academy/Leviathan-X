using System;

namespace _09__AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

            string[] animals = new string[] { "koal", "pand", "zebr" };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
                Console.Write("{0}, ", animals[i]);
            }

            Console.WriteLine();
        }
    }
}
