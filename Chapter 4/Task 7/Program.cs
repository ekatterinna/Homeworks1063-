using System;
namespace Sum5Nums
{
    class SumFiveNums
    {
        static void Main()
        {
            string inputLine = string.Empty;
            int firstNum = 0;
            bool isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                inputLine = Console.ReadLine();
                isNumberCorrect = int.TryParse(inputLine, out firstNum);
            }
            int secondNum = 0;
            isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                inputLine = Console.ReadLine();
                isNumberCorrect = int.TryParse(inputLine, out secondNum);
            }
            int thirdNum = 0;
            isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                inputLine = Console.ReadLine();
                isNumberCorrect = int.TryParse(inputLine, out thirdNum);
            }
            int fourthNum = 0;
            isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                inputLine = Console.ReadLine();
                isNumberCorrect = int.TryParse(inputLine, out fourthNum);
            }
            int fifthNum = 0;
            isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                inputLine = Console.ReadLine();
                isNumberCorrect = int.TryParse(inputLine, out fifthNum);
            }
            long sum = (long)firstNum + secondNum + thirdNum + fourthNum + fifthNum;
            Console.WriteLine(sum);
        }
    }
}
