using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;

            int doubleNum = Doubling(baseNum);

            Console.WriteLine(doubleNum);
        }

        static int Doubling (int doubleFunc)
        {
            return doubleFunc * 2;
        }

    }
}
