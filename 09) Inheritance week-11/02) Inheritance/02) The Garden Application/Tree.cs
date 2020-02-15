using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Tree : Plant
    {
        public Tree(string Color) :base(Color)
        {
            MaxWater = 10f;
        }

        public override void Status()
        {
            if (WaterAmount < MaxWater)
            {
                Console.WriteLine($"\nThe {color} tree needs water!");
            }
            else
            {
                Console.WriteLine($"\nThe {color} tree doesn't need water.");
            }
        }

        public override void Feed(float waterInput)
        {
            WaterAmount += (waterInput/100) * 40;
        }

    }
}
