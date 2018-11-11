using System;

namespace IndexMultipliedByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("element {0} = {1}", i + 1, arr[i]);
            }
        }
    }
}


