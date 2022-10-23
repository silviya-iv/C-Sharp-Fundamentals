using System;
using System.Linq;

namespace Top_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            

            for (int i = 0; i < arr.Length; i++)
            {
                bool topInt = true;
                for (int n=i+1; n<=arr.Length-1;n++)
                {
                    if (arr[i] < arr[n])
                    { topInt = false;
                        break;
                    }
                }
                if (topInt == true)
                { Console.Write(arr[i] + " "); }
            }
        }
    }
}
