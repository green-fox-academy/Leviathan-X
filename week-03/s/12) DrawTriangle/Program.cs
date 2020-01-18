using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number of lines: ");
            int userNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
