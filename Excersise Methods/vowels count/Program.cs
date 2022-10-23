using System;

namespace vowels_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] chars = input.ToCharArray();
            Console.WriteLine(VowelsCount(chars));
        }
        static int VowelsCount(char[] chars)
        {
           int counter = 0;
            foreach(char c in chars)
            {
                if (c =='a'|| c == 'o' || c == 'u' || c == 'e' || c == 'i' ) 
                { counter++; } 
                    
            }

            return counter;
        }
    }
}
