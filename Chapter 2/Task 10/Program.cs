using System;

namespace Hearts
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = ' ';

            symbol = char.Parse(Console.ReadLine());

            Console.WriteLine(" {0}{0} {0}{0} ", symbol);
            Console.WriteLine("{0}  {0}  {0}", symbol);
            Console.WriteLine(" {0}   {0} ", symbol);
            Console.WriteLine("  {0} {0}  ", symbol);
            Console.WriteLine("   {0}   ", symbol);
        }
    }
}
