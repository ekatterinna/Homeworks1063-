using System;
using System.Linq;

namespace ThePowerOfGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input weight
            int weight = int.Parse(Console.ReadLine());

            // Calculate the weight on the moon
            Console.WriteLine("{0:f2}", (weight * 0.17));
        }
    }
}
