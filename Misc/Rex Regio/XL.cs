using System;
using System.Collections.Generic;
using System.Text;

namespace Rex_Regio
{
    static class XL
    {
        public static void ArrowBeforeSpace()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }

        public static void ArrowAfterSpace()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
