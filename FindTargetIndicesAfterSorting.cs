/*
You are given a 0-indexed integer array and a target element target.

A target index is an index i such that nums[i] == target.

Return a list of the target indices of nums after sorting nums in non-decreasing order. If there
are no target indices, return an empty list. The returned list must be sorted in increasing order.

Example 1
Input: nums = [1,2,5,2,3], target = 2
Output: [1,2]
Explanation: After sorting, nums is [1,2,2,3,5]. The indices where nums[i] == 2 are 1 and 2.

Example 2
Input: nums = [1,2,5,2,3], target = 3
Output: [3]
Explanation: After sorting, nums is  [1,2,2,3,5]. The index where nums[i] == 3 is 3.

Example 3
Input: nums = [1,2,5,2,3], target = 5
Output: [4]
Explanation: After sorting,, nums is [1,2,2,3,5]. The index where nums[i] == 5 is 4.

Constraints:
1 <= nums.Length <= 100
1 <= nums[i], target <= 100
*/

int[] nums = { 1, 2, 5, 2, 3 };
int target = 2;

TargetIndices(nums, target);

IList<int> TargetIndices(int[] nums, int target)
{
    // sort the array
    Array.Sort(nums);

    // output answer into an array
    List<int> answer = new List<int>();

    // loop through the array
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == target)
        {
            answer.Add(i);
        }
        // if target is greater than nums program will break
        else if (nums[i] > target)
        {
            break;
        }
    }
    return answer;
}
