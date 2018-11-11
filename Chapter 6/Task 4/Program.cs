using System;

namespace CardDeck
{
    class Cards
    {
        static void Main(string[] args)
        {
            //defining the colors and cards
            string[] colors = new string[4] { "Spades", "Diamonds", "Hearts", "Clubs" };
            string[] cards = new string[13] { "Ace of", "Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", "Eight of", "Nine of", "Ten of", "Jack of", "Queen of", "King of" };

            for (int color = 1; color <= 4; color++)
            {
                for (int card = 2; card <= 14; card++)
                {
                    Console.WriteLine(cards[card] + " " + colors[color]);
                }
                Console.WriteLine();
            }
        }
    }
}
