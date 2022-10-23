using System;

namespace Password_validatior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            char[] passwordArray = password.ToCharArray();

            if (PasswordLength(passwordArray) ==false)
            { Console.WriteLine("Password must be between 6 and 10 characters"); }    
            if (IsAlphaNumeric(passwordArray)==false)
            { Console.WriteLine("Password must consist only of letters and digits"); }
            if (VerifyForTwoDigits(passwordArray)==false)
            { Console.WriteLine("Password must have at least 2 digits"); }
            if (PasswordLength(passwordArray) == true&& IsAlphaNumeric(passwordArray) ==true&& VerifyForTwoDigits(passwordArray) ==true)
            { Console.WriteLine("Password is valid"); }
        
        }
        static bool PasswordLength(char[] chars)
        {
            bool correctPasswordLength=false;
            if (chars.Length>=6&&chars.Length<=10)
            { correctPasswordLength = true; }
            return correctPasswordLength;
        }
        static bool IsAlphaNumeric(char[] chars)
        {
            bool IsAlphaNumeric = true;
            for (int i= 0; i<chars.Length; i++ )
            {

                if (char.IsLetterOrDigit(chars[i]))
                { continue; }
                else
                { IsAlphaNumeric=false;
                    break;
                }    
                }
            return IsAlphaNumeric;
        }
        static bool VerifyForTwoDigits(char[] chars)
        {
            bool twoDigits = false;
            int counter = 0;
            for (int i = 0; i < chars.Length; i++)
            {

                if (char.IsDigit(chars[i]))
                { counter++; }
               
            }
            if (counter>=2)
            { twoDigits = true; }
            return twoDigits;
        }
    }
}
