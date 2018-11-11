using System;
using System.Linq;

namespace DivisibleBy5And7Simultaneously
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number
            int inputValue = int.Parse(Console.ReadLine());

            // Check if the number is divisible 
            Console.WriteLine(((0 == inputValue % 5) && (0 == inputValue % 7)));
        }
    }
}
