using System;
namespace _10_CalculateSum
{
    class CalcSum
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int lastElement = int.Parse(inputStr);
            double sum = 1.0;
            for (int i = 2; i <= lastElement; i++)
            {
                sum = sum + (1.0 / i);
            }
            Console.WriteLine("{0:F3}", sum);
        }
    }
}

