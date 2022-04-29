/*
Implement strStr().

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Clarification:

What should we return when needle is an empty string? This is a great question to ask during an interview.

For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().

Example 1:

Input: haystack = "hello", needle = "ll"
Output: 2
Example 2:

Input: haystack = "aaaaa", needle = "bba"
Output: -1

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
*/

namespace practice
{
    using System;
    using System.Globalization;

    public class Practice
    {
        static void Main(string[] args)
        {
            //string haystack = "hello";
            //string needle = "ll";

            string haystack = "aaaaa";
            string needle = "bba";

            StrStr(haystack, needle);
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length == 0)
            {
                return 0;
            }
            
            // Find the characters in the variable needle
            // string.IndexOf will automatically return a -1 if the character is not found
            int findNeedle = haystack.IndexOf(needle);
        
            //Console.WriteLine(findNeedle);
            
            // Because the method is an integer, we will need to return an integer
            return findNeedle;
        }
    }
}
