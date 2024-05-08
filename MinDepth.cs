/*
Given a binary tree, find its minimum depth.
The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
Note: A leaf is a node with no children.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: 2

Example 2:
Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5

Constraints:
The number of nodes in the tree is in the range [0, 105].
-1000 <= Node.val <= 1000
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
    public int MinDepth(TreeNode root) {
        // Call the private helper method MinDepthP to calculate the minimum depth
        return MinDepthP(root);
    }
    
    // Private helper method to calculate the minimum depth of the binary tree
    private int MinDepthP(TreeNode node) {
        // Base case: if the node is null, return 0 (depth is 0)
        if(node == null){
            return 0;
        }
        
        // If the node is a leaf node (both left and right children are null), depth is 1
        if(node.left == null && node.right == null){
            return 1;
        }
        // If the left child is null, calculate the depth of the right subtree and add 1
        else if(node.left == null){
            return MinDepthP(node.right) + 1;
        }
        // If the right child is null, calculate the depth of the left subtree and add 1
        else if(node.right == null){
            return MinDepthP(node.left) + 1;
        }
        
        // Calculate the depth of the left and right subtrees recursively
        int depthLeft = MinDepthP(node.left);
        int depthRight = MinDepthP(node.right);
        
        // Calculate the minimum depth by taking the minimum of left and right subtree depths, then add 1 for the current node
        var min = Math.Min(depthLeft, depthRight);
        return min + 1;
    }
}
