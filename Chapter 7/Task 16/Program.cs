﻿using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArrayOne = Console.ReadLine();
            char[] delimiter = new char[] { ',', ' ' };
            string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            int[] arr = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                arr[i] = int.Parse(inputOne[i]);
            }
            Array.Sort(arr);
            int numberToFind = int.Parse(Console.ReadLine());

            BinarySearchInArray(numberToFind, arr);

        }

        static void BinarySearchInArray(int numberToFind, int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            int currentIndex = 0;

            currentIndex = (startIndex + endIndex) / 2;
            do
            {

                if (array[currentIndex] == numberToFind)
                {
                    Console.WriteLine("{0}", currentIndex);
                    return;
                }
                else if (array[currentIndex] > numberToFind)
                {
                    endIndex = currentIndex;
                    currentIndex = (startIndex + endIndex - 1) / 2;
                }
                else
                {
                    startIndex = currentIndex;
                    currentIndex = (startIndex + endIndex + 1) / 2;
                }

            } while (startIndex != endIndex);

            Console.WriteLine("Not found");
        }
    }
}

