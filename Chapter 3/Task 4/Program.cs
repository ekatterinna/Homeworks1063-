using System;
using System.Linq;

namespace FindTheThirdBitOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number
            int inputNumber = int.Parse(Console.ReadLine());

            // Get the third bit (counting from 0)
            int mask = 0x8;
            Console.WriteLine(0 != (inputNumber & mask) ? 1 : 0);
        }
    }
}

