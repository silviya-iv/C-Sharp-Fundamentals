using System;

namespace Middle_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
                MiddleIndex(arr);
        }
        static void MiddleIndex(char[] chars)
        {
            int middleIndex = 0;
            if (chars.Length%2!=0)
            {
                middleIndex = chars.Length / 2;
                Console.WriteLine(chars[middleIndex]);
            }
            else
            { middleIndex=chars.Length / 2;
                Console.WriteLine($"{chars[middleIndex-1]}{(chars[middleIndex])}");

            }

        }
    }
}
