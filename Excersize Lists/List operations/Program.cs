using System;
using System.Linq;
using System.Collections.Generic;

namespace List_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] commArg = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commArg[0] == "Add")
                {
                    numbers.Add(int.Parse(commArg[1]));
                }
                else if (commArg[0] == "Insert")
                {
                    if (int.Parse(commArg[2]) < 0 || int.Parse(commArg[2]) >= numbers.Count)
                    { Console.WriteLine("Invalid index"); }
                    else
                    {
                        int value = int.Parse(commArg[1]);
                        int index = int.Parse(commArg[2]);
                        numbers.Insert(index, value);
                    }
                }
                else if (commArg[0] == "Remove")
                    if (int.Parse(commArg[1]) < 0 || int.Parse(commArg[1]) >= numbers.Count)
                    { Console.WriteLine("Invalid index"); }
                    else
                    {


                        numbers.RemoveAt(int.Parse(commArg[1]));
                    }
               else if (commArg[0]=="Shift")
                { 
                 if (commArg[1] == "left")
                {
                    int count = int.Parse(commArg[2]);
                        for (int i=0; i<count;i++)
                        {
                            int firstNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);
                        }
                   }
                else if (commArg[1] == "right")
                   {
                    int count = int.Parse(commArg[2]);
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count-1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0,lastNum);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
