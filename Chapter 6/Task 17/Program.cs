using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGreatestCommonDivisorEx62
{
    class TheGreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int temp;
            while (x != 0)
            {
                temp = x;
                x = y % x;
                y = temp;
            }
            System.Console.WriteLine(y);
        }
    }
}


