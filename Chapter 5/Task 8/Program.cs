using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class AdjustingIntDoubleOrString
{
    static void Main(string[] args)
    {
        //on the first input line should be a string {int,double,string} defining the type of the variable
        // on the second input line should be the variable
        // on the output line should be the result after the switch according to the rules
        //if int or double add 1        if string concatenate with "*"
        string x = Console.ReadLine();
        switch (x)
        {
            case "int":
                int i = int.Parse(Console.ReadLine());
                i = i + 1;
                Console.WriteLine(i); break;
            case "double":
                double d = double.Parse(Console.ReadLine());
                d = d + 1;
                Console.WriteLine(d); break;
            case "string":
                string s = Console.ReadLine();
                Console.WriteLine(s + "*"); break;
            default:; break;
        }
    }
}


