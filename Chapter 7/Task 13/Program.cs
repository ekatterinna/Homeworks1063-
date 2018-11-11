﻿using System;

namespace Find3x3MatrixWithMaxSUm
{
    class Program
    {
        private static int j;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] transformation = input.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(transformation[j]);
                }

            }

            int currentSum = 0;
            int maxSum = 0;
            int maxSquareX = 0;
            int maxSquareY = 0;
            // find square
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    for (int i2 = i; i2 < i + 3; i2++)
                    {
                        for (int j2 = j; j2 < j + 3; j2++)
                        {
                            currentSum += matrix[i2, j2];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquareX = j;
                        maxSquareY = i;
                    }
                    currentSum = 0;
                }
            }
            // output
            for (int i2 = maxSquareY; i2 < maxSquareY + 3; i2++)
            {
                for (int j2 = maxSquareX; j2 < maxSquareX + 3; j2++)
                {
                    Console.Write(matrix[i2, j2] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
