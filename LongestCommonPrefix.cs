namespace practice
{
    using System;

    public class Practice
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            LongestCommonPrefix(strs);
            
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            
            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }
            

            // var firstChar = strs[0][0];
            // string firstWord = strs[0];
            string prefix = "";

            if (strs[0] == "")
            {
                return "";
            }

            for (int j = 0; j < strs[0].Length; j++) // Go through all the characters in the first word
            {
                var currentChar = strs[0][j];

                for (int i = 0; i < strs.Length; i++) // compare each character in the first word with the same character in the other words
                {
                    // string word = strs[i];

                    // Check if word has character number j
                    if(strs[i].Length < j)
                    {
                        return prefix;
                    }
                    // The current word does not have the same first letter as the other words
                    if (currentChar != strs[i][j])
                    {
                        return prefix;
                    } 
                }
                prefix += currentChar;

                Console.WriteLine(prefix);
            }
            return prefix;
        }
    }
}
