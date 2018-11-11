using System;
namespace GreaterFrom5Nums
{
    class GreaterFromFive
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            decimal firstNum = decimal.Parse(inputStr);
            inputStr = Console.ReadLine();
            decimal secondNum = decimal.Parse(inputStr);
            inputStr = Console.ReadLine();
            decimal greater = Math.Max(firstNum, secondNum);
            decimal thirdNum = decimal.Parse(inputStr);
            greater = Math.Max(thirdNum, greater);
            inputStr = Console.ReadLine();
            decimal fourthNum = decimal.Parse(inputStr);
            greater = Math.Max(fourthNum, greater);
            inputStr = Console.ReadLine();
            decimal fifthNum = decimal.Parse(inputStr);
            greater = Math.Max(fifthNum, greater);
            Console.WriteLine(greater);
        }
    }
}
