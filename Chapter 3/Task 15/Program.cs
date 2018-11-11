using System;
using System.Linq;

namespace ExchangeThreeBitsInANumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            // Set starting positions
            int startExchangePosition = 3;
            int exchangeBits = 3;
            int exchangeFromPosition = 24;

            // Get bits from the number
            int firstSeqBits = 0;
            int secondSeqBits = 0;
            for (int i = 0; i < exchangeBits; i++)
            {
                if (0 != (input & (1 << (startExchangePosition + i))))
                {
                    firstSeqBits |= (1 << i);
                }

                input &= ~(1 << startExchangePosition + i);

                if (0 != (input & (1 << (exchangeFromPosition + i))))
                {
                    secondSeqBits |= (1 << i);
                }

                input &= ~(1 << exchangeFromPosition + i);
            }

            // Exchange bits 
            input |= secondSeqBits << startExchangePosition;
            input |= firstSeqBits << exchangeFromPosition;

            // Print the result
            Console.WriteLine(input);
        }
    }
}
