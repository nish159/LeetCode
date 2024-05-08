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

    public class Practice
    {
        static void Main(string[] args)
        {
            // Uncomment the desired test case and call the StrStr method
            
            // Test Case 1
            // string haystack = "hello";
            // string needle = "ll";

            // Test Case 2
            string haystack = "aaaaa";
            string needle = "bba";

            // Call the StrStr method to find the needle in the haystack
            StrStr(haystack, needle);
        }

        public static int StrStr(string haystack, string needle)
        {
            // Check if the haystack is empty
            if (haystack.Length == 0)
            {
                // If the haystack is empty, return 0
                return 0;
            }
            
            // Use IndexOf to find the first occurrence of the needle in the haystack
            int findNeedle = haystack.IndexOf(needle);
        
            // Uncomment the following line to print the result to the console
            // Console.WriteLine(findNeedle);
            
            // Return the index of the first occurrence of the needle in the haystack
            // If the needle is not found, IndexOf returns -1
            return findNeedle;
        }
    }
}
