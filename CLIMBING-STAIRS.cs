/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
 

Constraints:

1 <= n <= 45
*/

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // Check if the input array is empty
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        // Initialize the common prefix as the first string in the array
        string commonPrefix = strs[0];

        // Loop through the remaining strings in the array
        for (int i = 1; i < strs.Length; i++)
        {
            // If the common prefix is empty, there can't be any common prefix
            if (string.IsNullOrEmpty(commonPrefix))
            {
                break;
            }

            // Initialize a new common prefix as an empty string
            string newPrefix = "";

            // Loop through each character in the current common prefix and the current string
            for (int j = 0; j < Math.Min(commonPrefix.Length, strs[i].Length); j++)
            {
                // If the characters match, add the character to the new common prefix
                if (commonPrefix[j] == strs[i][j])
                {
                    newPrefix += commonPrefix[j];
                }
                else
                {
                    // If the characters don't match, break the loop as the common prefix ends here
                    break;
                }
            }

            // Update the common prefix with the new common prefix
            commonPrefix = newPrefix;
        }

        return commonPrefix;
    }
}
