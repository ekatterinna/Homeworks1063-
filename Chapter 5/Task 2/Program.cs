using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PlusOrMinus
{
    static void Main(string[] args)
    {
        //on 3 seperate input lines are the 3 integers
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        //on the output line should be "+" if the product is positive, "-" if negative and, "0" if zero
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) ||
            (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("The product of the 3 numbers is negative");
        }
        else Console.WriteLine("The product of the 3 numbers is positive");
    }
}
