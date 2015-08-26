namespace Problem_1.StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class Substrings
    {
        public static StringBuilder Susbtring(this StringBuilder text, int index, int length = 0) //length is set to zero by default
        {
            if (index < 0 && index >= text.Length)
            {
                throw new IndexOutOfRangeException("Index must be in the range of [0, Text length)");
            }

            StringBuilder substring = new StringBuilder();

            if (length == 0) //if length is 0(by default), the substring will append all the remaining string after text[index]
            {
                for (int i = index; i < text.Length; i++)
                {
                    substring.Append(text[i]);
                }
            }
            else if (length != 0) //if length is different from 0, the substring will append string with this length, after text[index]
            {
                for (int i = index; i < index + length; i++)
                {
                    substring.Append(text[i]);
                } 
            }            

            return substring;
        }
    }
}