using System;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;
            bool containsOdd = false;
            bool topNumber = false;
            bool divisibleByEight = false;
            for (int i = 17; i <= endNum; i++)
            {
                int[] currNumArr = IntToIntArr(i);

                SumDivisibleByEight(ref sum, ref divisibleByEight, currNumArr);
                containsOdd = ContainsOdd(containsOdd, currNumArr);
                if (containsOdd == true && divisibleByEight == true)
                {
                    topNumber = true;
                    Console.WriteLine(String.Join("", currNumArr));
                }
                sum = 0;
                containsOdd = false;
                topNumber = false;
                divisibleByEight = false;




            }


        }

        private static void SumDivisibleByEight(ref int sum, ref bool divisibleByEight, int[] currNumArr)
        {
            for (int n = 0; n < currNumArr.Length; n++)
            {
                sum += currNumArr[n];

            }
            if (sum % 8 == 0)
            {
                divisibleByEight = true;
            }
        }

        private static bool ContainsOdd(bool containsOdd, int[] currNumArr)
        {
            for (int n = 0; n < currNumArr.Length; n++)
            {
                if (currNumArr[n] % 2 != 0)
                {
                    containsOdd = true;
                }
            }

            return containsOdd;
        }

        private static int[] IntToIntArr(int i)
        {
            int currNum = i;
            string num = i.ToString();
            int[] currNumArr = new int[num.Length];
            while (currNum > 0)
            {
                for (int j = num.Length - 1; j >= 0; j--)

                {
                    currNumArr[j] = currNum % 10;
                    currNum /= 10;
                }
            }

            return currNumArr;

        }
    }
}
