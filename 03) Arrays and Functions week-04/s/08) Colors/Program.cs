using System;

namespace _08__Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            Console.WriteLine();


            string[,] colors = new string[3,5]
            {
                {"lime", "forest green", "olive", "pale green", "spring green" },
                {"orange", "red", "tomato", null, null},
                {"orchid", "violet", "pink", "hot pink", null},
            };

            for (int i = 0; i < colors.GetLength(0); i++)
            {
                for (int j = 0; j < colors.GetLength(1); j++)
                    Console.Write("{0}, ",colors[i, j]);
            }

            Console.WriteLine();
        }
    }
}
