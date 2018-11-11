using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ConVertDecimalToHeximal
{
    class ConvertDecimalToHeximal
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            if (num == 0)
            {
                intList.Add(0);
            }
            while (num > 0)
            {
                intList.Add(num % 16);
                num = num / 16;
            }
            char[] charArr = new char[intList.Count];
            for (int i = 0; i < intList.Count; i++)
            {
                switch (intList[i])
                {
                    case 0:
                        charArr[i] = '0';
                        break;
                    case 1:
                        charArr[i] = '1';
                        break;
                    case 2:
                        charArr[i] = '2';
                        break;
                    case 3:
                        charArr[i] = '3';
                        break;
                    case 4:
                        charArr[i] = '4';
                        break;
                    case 5:
                        charArr[i] = '5';
                        break;
                    case 6:
                        charArr[i] = '6';
                        break;
                    case 7:
                        charArr[i] = '7';
                        break;
                    case 8:
                        charArr[i] = '8';
                        break;
                    case 9:
                        charArr[i] = '9';
                        break;
                    case 10:
                        charArr[i] = 'A';
                        break;
                    case 11:
                        charArr[i] = 'B';
                        break;
                    case 12:
                        charArr[i] = 'C';
                        break;
                    case 13:
                        charArr[i] = 'D';
                        break;
                    case 14:
                        charArr[i] = 'E';
                        break;
                    case 15:
                        charArr[i] = 'F';
                        break;
                }
            }

            for (int i = (charArr.Length - 1); i >= 0; i--)
            {
                Console.Write("{0}", charArr[i]);
            }
        }
    }
}


