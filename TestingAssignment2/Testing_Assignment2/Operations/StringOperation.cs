using System;
using System.Globalization;

namespace Operations
{
    public static class StringOperation
    {
        public static string ConvertLowerCase(this string str)
        {
            if (str.Length > 0)
            {
                return str.ToLower();
            }
            return str;
        }
        public static string ConvertUpperCase(this string str)
        {
            if (str.Length > 0)
            {
                return str.ToUpper();
            }
            return str;
        }
        public static string ConvertTitleCase(this string str)
        {
            if (str.Length > 0)
            {
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                str = myTI.ToTitleCase(str);
                return new String(str);
            }
            return str;
        }

        public static bool AllCharLowerCase(this string str)
        {
            string String = str;
            char[] chars;
            char ch;
            int length = String.Length;
            int i;
            int LowerCase = 0;

            chars = String.ToCharArray(0, length);
            for (i = 0; i < length; i++)
            {
                ch = chars[i];
                if (char.IsLower(ch))
                {
                    LowerCase++;
                }
            }
            if (LowerCase == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ConvertCharFirstUpperCase(this String str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {

                if (i == 0 && ch[i] != ' ' ||
                    ch[i] != ' ' && ch[i - 1] == ' ')
                {

                    if (ch[i] >= 'a' && ch[i] <= 'z')
                    {
                        ch[i] = (char)(ch[i] - 'a' + 'A');
                    }
                }

                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                    ch[i] = (char)(ch[i] + 'a' - 'A');
            }
            String st = new String(ch);

            return str;
        }
        public static bool AllCharUpperCase(this string str)
        {
            string String = str;
            char[] chars;
            char ch;
            int length = String.Length;
            int i;
            int UpperCase = 0;

            chars = String.ToCharArray(0, length);
            for (i = 0; i < length; i++)
            {
                ch = chars[i];
                if (char.IsUpper(ch))
                {
                    UpperCase++;
                }
            }
            if (UpperCase == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidNumValue(this string str)
        {
            int no = 0;
            return int.TryParse(str, out no);
        }

        public static string RemoveLastChar(this string str)
        {
            return str.Remove(str.Length - 1, 1);
        }

        public static int WordCount(this string str)
        {
            int wc = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && Char.IsLetter(str[i + 1]) && (i > 0))
                {
                    wc++;
                }
            }
            wc++;
            return wc;
        }

        public static int ConvaertStrToInt(this string str)
        {
            int s = Int32.Parse(str);
            return s;
        }
    }
}
