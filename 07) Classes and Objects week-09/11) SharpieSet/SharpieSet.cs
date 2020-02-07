using System;
using System.Collections.Generic;
using System.Text;

namespace _11__SharpieSet
{
    class SharpieSet
    {
        private List<Sharpie> SharpieList = new List<Sharpie>();

        public SharpieSet()
        {

        }

        public void AddSharpie(Sharpie sharpie)
        {
            SharpieList.Add(sharpie);
            Console.WriteLine($"\nA sharpie of color {sharpie.GetColorName()} has been added to the fold.");
        }

        public void CountUsable()
        {
            int num1 = 0;
            int num2 = 0;
            foreach (var item in SharpieList)
            {
                if (item.GetInkAmount() > 0)
                {
                    num1++;
                }
                else if (item.GetInkAmount() <= 0)
                {
                    num2++;
                }
            }
            Console.WriteLine($"\nThere are {num1} usable sharpies and {num2} are empty.");
        }

        public void RemoveTrash()
        {
            int num = 0;
            // This throws an Exeption!
            //
            // foreach (var item in SharpieList)
            // {
            //     if (item.GetInkAmount() <= 0)
            //     {
            //         SharpieList.Remove(item);
            //         num++;
            //     }
            // }

            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].GetInkAmount() <= 0)
                {
                    SharpieList.Remove(SharpieList[i]);
                    num++;
                }
            }
            Console.WriteLine($"\nThe amount of {num} sharpies has been thrown into trash.");
        }
    }
}
