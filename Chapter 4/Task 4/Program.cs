using System;
namespace Virtual_Colums
{
    class VirtualColums
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            int numForFirstCol = int.Parse(inputLine);
            inputLine = Console.ReadLine();
            double numForSecondCol = double.Parse(inputLine);
            inputLine = Console.ReadLine();
            double numForThirdCol = double.Parse(inputLine);
            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}",
                numForFirstCol, numForSecondCol, numForThirdCol);
        }
    }
}
