using System;
namespace _07._1SumOfNNumbers
{
    class SumOfNNUmbers
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            int numberN = int.Parse(inputLine);
            int currentNum = 0;
            long sum = 0;
            for (int i = 0; i < numberN; i++)
            {
                inputLine = Console.ReadLine();
                currentNum = int.Parse(inputLine);
                sum = sum + currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}


