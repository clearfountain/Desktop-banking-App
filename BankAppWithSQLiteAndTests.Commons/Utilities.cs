using System;
using System.Text;
using System.Text.RegularExpressions;

namespace BankAppWithSQLiteAndTests.Commons
{
    public class Utilities
    {
        //Capitalize first character of string 
        public static string FirstCharacterToUpper(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                var firstCharacterArray = str.Substring(0, 1).ToCharArray();
                var firstCharacterUnicode = (int)firstCharacterArray[0];
                if ((firstCharacterUnicode >= 97) && (firstCharacterUnicode < 122))
                {
                    var firstCharCaps = firstCharacterUnicode - 32;
                    str = Convert.ToChar(firstCharCaps) + str.Substring(1);
                }
            }

            return str;
        }

        //Check if email string is in valid email format
        public static bool IsValidEmail(string email)
        {
            bool isValid = false;

            try
            {
                isValid = Regex.IsMatch(email, @"^[^@\s]+@[^\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool IsValidDecimal(string input)
        {
            decimal temp;
            bool isDecimal = decimal.TryParse(input, out temp);
            return isDecimal;
        }

        //Check if input is valid integer
        public static bool IsValidInt(string input)
        {
            int temp;
            bool isDecimal = int.TryParse(input, out temp);
            return isDecimal;
        }
    }
}
