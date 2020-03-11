using System;

namespace Matrix_Rotate
{
    class Program
    {
        static int ArraySize = 3;
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3,3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            MatrixPrint(matrix1);

            Console.WriteLine();
            MatrixRotate(matrix1);
            MatrixPrint(matrix1);
        }

        static void MatrixRotate(int[,] matrix)
        {
            for (int i = 0; i < ArraySize/2; i++)
            {
                for (int j = i; j < ArraySize - i - 1; j++)
                {
                    int temporary = matrix[i, j];
                    matrix[i, j] = matrix[ArraySize - 1 - j, i];
                    matrix[ArraySize - 1 - j, i] = matrix[ArraySize - 1 - i, ArraySize - 1 - j];
                    matrix[ArraySize - 1 - i, ArraySize - 1 - j] = matrix[j, ArraySize - 1 - i];
                    matrix[j, ArraySize - 1 - i] = temporary;
                }
            }
        }

        static void MatrixPrint(int[,] matrix)
        {
            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++) Console.Write(matrix[i, j] + " ");
                Console.Write("\n");
            }
        }
    }
}
