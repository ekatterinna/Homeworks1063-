using System;
using System.Linq;

namespace CheckIfAPointIsWithinACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the point's coordinates
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int radius = 5;
            // Check if the point is within or out of the circle
            if ((x * x) + (y * y) > (radius * radius))
            {
                Console.WriteLine("out");
            }
            else
            {
                Console.WriteLine("within");
            }
        }
    }
}
