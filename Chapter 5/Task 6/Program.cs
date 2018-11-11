using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SolvingEquation
{
    static void Main(string[] args)
    {
        //on the 3 input lines are the coefficients: a b and c
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c; //finding the determinanta(Don't know what it is in English ;d)
        //On the output line should be one of the three cases
        //first case: "No real roots"
        //second case: The only root
        //this case: The 2 roots seperated by space
        if (D < 0)
        {
            Console.WriteLine("No real roots");
        }
        if (D == 0)
        {
            double root = -b / 2 * a;
            Console.WriteLine(root);
        }
        else
        {
            Console.WriteLine((-b + Math.Sqrt(D)) / (2 * a) + " " + (-b - Math.Sqrt(D)) / (2 * a));
        }
    }
}
