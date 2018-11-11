using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> binList = new List<int>();

            while (n > 0)
            {
                binList.Add(n % 2);
                n = n / 2;
            }

            for (int i = binList.Count - 1; i >= 0; i--)
            {
                Console.Write("{0}", binList[i]);
            }
        }
    }
}
