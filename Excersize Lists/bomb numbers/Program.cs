using System;
using System.Collections.Generic;
using System.Linq;

namespace bomb_numbers
{
    internal class Program
    {
        static void Main(string[] args)
         {
           List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bombNumber= Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int power = bombNumber[1];
            int bomb=bombNumber[0];
            int index = 0;
            while (numbers.Contains(bomb))
          //  for (int i = 0; i < numbers.Count; i++)
            {
                int startingIndex = 0;
                int count = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                  if (numbers[i] == bombNumber[0])
                    {
                        index = i;
                        break;
                    }
                }
                     startingIndex = index - power;
                     count = power * 2 + 1;
                    if (power>index)
                    { startingIndex = 0; }
               if (power > numbers.Count - (index + 1)|| count > numbers.Count - 1) 
                    
                    {
                        count = numbers.Count - startingIndex ;
                    }
                
                numbers.RemoveRange(startingIndex, count);

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
