using System;
using System.Linq;

namespace Rounding_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numbers=Console.ReadLine()
                .Split(' ')
                .Select(float.Parse)
                .ToArray();
            for (int i = 0; i <= numbers.Length-1; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }
                
              
        }
    }
}
