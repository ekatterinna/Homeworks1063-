using System;
using System.Linq;

namespace CheckIfTheThirdDigitOfANumberIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input number
            int inputNumber = int.Parse(Console.ReadLine());

            // Get and check if the third digit of the number is 7
            Console.WriteLine(7 == ((inputNumber / 100) % 10));
        }
    }
}


