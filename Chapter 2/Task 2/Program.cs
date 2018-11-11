using System;

namespace FloatingPointNumbersBestDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            byte digitsAfterFloatingPoint =
                (byte)(input.Length - (input.IndexOf('.') + 1));

            if (digitsAfterFloatingPoint < 8)
            {
                Console.WriteLine("float");
            }
            else if (digitsAfterFloatingPoint < 16)
            {
                Console.WriteLine("double");
            }
            else
            {
                Console.WriteLine("decimal");
            }
        }
    }
}