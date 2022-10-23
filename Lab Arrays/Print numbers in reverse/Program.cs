using System;

namespace Print_numbers_in_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers=new int[n];
            for (int i = 0; i <= n-1; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;

            }
            for (int i=numbers.Length-1;i>=0;i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
