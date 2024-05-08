/*
You are given the root of a binary tree that consists of exactly 3 nodes: the root, its left child, and its right child.
Return true if the value of the root is equal to the sum of the values of its two children, or false otherwise.

Example 1:
Input: root = [10,4,6]
Output: true
Explanation: The values of the root, its left child, and its right child are 10, 4, and 6, respectively.
10 is equal to 4 + 6, so we return true.

Example 2:
Input: root = [5,3,1]
Output: false
Explanation: The values of the root, its left child, and its right child are 5, 3, and 1, respectively.
5 is not equal to 3 + 1, so we return false.
 
Constraints:
The tree consists only of the root, its left child, and its right child.
-100 <= Node.val <= 100
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
    public bool CheckTree(TreeNode root) {
        // Call the private helper method CheckTreeP to check the tree for a specific condition
        return CheckTreeP(root);
    }
    
    // Private helper method to check the tree for a specific condition
    private bool CheckTreeP(TreeNode node) {
        // Base case: if the node is null, return false (condition not satisfied)
        if(node == null){
            return false;
        }
        
        // Check if the sum of values in the left and right subtrees equals the current node's value
        if(node.left.val + node.right.val == node.val){
            return true; // Return true if the condition is satisfied
        }
        else{
            return false; // Return false if the condition is not satisfied
        }
    }
}
