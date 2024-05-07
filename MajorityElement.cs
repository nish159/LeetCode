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
        // Create a dictionary to store number-count pairs
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        
        // Iterate through the array of numbers
        for (int i = 0; i < nums.Length; i++) {
            // Get the current number from the array
            var currNum = nums[i];
            
            // If the dictionary does not contain the current number, add it with a count of 1
            if (!dictionary.ContainsKey(currNum)) {
                dictionary.Add(currNum, 1);
            }
            else {
                // If the number is already in the dictionary, increment its count by 1
                dictionary[currNum]++;
            }
        }
        
        // Initialize variables to track the maximum key and value in the dictionary
        int maxKey = dictionary.First().Key;
        int maxValue = dictionary.First().Value;
        
        // Iterate through the dictionary to find the key with the maximum value
        foreach (KeyValuePair<int, int> entry in dictionary) {
            if (entry.Value > maxValue) {
                maxValue = entry.Value;
                maxKey = entry.Key;
            }
        }

        // Return the key with the maximum value, which represents the majority element
        return maxKey;
    }
}

