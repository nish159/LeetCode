/*
Given an array of distinct integers arr, find all pairs of elements with the minimum absolute difference of any two elements.
Return a list of pairs in ascending order(with respect to pairs), each pair [a, b] follows

a, b are from arr
a < b
b - a equals to the minimum absolute difference of any two elements in arr

Example 1:
Input: arr = [4,2,1,3]
Output: [[1,2],[2,3],[3,4]]
Explanation: The minimum absolute difference is 1. List all pairs with difference equal to 1 in ascending order.

Example 2:
Input: arr = [1,3,6,10,15]
Output: [[1,3]]
Example 3:

Input: arr = [3,8,-10,23,19,-4,-14,27]
Output: [[-14,-10],[19,23],[23,27]]

Constraints:
2 <= arr.length <= 105
-106 <= arr[i] <= 106
*/

public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        // Sort the input array in ascending order
        Array.Sort(arr);
        
        // Initialize a list to store pairs with minimum absolute difference
        IList<IList<int>> ans = new List<IList<int>>();
        
        // Initialize the minimum difference to the maximum possible value
        int minDiff = int.MaxValue;
        
        // Iterate through the sorted array to find the minimum absolute difference
        for(int i = 0; i < arr.Length - 1; i++) {
            // Calculate the absolute difference between adjacent elements
            int diff = Math.Abs(arr[i + 1] - arr[i]);
            
            // Update the minimum difference if the current difference is smaller
            minDiff = Math.Min(diff, minDiff);
        }
        
        // Iterate through the array again to find pairs with the minimum absolute difference
        for(int i = 0; i < arr.Length - 1; i++) {
            int diff = Math.Abs(arr[i + 1] - arr[i]);
            
            // If the difference equals the minimum difference, add the pair to the result list
            if (minDiff == diff) {
                List<int> pair = new List<int>{arr[i], arr[i + 1]};
                ans.Add(pair);
            }
        }
        
        return ans; // Return the list of pairs with minimum absolute difference
    }
}

