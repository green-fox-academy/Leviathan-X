using System;

namespace _1__Logical_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 3;
            bool vyraz1 = x1 > y1;

            Console.WriteLine(vyraz1);
            Console.WriteLine(x1 > y1);
            Console.WriteLine("{0} > {1} .. {2}", x1, y1, x1 > y1);

            Console.WriteLine(" ");

            int x2 = 4;
            int y2 = 4;

            Console.WriteLine("{0} > {1} .. {2}", x2, y2, x2 > y2);
            Console.WriteLine("{0} >= {1} .. {2}", x2, y2, x2 >= y2);
            Console.WriteLine("{0} == {1} .. {2}", x2, y2, x2 == y2);

            Console.WriteLine(" ");

            float x3 = 31.1f;
            float y3 = 31.2f;
            Console.WriteLine("{0} == {1} .. {2}", x3, y3, x3 == y3);
            Console.WriteLine("{0} <= {1} .. {2}", x3, y3, x3 <= y3);


            Console.WriteLine(" ");

            string jmeno1 = "Pepa";
            string jmeno2 = "Dežo";

            Console.WriteLine("{0} == {1} .. {2}", jmeno1, jmeno2, jmeno1 == jmeno2);

        }
    }
}
