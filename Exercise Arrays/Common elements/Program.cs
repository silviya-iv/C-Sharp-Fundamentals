using System;

namespace Common_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        Console.Write(arr2[j]+ " ");
                    }
                }
            }
            
                
        }
    }
}
