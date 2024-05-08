/*
Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
Return k after placing the final result in the first k slots of nums.
Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

Custom Judge:

The judge will test your solution with the following code:
int[] nums = [...]; // Input array
int[] expectedNums = [...]; // The expected answer with correct length
int k = removeDuplicates(nums); // Calls your implementation
assert k == expectedNums.length;
for (int i = 0; i < k; i++) {
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.
 
Example 1:
Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:
Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
 
Constraints:
	• 1 <= nums.length <= 3 * 104
	• -100 <= nums[i] <= 100
	• nums is sorted in non-decreasing order.
*/

namespace practice
{
    using System;

    public class Practice
    {
        static void Main(string[] args)
        {
            // Example arrays for testing
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] nums2 = { 1, 1, 2 };

            // Call the RemoveDuplicates method with the arrays
            RemoveDuplicates(nums1);
            RemoveDuplicates(nums2);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            // Check if the array is empty
            if (nums.Length == 0)
            {
                return nums.Length;
            }

            // Initialize the index where the array starts after removing duplicates
            int index = 1;

            // Loop through the array to check for duplicates
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // If the current element is not equal to the next element, it's not a duplicate
                if (nums[i] != nums[i + 1])
                {
                    // Increment the index and replace the element at that index with the non-duplicate value
                    nums[index++] = nums[i + 1];
                }
            }

            // Return the new length of the array without duplicates
            return index;
        }
    }
}





using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveDuplicates(ListNode head)
    {
        // Check if the list is empty or has only one node
        if (head == null || head.next == null)
        {
            return head;
        }

        // Create a HashSet to track seen values
        HashSet<int> seenValues = new HashSet<int>();
        ListNode current = head;
        ListNode previous = null;

        while (current != null)
        {
            // If the current node's value is already in the set, it's a duplicate
            if (seenValues.Contains(current.val))
            {
                // Skip the duplicate node by updating the pointers
                previous.next = current.next;
            }
            else
            {
                // Add the value to the set since it's not a duplicate
                seenValues.Add(current.val);
                // Move to the next node
                previous = current;
            }

            // Move to the next node in the list
            current = current.next;
        }

        return head;
    }
}

public class Program
{
    public static void Main()
    {
        // Create a sample linked list: 1 -> 2 -> 2 -> 3 -> 4 -> 4 -> 5
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(3);
        head.next.next.next.next = new ListNode(4);
        head.next.next.next.next.next = new ListNode(4);
        head.next.next.next.next.next.next = new ListNode(5);

        // Print the original list
        PrintLinkedList(head);

        Solution solution = new Solution();
        ListNode result = solution.RemoveDuplicates(head);

        // Print the list after removing duplicates
        PrintLinkedList(result);
    }

    // Helper method to print the linked list
    public static void PrintLinkedList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

