using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            List<int> secondDeck = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (firstDeck.Count > 0 || secondDeck.Count > 0)
            {
               // for (int i = 0; i < firstDeck.Count*2; i++)
                //{
                   int countFirst = firstDeck.Count;
                    int countSecond = secondDeck.Count;
                
                   if (firstDeck[0] > secondDeck[0])
                    {
                        firstDeck.Add(firstDeck[0]);
                        firstDeck.Add(secondDeck[0]);
                        firstDeck.Remove(firstDeck[0]);
                        secondDeck.Remove(secondDeck[0]);
                     //  i--;
                       countFirst++;
                       countSecond--;
                       if (countSecond>0)
                       { continue; }
                       else
                       { break; }
                    }
                    else if (secondDeck[0] > firstDeck[0])
                    {
                        secondDeck.Add(secondDeck[0]);
                        secondDeck.Add(firstDeck[0]);
                        firstDeck.Remove(firstDeck[0]);
                        secondDeck.Remove(secondDeck[0]);
                       // i--;
                        countFirst--;
                        countSecond++;
                       if (countFirst > 0)
                        { continue; }
                        else
                       { break; }
                    }
                    else if (firstDeck[0] == secondDeck[0])
                    {
                        firstDeck.Remove(firstDeck[0]);
                        secondDeck.Remove(secondDeck[0]);
                      //  i--;
                        countFirst--;
                        countSecond--;
                        if (countSecond > 0&&countFirst>0)
                        { continue; }
                        else
                        { break; }
                    }
                }
            
            if (firstDeck.Count <secondDeck.Count)
            { Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}"); }
            else if (secondDeck.Count <firstDeck.Count)
            { Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}"); }
               
        }
    }
}
