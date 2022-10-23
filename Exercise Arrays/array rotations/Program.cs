using System;
using System.Linq;

namespace array_rotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
            int rotations=int.Parse(Console.ReadLine());
            int currNum = 0;
            if (arr.Length == rotations)
            {
                Console.WriteLine(String.Join(" ", arr));

            }
            else
            {
                for (int j = 0; j < rotations; j++)
                {
                    currNum = arr[0];
                    for (int i = 0; i < arr.Length-1; i++)
                    {

                        arr[i] = arr[i + 1];

                    }
                    arr[arr.Length - 1] = currNum;
                }
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
