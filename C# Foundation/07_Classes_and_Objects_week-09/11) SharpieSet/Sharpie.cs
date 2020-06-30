using System;
using System.Collections.Generic;
using System.Text;

namespace _11__SharpieSet
{
    class Sharpie
    {
        private string Color;
        private float Width;
        private int InkAmount = 100;

        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
            
        }

        public void Use()
        {
            if (InkAmount > 0) 
            {
                InkAmount -= 10;
                Console.WriteLine($"Used sharpie of color {Color}\t- {InkAmount}% of ink remaining.");
            }
            else if (InkAmount <= 0)
            {
                Console.WriteLine($"Failed to use sharpie of color {Color}!");
            }
        }

        public int GetInkAmount()
        {
            return InkAmount;
        }

        public string GetColorName()
        {
            return Color;
        }

    }
}
