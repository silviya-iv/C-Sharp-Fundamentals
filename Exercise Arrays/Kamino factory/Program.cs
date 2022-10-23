using System;
using System.Linq;

namespace Kamino_factory
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int startingIndex = 0;
            int minStartingIndex = 0;
            int subsequenceLength = 1;
            int maxSubsequenceLength = 0;
            int arrCounter = 0;
            int maxArrayCounter = 0;
            int sumOfElements = 0;
            int maxSumOfElements = 0;
            int[] arr = new int[n];
           
            while (command!= "Clone them!")
            {
                int[] currentArr = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
               
                startingIndex = 0;
                sumOfElements = 0;
                subsequenceLength = 1;
                arrCounter++;
                for (int k = 0; k < currentArr.Length; k++)
                {
                    sumOfElements += currentArr[k];
                }

                for (int i = 0; i < currentArr.Length - 1; i++)
                {

                    if (currentArr[i] == 1 && currentArr[i] == currentArr[i + 1])
                    {
                        if (subsequenceLength == 1)
                        { startingIndex = i; }
                        subsequenceLength++;

                    }
                }

                    if (subsequenceLength > maxSubsequenceLength)
                    {
                        maxSubsequenceLength = subsequenceLength;
                        maxArrayCounter = arrCounter;
                        maxSumOfElements = sumOfElements;
                      //  startingIndex = i;
                        minStartingIndex =startingIndex;
                        arr = currentArr;

                    }
                   else if (subsequenceLength == maxSubsequenceLength)
                    {
                    // startingIndex = i;

                    if (startingIndex < minStartingIndex)
                    {
                        minStartingIndex = startingIndex;
                        maxSumOfElements = sumOfElements;
                        // maxSubsequenceLength = subsequenceLength;
                        maxArrayCounter = arrCounter;
                        arr = currentArr;
                    }

                    else if (startingIndex == minStartingIndex)
                    { if (sumOfElements > maxSumOfElements)

                        {
                            //minStartingIndex = startingIndex;
                            maxSumOfElements = sumOfElements;
                            //    maxSubsequenceLength = subsequenceLength;
                            maxArrayCounter = arrCounter;
                            arr = currentArr;
                        }  
                        }
                    }

                sumOfElements = 0;

                startingIndex = 0;

                subsequenceLength = 1;

                command = Console.ReadLine();



            }
            Console.WriteLine($"Best DNA sample {maxArrayCounter} with sum: {maxSubsequenceLength}.");
            Console.WriteLine(String.Join(" ", arr));


        }
    }
}
