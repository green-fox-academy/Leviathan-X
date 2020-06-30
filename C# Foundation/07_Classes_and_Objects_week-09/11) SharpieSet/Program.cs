using System;
using System.Collections.Generic;
using System.Text;

namespace _11__SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reuse your Sharpie class
            // Create SharpieSet class
            //      it contains a list of Sharpie
            //      Add method CountUsable() -> sharpie is usable if it has ink in it
            //      Add method RemoveTrash() -> removes all unusable sharpies

            SharpieSet thisSet = new SharpieSet();

            Sharpie num1 = new Sharpie("blue", 10f);
            thisSet.AddSharpie(num1);
            Sharpie num2 = new Sharpie("red", 12f);
            thisSet.AddSharpie(num2);

            Console.WriteLine();
            
            num1.Use();
            num1.Use();
            num2.Use();
            num1.Use();

            thisSet.CountUsable();

            for (int i = 0; i < 10; i++)
            {
                num2.Use();
            }

            Sharpie num3 = new Sharpie("green", 11f);
            thisSet.AddSharpie(num3);

            thisSet.CountUsable();
            
            thisSet.RemoveTrash();

            thisSet.CountUsable();

        }
    }
}
