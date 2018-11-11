using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AddingBonusPointsToAdigit
{
    static void Main(string[] args)
    {
        //On the first input line is a digit (0-9)
        //On the output line is one of the three cases
        //if the digit is 0, 9 or more an exception is thrown and the output line is "Bad Input!!!"
        //if the digit is 1, 2 or 3 the output is the digit multiplied by 10
        //if the digit is 4 5 or 6 the output is the digit multiplied by 100
        //if the digit is 7 8 or 9 the output is the digit multiplied by 1000
        int digit = int.Parse(Console.ReadLine());
        try
        {
            switch (digit)
            {
                case 0:
                    throw new Exception("Bad Input!!!");
                    break;
                case 1:
                case 2:
                case 3:
                    digit = digit * 10;
                    Console.WriteLine(digit);
                    break;
                case 4:
                case 5:
                case 6:
                    digit = digit * 100;
                    Console.WriteLine(digit);
                    break;
                case 7:
                case 8:
                case 9:
                    digit = digit * 1000;
                    Console.WriteLine(digit);
                    break;
                default:
                    throw new Exception("Bad Input!!!");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
