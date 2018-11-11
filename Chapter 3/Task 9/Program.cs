using System;
using System.Linq;

namespace CheckIfAPointIsWithinACircleAndOutOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            int radius = 5;
            bool isInTheCircle = false;
            if ((radius * radius) >= ((pointX * pointX) + (pointY * pointY)))
            {
                isInTheCircle = true;
            }

            // Set the rectangle's coordinates
            int rectBotLeftX = -1;
            int rectBotLeftY = 1;
            int rectTopRigthX = 5;
            int rectTopRigthY = 5;

            // Check if the point is out of the rectangle
            bool isOutOfTheRect = false;
            if ((rectBotLeftX > pointX) || (rectTopRigthX < pointX) ||
                (rectBotLeftY > pointY) || (rectTopRigthY < pointY))
            {
                isOutOfTheRect = true;
            }


            Console.WriteLine(isInTheCircle && isOutOfTheRect);
        }
    }
}
