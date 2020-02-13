using System;

namespace _2__Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vyraz11 = !(5 >= 4);
            Console.WriteLine("!(5 >= 4) ... {0}", vyraz11);
            bool vyraz12 = !(5 <= 4);
            Console.WriteLine("!(5 <= 4) ... {0}", vyraz12 + "\n");

            int cenaPizzy = 150;
            bool otevreno = true;
            int penize = 500;
            bool vyraz1 = (cenaPizzy < penize) && (otevreno == true);
            Console.WriteLine("(cenaPizzy < penize) && (otevreno == true) ... {0}", vyraz1);

            bool vyraz2 = (5 > 4) || (3 < 2);
            Console.WriteLine("(5 > 4) || (3 < 2) .. {0}", vyraz2);

        }
    }
}
