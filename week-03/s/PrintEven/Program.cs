using System;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
