using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_QuotedString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder escapedQuotes = new StringBuilder();
            StringBuilder escapedQuotesAsQuotedString = new StringBuilder();
            escapedQuotesAsQuotedString.Append("@\"");
            char key = ' ';
            while (key != '.')
            {
                key = (char)Console.Read();
                if (key == '\\' || key == '\"' || key == '\'')
                {
                    escapedQuotes.Append("\\");
                    escapedQuotes.Append(key);
                    if (key == '\"')
                    {
                        escapedQuotesAsQuotedString.Append("\"");
                        // escapedQuotesAsQuotedString.Append(key);
                    }
                    if (key == '\'')
                    {
                        escapedQuotesAsQuotedString.Append("\'");
                        // escapedQuotesAsQuotedString.Append(key);
                    }
                }
                else if (key == (char)ConsoleKey.Tab)
                {
                    escapedQuotes.Append("\\t");
                    escapedQuotesAsQuotedString.Append("\\t");
                }
                else if (key == (char)ConsoleKey.Enter)
                {
                    escapedQuotes.Append(@"\n");
                    escapedQuotesAsQuotedString.Append(@"\n");
                }
                else if (key == '\n')
                {
                    continue;
                }
                else
                {
                    escapedQuotes.Append(key);
                    escapedQuotesAsQuotedString.Append(key);
                }
            }
            escapedQuotesAsQuotedString.Append("\"");
            Console.WriteLine(escapedQuotes);
            Console.WriteLine(escapedQuotesAsQuotedString);
        }
    }
}
