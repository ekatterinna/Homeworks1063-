using System;

namespace ArraysComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputArrayOne = Console.ReadLine();
            string inputArrayTwo = Console.ReadLine();
            //Transforming the input
            string[] inputOne = inputArrayOne.Split(' ');
            string[] inputTwo = inputArrayTwo.Split(' ');

            int[] arr1 = new int[inputOne.Length];
            for (int i = 0; i < inputOne.Length; i++)
            {
                arr1[i] = int.Parse(inputOne[i]);
            }
            int[] arr2 = new int[inputTwo.Length];
            for (int i = 0; i < inputTwo.Length; i++)
            {
                arr2[i] = int.Parse(inputTwo[i]);
            }

            int counterOfEqualElements = 0;
            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("False");
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        counterOfEqualElements++;
                    }
                }
                if (counterOfEqualElements == arr1.Length)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }

        }
    }
}


