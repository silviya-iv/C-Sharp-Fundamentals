using System;
using System.Linq;

namespace Equal_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool notEqual = false;
            if (arr.Length == 1)
            { Console.WriteLine(0); }
            else if (arr.Length==2)
            { Console.WriteLine("no"); }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sumLeft = 0;
                   sumRight = 0;
                    for (int j = 0; j < i; j++)
                    { sumLeft += arr[j]; }
                    for (int n = i + 1; n <= arr.Length - 1; n++)
                    {
                        sumRight += arr[n];
                    }
                    if (sumLeft ==sumRight)
                    { Console.WriteLine(i);
                        notEqual = true;
                    }
                    
                }
                if (notEqual==false)
                { Console.WriteLine("no"); }

            }
        }
    }
}
