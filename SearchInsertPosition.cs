/*
Given a sorted array of distinct integers and a target value, return the index if the value is not found.
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1
Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2
Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3
Input: nums = [1,3,5,6], target = 7
Output: 4

Constraints:
1 <= nums.Length <= 10^4
-10 <= nums[i] <= 10^4
nums contains distinct values sorted in ascending order
-10^4 <= target <= 10^4
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // store our index
        int count = 0;
        
        // loop through our array
        for (int i = 0; i < nums.Length; i++) {
            // if nums is less than the target 
            if (nums[i] < target) {
                count++;
            }
            // anything greater than our target we break the program
            else if (nums[i] > target) {
                break;
            }
        }
        return count;
    }
}
