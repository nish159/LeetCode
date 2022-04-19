namespace practice
{
    using System;
 
    public class Practice
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int[] nums = { 1, 1, 2 }; 

            RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return nums.Length;
            }

            // Where the array starts 
            int index = 1;

            // nums.length - 1 is to make sure the array stays inbounds
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // If i is not equal to the next index in the array
                if (nums[i] != nums[i + 1])
                {
                    // Increment the index; nums of i + 1 will be replaced by the new index
                   nums[index++] = nums[i + 1];
                }
            }
            return index;
        }
    }
}
