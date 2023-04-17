using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension_Methods.Utilities
{
    internal static class Helper
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool HasDigit(this string text)
        {
            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(this string text)
        {
            int HasDigit = 0;
            int HasBigLetter = 0;

            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    HasDigit++;
                }
                else if (char.IsDigit(item))
                {
                    HasBigLetter++;
                }

            }
            if (HasDigit > 0 && HasBigLetter > 0 && text.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string Capitalize(this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
    }
}
