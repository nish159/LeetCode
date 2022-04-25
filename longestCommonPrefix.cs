/*
Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".
 
Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 
Constraints:
	• 1 <= strs.length <= 200
	• 0 <= strs[i].length <= 200
	• strs[i] consists of only lower-case English letters.
*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
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
        
            if(strs[0] == "")
            {
                return "";
            }

            for (int j = 0; j < strs[0].Length; j++) // Go through all the characters in the first word
            {
                var currentChar = strs[0][j];

                for (int i = 0; i < strs.Length; i++) // compare each character in the first word with the same character in the other words
                {
                    // string word = strs[i];

                    if(strs[i].Length <= j)
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
            }
            return prefix;
    }
}
