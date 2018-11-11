using System;

namespace WholeNumbersDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal number = decimal.Parse(input);

            if (number >= 0)
            {
                if (number > Int64.MaxValue)
                {
                    Console.WriteLine("ulong");
                }
                else if (number > UInt32.MaxValue)
                {
                    Console.WriteLine("long");
                }
                else if (number > Int32.MaxValue)
                {
                    Console.WriteLine("uint");
                }
                else if (number > UInt16.MaxValue)
                {
                    Console.WriteLine("int");
                }
                else if (number > Int16.MaxValue)
                {
                    Console.WriteLine("ushort");
                }
                else if (number > Byte.MaxValue)
                {
                    Console.WriteLine("short");
                }
                else if (number > SByte.MaxValue)
                {
                    Console.WriteLine("byte");
                }
                else
                {
                    Console.WriteLine("sbyte");
                }
            }
            else
            {
                if (number < Int32.MinValue)
                {
                    Console.WriteLine("long");
                }
                else if (number < Int16.MinValue)
                {
                    Console.WriteLine("int");
                }
                else if (number < SByte.MinValue)
                {
                    Console.WriteLine("short");
                }
                else
                {
                    Console.WriteLine("sbyte");
                }
            }
        }
    }
}
