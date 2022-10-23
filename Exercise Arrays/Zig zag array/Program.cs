using System;
using System.Linq;

namespace Zig_zag_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n=int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] currNum;
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < n; i++)
            {
                currNum = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

                if (i%2==0)
                {
                   
                    arr1[i] = currNum[0];
                    arr2[i] = currNum[1];
                }
                else
                {
                    arr1[i] = currNum[1];
                    arr2[i] = currNum[0];
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
