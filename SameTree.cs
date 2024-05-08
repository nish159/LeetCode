/*
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

Example 1:
Input: p = [1,2,3], q = [1,2,3]
Output: true

Example 2:
Input: p = [1,2], q = [1,null,2]
Output: false

Example 3:
Input: p = [1,2,1], q = [1,1,2]
Output: false 

Constraints:
The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Call the private helper method IsSameTreePrivate to check if the trees are the same
        return IsSameTreePrivate(p, q);
    }
    
    // Private helper method to check if two trees are the same
    private bool IsSameTreePrivate(TreeNode p, TreeNode q) {
        // Base case: if both nodes are null, they are the same
        if(p == null && q == null)
        {
            return true;
        }
        // If one node is null and the other is not, they are not the same
        if(p == null && q != null)
        {
            return false;
        }
        if(q == null && p != null)
        {
            return false;
        }
        // If the values of the nodes are not equal, they are not the same
        if(p.val != q.val)
        {
            return false;
        }
        
        // Recursively check if the left and right subtrees are the same
        var sameLeft = IsSameTree(p.left, q.left);
        var sameRight = IsSameTree(p.right, q.right);
        
        // If both left and right subtrees are the same, return true; otherwise, return false
        if(sameLeft == true && sameRight == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
