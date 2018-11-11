using System;
namespace FindCircleAreaAndPer
{
    class FindPerimeterAndArea
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            byte radius = byte.Parse(inputStr);
            double perimeter = 2 * radius * Math.PI;
            double area = radius * radius * Math.PI;
            Console.WriteLine("{0:F3}", perimeter);
            Console.WriteLine("{0:F3}", area);
        }
    }
}
