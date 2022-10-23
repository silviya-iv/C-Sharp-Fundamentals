using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> appendList = new List<int>();   
                
            for (int i=input.Count-1; i >=0; i--)
            {
                List<int> currList = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                for (int j = 0; j < currList.Count; j++)
                {
                    appendList.Add(currList[j]);
                }

            }
            Console.WriteLine(String.Join(" ", appendList));
        }
    }
}
