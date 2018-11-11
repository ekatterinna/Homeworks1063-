using System;

namespace MatrixOutput
{
    class MatrixOutput
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= (row + n - 1); col++)
                {
                    Console.Write("{0,2} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
