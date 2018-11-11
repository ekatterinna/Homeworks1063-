using System;

class ExchangeNumbers
{
    static void Main()
    {
        // Read the input numbers
        Console.WriteLine("Please input the first integer, a = ?");
        long firstNumber = long.Parse(Console.In.ReadLine());

        Console.WriteLine("Please input the second integer, b = ?");
        long secondNumber = long.Parse(Console.In.ReadLine());

        // Check if the first number is bigger, than the second number
        if (firstNumber > secondNumber)
        {
            long comparator = firstNumber;
            firstNumber = secondNumber;
            secondNumber = comparator;
        }

        // Print the output
        Console.WriteLine("a: " + firstNumber + "\nb: " + secondNumber);
    }
}
