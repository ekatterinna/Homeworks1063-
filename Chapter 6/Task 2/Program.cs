using System;

namespace NumbersFrom1TNDivisibleBy3And7
{
    class NumbersDivisibleBy3And7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //print the numbers from 1 to N non-divisible by 3 and 7 at the same time
            for (int i = 1; i <= n; i++)
            {
                if (!(i % 3 == 0 && i % 7 == 0))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

