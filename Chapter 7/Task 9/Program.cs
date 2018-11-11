using System;

namespace SubsequenceWithMaxSum
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

            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum += arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                else if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
