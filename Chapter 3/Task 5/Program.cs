using System;
using System.Linq;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the measurements of the trapezoid
            double baseA = double.Parse(Console.ReadLine());
            double baseB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Calculate the trapezoid's area
            Console.WriteLine("{0:f2}", (height * (baseA + baseB) / 2));
        }
    }
}

