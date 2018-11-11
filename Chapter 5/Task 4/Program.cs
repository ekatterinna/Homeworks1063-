using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortingThreeNumbersInDescendingOrder
{
    static void Main(string[] args)
    {
        // on the 3 input lines are the 3 numbers
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        //first checking for the biggest doubleeger(or equal) and than checking the bigger from the last 2 with nested ifs
        // on the 3 output lines are the sorted doubleegers
        if ((a >= b) && (a >= c))
        {
            if (b >= c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
            }
        }
        else if ((b >= a) && (b >= c))
        {
            if (a >= c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
            }
        }
        else if ((c >= b) && (c >= a))
        {
            if (b >= a)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }


    }
}
