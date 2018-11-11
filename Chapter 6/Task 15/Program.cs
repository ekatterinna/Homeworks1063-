using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4ConvertHexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = 0;
            string hexadecimal = Console.ReadLine();
            char[] charArr = hexadecimal.ToCharArray();

            int[] intArr = new int[charArr.Length];

            for (int i = 0, j = charArr.Length - 1; i < charArr.Length; i++, j--)
            {
                switch (charArr[j])
                {
                    case '0':
                        intArr[i] = 0;
                        break;
                    case '1':
                        intArr[i] = 1;
                        break;
                    case '2':
                        intArr[i] = 2;
                        break;
                    case '3':
                        intArr[i] = 3;
                        break;
                    case '4':
                        intArr[i] = 4;
                        break;
                    case '5':
                        intArr[i] = 5;
                        break;
                    case '6':
                        intArr[i] = 6;
                        break;
                    case '7':
                        intArr[i] = 7;
                        break;
                    case '8':
                        intArr[i] = 8;
                        break;
                    case '9':
                        intArr[i] = 9;
                        break;
                    case 'A':
                        intArr[i] = 10;
                        break;
                    case 'B':
                        intArr[i] = 11;
                        break;
                    case 'C':
                        intArr[i] = 12;
                        break;
                    case 'D':
                        intArr[i] = 13;
                        break;
                    case 'E':
                        intArr[i] = 14;
                        break;
                    case 'F':
                        intArr[i] = 15;
                        break;
                }
            }

            for (int i = 0; i < charArr.Length; i++)
            {
                dec = dec + intArr[i] * (int)Math.Pow(16, i);
            }
            Console.WriteLine(dec);
        }
    }
}

