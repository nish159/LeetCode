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
