using System;
using System.Linq;
using System.Collections.Generic;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons=Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int singleWagonCapacity = int.Parse(Console.ReadLine());
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (commArg.Length==2)
                { wagons.Add(int.Parse(commArg[1])); }
            else if (commArg.Length==1)
                {
                    int passengers = int.Parse(commArg[0]);
                    for (int i =0; i<wagons.Count; i++)
                    {
                        if (wagons[i]+passengers<=singleWagonCapacity)
                        { wagons[i] += passengers;
                            break;
                        }
                    }    
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
