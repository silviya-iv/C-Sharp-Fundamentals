using System;

namespace charecters_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
          
            char secondChar = char.Parse(Console.ReadLine());
            
            Console.Write(String.Join(" ",RangeOfChars(firstChar, secondChar)));
            
       

        }
        static char[] RangeOfChars(char firstChar, char secondChar)
        {

            int num1 = (int)(firstChar);
            int num2 = (int)(secondChar);
            char[] result = null;
            if (num1 > num2)
            { int[] ints = new int[(num1 - num2)-1]; 
            for (int i=0; i<ints.Length; i++)
                { num2 += 1;
                 ints[i] = num2;
                }
                result = new char[ints.Length];
                for (int i = 0; i < ints.Length ; i++)
                { result[i] = (char)ints[i]; }
            }
            else if (num1 < num2)
            { int[] ints = new int[(num2 - num1)-1];
                for (int i = 0; i < ints.Length; i++)
                {
                    num1 += 1;
                    ints[i] = num1;
                }
                result = new char[ints.Length];
                for (int i = 0; i < ints.Length; i++)
                { result[i] = (char)ints[i]; }
            }



            return result ;
        }
    }
}
