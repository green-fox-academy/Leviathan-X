using System;

namespace _04__Sharpie
{
    class Sharpie 
    {
        string Color;
        float Width;
        float InkAmount = 100;

        public Sharpie(string color, float width)
        {
            this.Color = color;
            this.Width = width;
        }
        public void Use()
        {
            InkAmount -= 10;
            Console.WriteLine($"\nSharpie of color {Color} used, the amount of {InkAmount}% of ink remaining.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie num1 = new Sharpie("blue", 10f);
            Sharpie num2 = new Sharpie("red", 12f);

            num1.Use();
            num1.Use();
            num2.Use();
            num1.Use();
        }
    }
}
