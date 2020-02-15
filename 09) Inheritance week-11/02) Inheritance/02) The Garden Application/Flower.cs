using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Flower : Plant
    {
        public Flower(string Color) :base(Color)
        {

        }

        public override void Status()
        {
            if (WaterAmount <= 5)
            {
                Console.WriteLine($"\nThe {color} flower needs water!");
            }
            else
            {
                Console.WriteLine($"\nThe {color} flower doesn't need water.");
            }
        }
    }
}
