using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfeMale
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string sex = Console.ReadLine();
            bool isFeMale = false;
            if (sex == "male")
            {
                isFeMale = true;
            }
            Console.WriteLine(name + " isFeMale? - " + isFeMale);
        }
    }
}

