using System;

namespace _21__Diagonal_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[4, 4]
            {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
