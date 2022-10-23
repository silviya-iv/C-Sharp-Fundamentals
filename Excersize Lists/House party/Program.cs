using System;
using System.Collections.Generic;

namespace House_party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> listOfGuests = new List<string>();
            for (int i=0; i<numberOfCommands;i++)
            {
               
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commands.Length==3)
                {
                    if (listOfGuests.Contains(commands[0]))
                    { Console.WriteLine($"{commands[0]} is already in the list!"); }
                    else
                    {
                        listOfGuests.Add(commands[0]);
                    }
                }
                else if(commands.Length==4)
                {
                    if (listOfGuests.Contains(commands[0]))
                    { listOfGuests.Remove(commands[0]); }    
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(String.Join((Environment.NewLine),listOfGuests));
        }
    }
}
