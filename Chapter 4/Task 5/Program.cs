using System;
namespace DivisibleBy5
{
    class AllDivisibelBy5
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int firstNum = int.Parse(inputStr);
            inputStr = Console.ReadLine();
            int secondNum = int.Parse(inputStr);
            int numberOfP = (secondNum / 5) - (firstNum / 5);
            if (firstNum % 5 == 0)
            {
                numberOfP++;
            }
            Console.WriteLine(numberOfP);
        }
    }
}
