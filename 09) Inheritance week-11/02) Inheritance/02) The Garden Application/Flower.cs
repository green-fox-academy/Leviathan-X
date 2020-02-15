using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Flower : Plant
    {
        
        public Flower(string Color) :base(Color)
        {
            MaxWater = 5f;
        }

        public override void Status()
        {
            if (WaterAmount <= MaxWater)
            {
                Console.WriteLine($"\nThe {color} flower needs water!");
            }
            else
            {
                Console.WriteLine($"\nThe {color} flower doesn't need water.");
            }
        }

        public override void Feed(float waterInput)
        {
            WaterAmount += (waterInput/100) * 75;
        }

    }
}
