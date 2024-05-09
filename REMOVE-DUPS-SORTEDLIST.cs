/*
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,1,2]
Output: [1,2]
Example 2:


Input: head = [1,1,2,3,3]
Output: [1,2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
*/

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
    public ListNode DeleteDuplicates(ListNode head)
    {
        // Check if the linked list is empty or has only one node
        if (head == null || head.next == null)
        {
            return head;
        }
        
        // Initialize a pointer to traverse the linked list
        ListNode current = head;
        
        // Traverse the linked list
        while (current != null && current.next != null)
        {
            // If the current node's value is equal to the next node's value, skip the next node
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                // Move to the next node
                current = current.next;
            }
        }
        
        return head;
    }
}
