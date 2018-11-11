using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startOfRange = (int)Math.Pow(10, n - 1);
            int endOfRange = (n + 1) * startOfRange;

            for (int i = startOfRange; i < endOfRange; i++)
            {
                if (IsNumberContainsDigitsFromRange(i, n))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsNumberContainsDigitsFromRange(int number, int range)
        {
            bool isNumberContainsGivenDigits = true;
            string numberAsString = Convert.ToString(number);
            for (int i = 1; i <= range; i++)
            {
                if (!(numberAsString.Contains(Convert.ToString(i))))
                {
                    isNumberContainsGivenDigits = false;
                }
            }
            return isNumberContainsGivenDigits;
        }
    }
}
