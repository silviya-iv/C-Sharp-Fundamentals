using System;
using System.Linq;

namespace magic_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int magicNum1 = 0;
            int magicNum2 = 0;
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)

                    for (int j=i+1; j<arr.Length; j++)
                if (arr[i] + arr[j]==num)
                    {
                        magicNum1 = arr[i];
                        magicNum2 = arr[j];
                        Console.WriteLine(magicNum1+" " +magicNum2); }

        }
    }
}
