using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
