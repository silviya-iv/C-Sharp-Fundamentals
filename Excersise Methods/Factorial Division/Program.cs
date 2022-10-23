using System;

namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum= double.Parse(Console.ReadLine());
            double secondNum= double.Parse(Console.ReadLine());

            double result=(double)(Factoial(firstNum)/Factoial(secondNum));
            Console.WriteLine($"{result:F2}");
        }
        static double  Factoial(double num)
        {
            double factorial = 1;
            if (num == 0 || num == 1)
            { factorial = 1; }
            else {
                for (int i = 1; i <= num; i++)
                { factorial *= i; }
            }
            return factorial;

        }
    }
}
