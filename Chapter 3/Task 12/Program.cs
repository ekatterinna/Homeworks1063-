using System;
using System.Linq;

namespace CheckIfAGivenBitIs1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            int bitPosition = int.Parse(Console.ReadLine());

            // Check if the bit at the given position is 1
            Console.WriteLine(0 != (inputInteger & (1 << bitPosition)));
        }
    }
}

