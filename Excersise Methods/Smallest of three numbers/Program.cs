using System;

namespace Smallest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());   
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MinNumber(firstNumber,secondNumber,thirdNumber));
        }
        static int MinNumber(int num1, int num2, int num3)
        {
            int minNumber = int.MaxValue;
            if (num1<minNumber)
            {
                minNumber = num1;
            }
            if (num2 < minNumber) 
            { minNumber=num2;}
            if(num3<minNumber)
            { minNumber = num3; }
            return minNumber;
        }
    }
}
