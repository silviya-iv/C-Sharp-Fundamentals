using System;

namespace Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           int n=int.Parse(Console.ReadLine());
           
            long[] result= new long[n];
            
            long sumOfvowels = 0;
            int consonantSum = 0;
            long stringSum = 0;
            
            for(int i=0; i<n; i++)
            {

                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length==0)
                {
                     input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
                string currStr = string.Empty;
                foreach(string item in input)
                { currStr += item; }
               // currStr = currStr.ToLower();
                char[] str = new char[input.Length];
                str=currStr.ToCharArray();
               
               
                stringSum = 0;
                consonantSum = 0;
                sumOfvowels = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    int curLetter = 0;
                    if (str[j] == 'a' || str[j] == 'e' || str[j] == 'o' || str[j] == 'u' || str[j] == 'i' || str[j] == 'A' || str[j] == 'E' || str[j] == 'O' || str[j] == 'U' || str[j] == 'I')
                    { curLetter = str[j] * str.Length;
                        sumOfvowels += curLetter;
                    }
                  
                   else 
                    {
                        curLetter = str[j] / str.Length;
                        consonantSum+=curLetter;
                    }


                }
                stringSum = sumOfvowels + consonantSum;
               
                    result[i]=stringSum;
                
            }
            Array.Sort(result);
            for (int i=0; i<result.Length;i++)
                Console.WriteLine(result[i]);

        }
    }
}
