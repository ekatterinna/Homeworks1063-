using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NRandomNumbers
{
    class NRandomNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                int indexOne = rand.Next(n);
                int indexTwo = rand.Next(n);
                int temp = numbers[indexOne];
                numbers[indexOne] = numbers[indexTwo];
                numbers[indexTwo] = temp;
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}


