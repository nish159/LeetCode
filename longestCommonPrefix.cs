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
        // Check if the input array is empty
        if (strs.Length == 0)
        {
            return "";
        }

        // Check if there is only one string in the array
        if (strs.Length == 1)
        {
            return strs[0];
        }

        // Initialize the prefix string
        string prefix = "";

        // Check if the first string is empty
        if(strs[0] == "")
        {
            return "";
        }

        // Iterate through each character in the first string
        for (int j = 0; j < strs[0].Length; j++)
        {
            var currentChar = strs[0][j];

            // Compare the current character in the first string with the corresponding characters in other strings
            for (int i = 0; i < strs.Length; i++)
            {
                // Check if the current word's length is less than or equal to the current index
                if(strs[i].Length <= j)
                {
                    return prefix;
                }

                // Check if the current character in other strings is different from the current character in the first string
                if (currentChar != strs[i][j])
                {
                    return prefix;
                } 
            }

            // Add the current character to the prefix string
            prefix += currentChar;
        }
        
        // Return the longest common prefix found
        return prefix;
    }
}
