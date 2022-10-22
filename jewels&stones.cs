/*
You're given strings jewels representing the types of stones that are jewels, and
stones representing the stones you have. Each character in stones is a type of stone
you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:
Input: jewels = "aA", stones = "aAAbbbb"
Output: 3

Example 2:
Input: jewels = "z", stones = "ZZ"
Output: 0

Constraints:
1 <= jewels.length, stones.length <= 50
jewels and stones consist of only english letters 
All the characters of jewels are unique
*/

public class Solution {
    public int NumsJewelsInStones(string jewels, string stones) 
    {
        // need a variable to store the count
        int count = 0;

        // loop through stones to find where the jewels are located
        for (int i = 0; i < stones.Length; i++)
        {
            // if jewels contains any of the stones
            if (jewels.Contains(stones[i])) 
            {
                count++;
            }
        }
        return count;
    }
}