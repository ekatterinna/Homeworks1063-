using System;
using System.Linq;

namespace SwappingDigitsInANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());

            // Extract the digits
            int a = abcd / 1000;
            int b = (abcd % 1000) / 100;
            int c = (abcd % 100) / 10;
            int d = abcd % 10;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d * 1000 + c * 100 + b * 10 + a);
            Console.WriteLine(d * 1000 + a * 100 + b * 10 + c);
            Console.WriteLine(a * 1000 + c * 100 + b * 10 + d);
        }
    }
}
