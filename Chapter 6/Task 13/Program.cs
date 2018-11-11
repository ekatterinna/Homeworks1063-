using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2ConvertBinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 0;
            string bin = Console.ReadLine();
            char[] charArr = bin.ToCharArray();
            int[] intArr = new int[charArr.Length];
            string[] strArr = new string[charArr.Length];
            for (int i = 0; i < charArr.Length; i++)
            {
                strArr[i] = charArr[i].ToString();
            }
            for (int i = 0, j = charArr.Length - 1; i < charArr.Length; i++, j--)
            {
                intArr[i] = int.Parse(strArr[j]);
            }

            for (int i = 0; i < charArr.Length; i++)
            {
                dec = dec + intArr[i] * (int)Math.Pow(2, i);
            }
            Console.WriteLine(dec);
        }
    }
}
