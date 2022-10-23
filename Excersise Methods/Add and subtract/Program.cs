using System;

namespace Add_and_subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            long finalResult = SubtractIntegers(SumIntegers(num1, num2), num3);
            Console.WriteLine(finalResult);
        }
        static long SumIntegers(int int1, int int2)
        {
            long sum = 0;
            sum = (long)(int1 + int2);
            return sum;
        }
        static long SubtractIntegers(long sum, int int3)
        {
           
            long result = 0;
            result = (long)(sum - int3);
            return result;
        }

    }
}
