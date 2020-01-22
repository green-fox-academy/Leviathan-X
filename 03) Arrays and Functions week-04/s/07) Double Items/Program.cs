using System;

namespace _07__Double_Items
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] numList = new int[] { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.WriteLine();

            for (int num = 0; num < numList.Length; num++)
            {
                numList[num] *= 2; 
            }

            for (int i = 0; i < numList.Length; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }
    }
}
