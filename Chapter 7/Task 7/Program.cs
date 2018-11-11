using System;

namespace MacSumOfSequentialElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string input = Console.ReadLine();
            string[] transformedInput = input.Split(' ');
            for (int i = 0; i < transformedInput.Length; i++)
            {
                arr[i] = int.Parse(transformedInput[i]);
            }

            //get max array
            int currentSum = 0;
            int maxIndex = 0;
            int maxSum = 0;
            int maxArrayElementsCount = 1;
            for (int i = 0; i <= n - k; i++)
            {
                int j = i;
                for (; j < i + k; j++)
                {
                    currentSum += arr[j];
                }

                if (currentSum > maxSum)
                {
                    maxIndex = i;
                    maxSum = currentSum;
                    maxArrayElementsCount = j - i;
                }
                currentSum = 0;
            }

            for (int i = maxIndex; i < maxIndex + maxArrayElementsCount; i++)
            {
                if (i != maxIndex + maxArrayElementsCount - 1)
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
        }
    }
}
