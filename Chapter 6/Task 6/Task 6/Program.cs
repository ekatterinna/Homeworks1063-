using System;
using System.Numerics;

namespace CalculatingFactorialOverFactorial
{
    class CalculatingFactorialOverFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = n; i > k; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}


