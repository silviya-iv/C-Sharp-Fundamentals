using System;
using System.Linq;

namespace Kamino_factory
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int bestIndex = int.MaxValue;
            //int bestSequence = int.MinValue;
            int bestSubsequenceCount = 0;
            int arrCount = 0;
            int arrIndex = 0;
            int[] bestDnaArr = new int[n];

            int bestSequenceSum = 0;
            int sequenceSum = 0;



            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                arrCount++;
                int index = 0;
                sequenceSum = 0;
                int subsequenceCount = 1;
                for (int k = 0; k < arr.Length; k++)
                {
                    sequenceSum += arr[k];
                }

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    //sequenceSum += arr[i];
                    //for (int j = i + 1; j < arr.Length; j++)

                    //  { 
                    if (arr[i] == 1 && arr[i] == arr[i + 1])
                    {
                        if (subsequenceCount == 1)
                        { index = 1; }
                        subsequenceCount++;
                    }
                    // else { break; }

                    //}


                    if (subsequenceCount > bestSubsequenceCount)
                    {
                        bestSubsequenceCount = subsequenceCount;
                        index = i;
                        bestIndex = index;
                        bestDnaArr = arr; ;
                        arrIndex = arrCount;
                        bestSequenceSum = sequenceSum;


                    }
                    if (subsequenceCount == bestSubsequenceCount)
                    {
                        //if && index != bestIndex
                        index = i;
                        if (index < bestIndex)
                        {
                            bestDnaArr = arr;
                            arrIndex = arrCount;
                            bestSequenceSum = sequenceSum;
                        }


                        if (index == bestIndex && sequenceSum > bestSequenceSum)
                        {
                            bestDnaArr = arr;
                            arrIndex = arrCount;
                            bestSequenceSum = sequenceSum;
                        }
                    }


                }
            }
            Console.WriteLine($"Best DNA sample {arrIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(" ", bestDnaArr));


        }
    }
}
