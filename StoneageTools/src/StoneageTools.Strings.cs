using System;
using System.Globalization;

namespace StoneageTools.Strings
{
    public static class StoneageToolsStrings
    {
        public static string Left(this string input, int numberOfChars)
        {
            string ret = string.Empty;
            if (!string.IsNullOrWhiteSpace(input) && numberOfChars <= input.Length)
            {
                ret = input[..numberOfChars];
            }
            return ret;
        }
        public static string Right(this string input, int numberOfChars)
        {
            string ret = string.Empty;
            if (!string.IsNullOrWhiteSpace(input) && numberOfChars <= input.Length)
            {
                // ret = input.Substring(input.Length - numberOfChars);
                ret = input[^numberOfChars..];
            }
            return ret;
        }
        public static string Mid(this string input, int startAbsolutNumber, int numberOfChars)
        {
            string ret = string.Empty;
            if (!string.IsNullOrWhiteSpace(input) && (startAbsolutNumber + numberOfChars) <= input.Length && startAbsolutNumber > 0)
            {
                ret = input.Substring(startAbsolutNumber - 1, System.Math.Min(numberOfChars, input.Length));
            }
            return ret;
        }
        public static string Mid(this string input, int startIndex)
        {
            string ret = string.Empty;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (startIndex <= input.Length && startIndex > 0)
                {
                    ret = input[(startIndex - 1)..];
                }
            }
            return ret;
        }

        public static string FirstChar_2_Upper(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            char[] a = input.ToCharArray();
            a[0] = char.ToUpper(a[0], CultureInfo.InvariantCulture);
            return new string(a);
        }
        public static string RemoveCharacters(this string input, params char[] unwantedCharacters)
        {
            return input == null ? string.Empty : string.Join(string.Empty, input.Split(unwantedCharacters));
        }

        public static string Capitalize(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            char[] a = input.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0 || (i > 0 && a[i - 1] == ' '))
                    a[i] = char.ToUpper(a[i], CultureInfo.InvariantCulture);
            }
            return new string(a);
        }
        public static string Capitalize(this string input, char marker)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            char[] a = input.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0 || (i > 0 && a[i - 1] == marker))
                    a[i] = char.ToUpper(a[i], CultureInfo.InvariantCulture);
            }
            return new string(a);
        }

        public static string GetNameFromEMail(this string email)
        {
            const char cdeli = '@';
            const string sdeli = "@";

            if (string.IsNullOrEmpty(email))
                return string.Empty;

            if (!email.Contains(sdeli))
                return email;

            string[] parts = email.Split(cdeli);
            string firstnameAndLastname = parts[0].Replace(".", " ");
            return firstnameAndLastname.Capitalize();
        }

        public static bool IsFalse(string value)
        {
            return !IsTrue(value);
        }

        public static bool IsTrue(string value)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(value))
            {
                value = value.Trim().ToLower();
                if (value == "true" || value == "t" || value == "1" || value == "yes"  || value == "y" || value == "ja" || value == "j")
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool IsSameOrInstr(this string Test, string inTest)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(Test) && !string.IsNullOrEmpty(inTest))
            {
                Test = Test.Trim().ToLower();
                inTest = inTest.Trim().ToLower();
                result = Test == inTest || Test.Contains(inTest);
            }
            return result;
        }
    }
}
