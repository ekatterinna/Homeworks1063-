using System;
using System.Linq;

namespace ChangeTheBitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());

            // Change the bit at the given position
            if (0 == value)
            {
                value = ~(1 << bitPosition);
                value = value & input;
            }
            else
            {
                value = 1 << bitPosition;
                value = value | input;
            }

            Console.WriteLine(value);
        }
    }
}
