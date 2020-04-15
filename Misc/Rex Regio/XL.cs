using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class XL
    {
        public static void LongSpace()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void ShortSpace()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
