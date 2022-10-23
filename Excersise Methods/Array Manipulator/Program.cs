using System;
using System.Linq;

namespace Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
         {
            int[] n = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            string command = string.Empty;


            while ((command = Console.ReadLine()) != "end")
            {
                string[] commArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commArg[0] == "exchange")
                {
                    n = ExchangeArray(n, commArg);
                }
                else if (commArg[0] == "max")
                {
                    if (commArg[1] == "odd")
                    {
                        MaxOdd(n);
                    }
                    else if (commArg[1] == "even")
                        MaxEven(n);
                }
                else if (commArg[0] == "min")
                {
                    if (commArg[1] == "odd")
                    {
                        MinOdd(n);
                    }
                    else if (commArg[1] == "even")
                    {
                        MinEven(n);
                    }
                }
                else if (commArg[0] == "first")
                {
                    if (commArg[2] == "odd")
                    {
                        FirstOddNums(n, commArg);
                    }

                    else if (commArg[2] == "even")
                    {
                        FirstEvenNums(n, commArg);
                    }
                }

                else if (commArg[0] == "last")
                {
                    if (commArg[2] == "odd")
                    {
                        LastOddNums(n, commArg);
                    }
                    else if (commArg[2] == "even")
                    {
                        LastEvenNums(n, commArg);
                    }
                }

            }
            if (command=="end")
            { Console.WriteLine($"[{String.Join(", ", n)}]"); }
        }

        private static void LastOddNums(int[] n, string[] commArg)
        {
            int count = int.Parse(commArg[1]);
            int currCount = 0;
            int[] oddNum = new int[n.Length];
            bool odd = false;
            if (count <= 0 || count > n.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                // while (currCount < count)
                // {

                for (int i = n.Length - 1; i >= 0; i--)
                {
                    if (n[i] % 2 != 0)
                    {
                        odd = true;
                        currCount++;
                        oddNum[i] = n[i];
                        if (currCount >= count)
                        { break; }
                    }
                }

                if (odd == false)
                { Console.WriteLine("[]"); }
                else if (odd == true)
                {
                    Console.WriteLine($"[{string.Join(", ", oddNum.Where(x => x != 0))}]");
                }
            }
        }

        private static void FirstEvenNums(int[] n, string[] commArg)
        {
            int count = int.Parse(commArg[1]);
            int currCount = 0;
            int[] evenNum = new int[n.Length];
            bool even = false;
            if (count <= 0 || count > n.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                // while (currCount < count)
                // {

                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] % 2 == 0)
                    {
                        even = true;
                        currCount++;
                        evenNum[i] = n[i];
                        if (currCount >= count)
                        { break; }
                    }
                }

                if (even == false)
                { Console.WriteLine("[]"); }
                else if (even == true)
                {
                    Console.WriteLine($"[{string.Join(", ", evenNum.Where(x => x != 0))}]");
                }
            }
            
        }

        private static void FirstOddNums(int[] n, string[] commArg)
        {
            int count = int.Parse(commArg[1]);
            int currCount = 0;
            int[] oddNum = new int[n.Length];
            bool odd = false;
            if (count <= 0 || count > n.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                // while (currCount < count)
                // {

                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] % 2 != 0)
                    {
                        odd = true;
                        currCount++;
                        oddNum[i] = n[i];
                        if (currCount >= count)
                        { break; }
                    }
                }

                if (odd == false)
                { Console.WriteLine("[]"); }
                else if (odd == true)
                {
                    Console.WriteLine($"[{string.Join(", ", oddNum.Where(x => x != 0))}]");
                }
               
            }
        }


        private static void MinEven(int[] n)
        {
            bool evenNum = false;
            int minNumber = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    evenNum = true;
                    if (n[i] <= minNumber)
                    {
                        minNumber = n[i];
                        minIndex = i;
                    }
                }
            }
            if (evenNum == false)
            { Console.WriteLine("No matches"); }
            else
            { Console.WriteLine(minIndex); }
        }

        private static void MinOdd(int[] n)
        {
            bool oddNum = false;
            int minNumber = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    oddNum = true;
                    if (n[i] <= minNumber)
                    {
                        minNumber = n[i];
                        minIndex = i;
                    }
                }
            }
            if (oddNum == false)
            { Console.WriteLine("No matches"); }
            else
            { Console.WriteLine(minIndex); }
        }

        private static void MaxEven(int[] n)
        {
            bool evenNum = false;
            int maxNumber = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    evenNum = true;
                    if (n[i] >= maxNumber)
                    {
                        maxNumber = n[i];
                        maxIndex = i;
                    }
                }
            }
            if (evenNum == false)
            { Console.WriteLine("No matches"); }
            else
            { Console.WriteLine(maxIndex); }
        }

        private static void MaxOdd(int[] n)
        {
            bool oddNum = false;
            int maxNumber = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    oddNum = true;
                    if (n[i] >= maxNumber)
                    {
                        maxNumber = n[i];
                        maxIndex = i;
                    }
                }
            }
            if (oddNum == false)
            { Console.WriteLine("No matches"); }
            else
            { Console.WriteLine(maxIndex); }
        }

        private static int[] ExchangeArray(int[] n, string[] commArg)
        {
            int index = int.Parse(commArg[1]);
            if (index < 0 || index > n.Length - 1)
            { Console.WriteLine("Invalid index");
                
            }
            else
            {
                int[] front = new int[index + 1];
                int[] back = new int[n.Length - (index + 1)];
                for (int i = 0; i < index + 1; i++)
                { front[i] = n[i]; }
                Array.Reverse(n);
                for (int j = 0; j <= n.Length - (index + 2); j++)
                { back[j] = n[j]; }
                Array.Reverse(back);
                n = back.Concat(front).ToArray();
            }

            return n;
        }


        private static void LastEvenNums(int[] n, string[] commArg)
        {
            int count = int.Parse(commArg[1]);
            int currCount = 0;
            int[] evenNum = new int[n.Length];
            bool even = false;
            if (count <= 0 || count > n.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                // while (currCount < count)
                // {

                for (int i = n.Length - 1; i >= 0; i--)
                {
                    if (n[i] % 2 == 0)
                    {
                        even = true;
                        currCount++;
                        evenNum[i] = n[i];
                        if (currCount >= count)
                        { break; }
                    }
                }

                if (even == false)
                { Console.WriteLine("[]"); }
                else if (even == true)
                {
                    Console.WriteLine($"[{string.Join(", ", evenNum.Where(x => x != 0))}]");
                }
            }
        }
    }
}