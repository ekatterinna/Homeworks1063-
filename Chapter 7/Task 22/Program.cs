using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubsequenceOgIncreasingNumbers
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

            int[] result = LongestIncSubsequence(arr);

            Console.Write("{");
            foreach (int num in result)
            {
                Console.Write(" {0}", num);
            }
            Console.WriteLine(" }");

        }

        static int[] LongestIncSubsequence(int[] array)
        {
            int[] increasingLengths = new int[array.Length];
            increasingLengths[0] = 1;
            for (int i = 1; i < increasingLengths.Length; i++)
            {
                int maxLength = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] <= array[i] && increasingLengths[j] > maxLength)
                    {
                        maxLength = increasingLengths[j];
                    }
                }
                increasingLengths[i] = maxLength + 1;
            }

            int[] sortedSubset = new int[increasingLengths.Max()];
            int serialNumber = increasingLengths.Max();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (serialNumber == increasingLengths[i])
                {
                    sortedSubset[serialNumber - 1] = array[i];
                    serialNumber--;
                }
            }

            return sortedSubset;
        }
    }
}

