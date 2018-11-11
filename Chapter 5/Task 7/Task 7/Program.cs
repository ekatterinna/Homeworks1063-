using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxValue = double.MinValue;
            double n;
            for (int i = 0; i < 5; i++)
            {
                n = double.Parse(Console.ReadLine());
                if (n>maxValue)
                {
                    maxValue = n;
                }
            }
            Console.WriteLine(maxValue);
        }
    }
}
