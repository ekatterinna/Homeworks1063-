using System;

class Concatenation
{
    static void Main(string[] args)
    {
        string firstWord = "";
        string secondWord = "";
        object concatenation = null;

        firstWord = Console.ReadLine();
        secondWord = Console.ReadLine();

        if (firstWord.Trim().Length == 0)
        {
            concatenation = secondWord;
        }
        else
        {
            concatenation = String.Format("{0} {1}", firstWord.Trim(), secondWord.Trim());
        }

        Console.WriteLine(concatenation);
    }
}

