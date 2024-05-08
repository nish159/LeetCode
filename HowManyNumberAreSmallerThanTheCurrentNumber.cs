/*
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
Return the answer in an array.
Example 1:
Input: nums = [8,1,2,2,3]
Output: [4,0,1,1,3]
Explanation: 
For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
For nums[1]=1 does not exist any smaller number than it.
For nums[2]=2 there exist one smaller number than it (1). 
For nums[3]=2 there exist one smaller number than it (1). 
For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).

Example 2:
Input: nums = [6,5,4,8]
Output: [2,1,0,3]
Example 3:
Input: nums = [7,7,7,7]
Output: [0,0,0,0]
Constraints:
2 <= nums.length <= 500
0 <= nums[i] <= 100
*/

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        // Create a new array to store the count of smaller numbers than each element
        int[] count = new int[nums.Length];
        
        // Iterate through the nums array using the first for loop
        for(int i = 0; i < nums.Length; i++) {
            // Initialize the count for the current element to 0
            count[i] = 0;
            // Compare each number in nums with the current number
            for(int j = 0; j < nums.Length; j++) {
                // If nums[j] is smaller than nums[i], increment the count for nums[i]
                if(nums[j] < nums[i]) {
                    count[i]++;
                }
            }
        }
        
        return count; // Return the count array containing the number of smaller numbers than each element
    }
}


/*
public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        
        // create a copy of the original array - we need the original to know the order of the output
        int[] sorted = (int[]) nums.Clone();
        
        // sort the cloned array
        Array.Sort(sorted);
        
        // create a dictionary/map to lookup counter by number
        // key: number
        // value: counter
        Dictionary<int, int> counterMap = new Dictionary<int, int>();
        
        // construct the counter map using the sorted array
        for(int i = 0; i < sorted.Length; i++) {
            // if map does not contain the current number
            if(!counterMap.ContainsKey(sorted[i])) {
                // add the number to the map
                counterMap.Add(sorted[i], i);
            }
        }
        
        // create the result array using the original array and the counter map
        int[] counterArray = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            int counter = counterMap[nums[i]];
            counterArray[i] = counter;
        }
        return counterArray;
    }
}
*/
