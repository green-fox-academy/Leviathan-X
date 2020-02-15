using System;
using System.Collections.Generic;
using System.Text;

namespace _02__The_Garden_Application
{
    class Plant
    {
        protected string color;
        protected float waterAmount = 0f;
        public Plant(string Color)
        {
            color = Color;
        }

        public virtual void Status()
        {
            if (waterAmount <= 6)
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
