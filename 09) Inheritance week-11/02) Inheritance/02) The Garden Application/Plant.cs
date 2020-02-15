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
            if (WaterAmount <= 7)
            {
                Console.WriteLine($"\nThe {color} plant needs water!");
            } 
            else
            {
                Console.WriteLine($"\nThe {color} plant doesn't need water.");
            }
        } 
    }
}
