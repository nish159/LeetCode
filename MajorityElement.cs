/*
Given an array nums of size n, return the majority element.
The majority element is the element that appears more than ⌊n / 2⌋ times. 
You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2

Constraints:
n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109

Follow-up: Could you solve the problem in linear time and in O(1) space?
*/

public class Solution {
    public int MajorityElement(int[] nums) {
        // create a dictionary 
        // key = number
        // value = count 
        
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            // create a variable for the current number in the array
            var currNum = nums[i];
            
            // if the dicitionary does not contain the current number add it with a value of 1
            if (!dictionary.ContainsKey(currNum)) {
                dictionary.Add(currNum, 1);
            }
            else {
                // increment the value by 1
                dictionary[currNum]++;
            }
        }
        
        // we need to search for the max value within the key and the value
        int maxKey = dictionary.First().Key;
        int maxValue = dictionary.First().Value;
        
        foreach (KeyValuePair<int, int> entry in dictionary) {
            if (entry.Value > maxValue) {
                maxValue = entry.Value;
                maxKey = entry.Key;
            }
        }
        
        return maxKey;
    }
}
