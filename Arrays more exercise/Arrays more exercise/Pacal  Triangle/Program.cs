using System;

namespace Pacal__Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[1];
            firstArray[0] = 1;

            long[] secondArray = new long[2];
            secondArray[0] = 1;
            secondArray[1] = 1;
            if (n==1)
            { Console.WriteLine(string.Join(" ", firstArray)); }
            if (n > 1 && n < 3)
            { Console.WriteLine(string.Join(" ", secondArray)); }
            else if (n >= 3)
            {
                Console.WriteLine(string.Join(" ", firstArray));
                Console.WriteLine(string.Join(" ", secondArray));
                for (int i = 3; i <= n; i++)
                {

                    long[] nextArr = new long[i];
                    for (int j = 1; j < nextArr.Length - 1; j++)
                    {
                        nextArr[0] = 1;
                        nextArr[j] = secondArray[j - 1] + secondArray[j];
                        nextArr[nextArr.Length - 1] = 1;
                    }
                    Console.WriteLine(String.Join(" ", nextArr));
                    secondArray = nextArr;
                }
            }
        }
    }
}
