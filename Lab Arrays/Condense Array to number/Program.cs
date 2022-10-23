using System;
using System.Linq;

namespace Condense_Array_to_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
              .Split(" ",StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int[] condensed;

            while (arr1.Length>1 )
            {
                condensed = new int[arr1.Length - 1];
                for (int i = 0; i < arr1.Length-1; i++)
                {

                    condensed[i] = arr1[i] + arr1[i + 1];

                }
                
                arr1 = condensed;
                
            }
            Console.WriteLine(arr1[0]);
        }
    }
}
