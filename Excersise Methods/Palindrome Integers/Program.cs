using System;

namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
           
            int input = int.Parse(command);
          
            int[] numArr=IntToIntArr(input);
           
            bool palindrome = false;
           while (command!="End")
            {
                if (numArr.Length == 1)
                { palindrome = true;
                    Console.WriteLine(palindrome);

                    command = Console.ReadLine();

                    input = int.Parse(command);
                    numArr = IntToIntArr(input);
                }
                else
                {
                    for (int i = 1; i <= numArr.Length / 2; i++)
                    {

                        if (numArr[i - 1] == numArr[numArr.Length - i])
                        {
                            palindrome = true;
                        }
                    }

                    Console.WriteLine(palindrome);

                    command = Console.ReadLine();

                    input = int.Parse(command);
                    numArr = IntToIntArr(input);
                }
            }
        }

        static  int[] IntToIntArr(int input)
        {
            string inputStr = input.ToString();
            int[] arrNum = new int[inputStr.Length];
            
            while (input > 0)
            {
                for (int i = arrNum.Length - 1; i >= 0; i--)
                {
                    arrNum[i] = input % 10;
                    input = input / 10;
                }
            }
                return arrNum;
            
        }
    }
}
