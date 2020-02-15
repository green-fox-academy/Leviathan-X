using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Tree : Plant
    {
        public Tree(string Color) :base(Color)
        {

        }

        public override void Status()
        {
            if (WaterAmount < 10)
            {
                Console.WriteLine($"\nThe {color} tree needs water!");
            }
            else
            {
                Console.WriteLine($"\nThe {color} tree doesn't need water.");
            }
        }

        public override void Feed(int waterInput)
        {
            WaterAmount += waterInput;
        }
    }
}
