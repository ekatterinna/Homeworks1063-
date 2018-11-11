using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variations
{
    class Program
    {
        static int k, n;
        static int[] combo;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            combo = new int[k];

            GenerateCombo(0);
        }

        static void GenerateCombo(int startIndex)
        {
            if (startIndex >= k)
            {
                Print(combo);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                combo[startIndex] = i + 1;
                GenerateCombo(startIndex + 1);
            }
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}

