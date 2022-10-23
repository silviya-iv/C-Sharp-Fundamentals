using System;

namespace NxN_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            Matrix(num);
        }
        static void Matrix(int int1)
        {
            for (int i=1; i<=int1;i++)
            {
                for (int j = 1; j <= int1; j++)
                { Console.Write(int1+" "); }
                Console.WriteLine();
            }
            

        }
    }
}
