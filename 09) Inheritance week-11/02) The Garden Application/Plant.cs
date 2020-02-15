using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Plant
    {
        protected string color;
        public float WaterAmount { get { return WaterAmount = 0f; } private set { } }
        public Plant(string Color)
        {
            color = Color;
        }

        public virtual void Status()
        {
            if (WaterAmount <= 6)
            {
                Console.WriteLine($"\nThe plant {color} needs water!");
            } 
            else
            {
                Console.WriteLine($"\nThe plant {color} doesn't need water.");
            }
        } 
    }
}
