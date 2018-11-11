using System;
namespace WithoutIF
{
    class GreaterWithoutIF
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            decimal firstNum = decimal.Parse(inputStr);
            inputStr = Console.ReadLine();
            int secondNum = int.Parse(inputStr);
            decimal greater = Math.Max(firstNum, secondNum);
            Console.WriteLine(greater);
        }
    }
}
