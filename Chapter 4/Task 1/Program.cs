using System;
namespace _01_ReadThreeInt
{
    class ReadThreeInt
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int firstNum = int.Parse(inputStr);
            inputStr = Console.ReadLine();
            int secondNum = int.Parse(inputStr);
            inputStr = Console.ReadLine();
            int thirdNum = int.Parse(inputStr);
            long sum = (long)firstNum + secondNum + thirdNum;
            Console.WriteLine(sum);
        }
    }
}
