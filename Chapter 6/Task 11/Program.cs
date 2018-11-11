using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HowManyZerosInNFactorialEx13
{
    class HowManyZerosAtTheEndInNFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int five = 5;
            int sum = 0;
            int deviding = 1;

            while (deviding > 0)
            {
                sum = sum + n / five;
                deviding = n / five;
                five = five * 5;
            }

            System.Console.WriteLine(sum);
        }
    }
}
