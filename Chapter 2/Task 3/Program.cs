using System;

namespace FloatingNumbersPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal firstNumber = decimal.Parse(input);
            input = Console.ReadLine();
            decimal secondNumber = decimal.Parse(input);

            decimal result = firstNumber + secondNumber;
            Console.WriteLine("{0:0.000000}", result);
        }
    }
}
