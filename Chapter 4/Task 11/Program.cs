using System;
using System.Numerics;
using System;
using System.Numerics;
namespace First100ofFibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            BigInteger firstFibonacci = 0;
            BigInteger secondFibonacci = 1;
            BigInteger nFibonacci = firstFibonacci + secondFibonacci;
            Console.WriteLine(firstFibonacci);
            Console.WriteLine(secondFibonacci);
            Console.WriteLine(nFibonacci);
            for (int i = 3; i <= 100; i++)
            {
                firstFibonacci = secondFibonacci;
                secondFibonacci = nFibonacci;
                nFibonacci = firstFibonacci + secondFibonacci;
                Console.WriteLine(nFibonacci);
            }
        }
    }
}
