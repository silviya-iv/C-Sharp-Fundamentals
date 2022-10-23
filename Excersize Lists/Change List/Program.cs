using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commArg[0] == "Delete")
                { 
                    int value = int.Parse(commArg[1]);
                    while(numbers.Contains(value))
                    { numbers.Remove(value); }
                }
                else if (commArg[0]=="Insert")
                {
                    int element = int.Parse(commArg[1]);
                    int index = int.Parse(commArg[2]);
                    numbers.Insert(index, element);

                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
