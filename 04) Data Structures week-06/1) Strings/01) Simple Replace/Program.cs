using System;

namespace _01__Simple_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "\nIn a dishwasher far, far away.. ";

            example = example.Replace("dishwasher", "galaxy");

            Console.WriteLine(example);

        }
    }
}
