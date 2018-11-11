using System;
using System.Linq;

namespace GetABitFromANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number and position
            int inputNumber = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());

            // Find the bit at the given position 
            Console.WriteLine(0 == (inputNumber & (1 << bitPosition)) ? 0 : 1);
        }
    }
}

