using System;
using System.Linq;

namespace CalculateRectanglePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the measurements of the rectangle
            uint width = uint.Parse(Console.ReadLine());
            uint height = uint.Parse(Console.ReadLine());

            // Calculate the rectangle's perimeter and area
            Console.WriteLine("P = {0}",
                        (width == 0 || height == 0) ? 0 : (2 * width + 2 * height));
            Console.WriteLine("S = {0}", (width * height));
        }
    }
}
