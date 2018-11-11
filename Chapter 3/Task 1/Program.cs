using System;
using System.Linq;

namespace OddOrEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number
            int inputValue = int.Parse(Console.ReadLine());

            // Checks if the number is even or odd
            Console.WriteLine((0 == inputValue % 2) ? "Even" : "Odd");
        }
    }
}

