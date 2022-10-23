using System;
using System.Linq;

namespace Max_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int sequenceCount = 0;
            int maxSequence = int.MinValue;
            int index=0;
            for (int i=0; i<arr.Length; i++)
            {
                sequenceCount = 0;
                for (int j=i+1; j<arr.Length; j++)
                    if (arr[i] == arr[j])
                    {
                        sequenceCount++;
                    }
                else
                    { break; }
                if (sequenceCount>maxSequence)
                {
                    maxSequence = sequenceCount;
                    index = i;
                }
            }
            for (int k=0;k<=maxSequence; k++)
            Console.Write(arr[index]+" ");



        }
    }
}
