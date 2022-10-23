using System;

namespace Days_of_week
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());
            
            string[] weekDays = new string[7];
            weekDays[0] = "Monday";
            weekDays[1] = "Tuesday";
            weekDays[2] = "Wednesday";
            weekDays[3] = "Thursday";
            weekDays[4] = "Friday";
            weekDays[5] = "Saturday";
            weekDays[6] = "Sunday";
            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(weekDays[n - 1]);
            }
            else
            { Console.WriteLine("Invalid day!"); }


        }
    }
}
