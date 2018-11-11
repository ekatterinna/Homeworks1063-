using System;
using System.Linq;

namespace CheckIfANumberIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (2 == input || 3 == input || 5 == input || 7 == input)
            {
                Console.WriteLine("prime");
            }
            else
            {
                if ((0 != (input % 2)) && (0 != (input % 3)) && (0 != (input % 5)) && (0 != (input % 7)))
                {
                    Console.WriteLine("prime");
                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }
        }
    }
}
