/*
Given the root of a binary tree, return the length of the diameter of the tree.
The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
The length of a path between two nodes is represented by the number of edges between them.

Example 1:
Input: root = [1,2,3,4,5]
Output: 3
Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].

Example 2:
Input: root = [1,2]
Output: 1
 
Constraints:
The number of nodes in the tree is in the range [1, 104].
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
    // Initialize maxDiameter to 0
    int maxDiameter = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        // Call the private helper method to calculate the diameter
        Diameter(root);
        // Return the maximum diameter found
        return maxDiameter;
    }
    
    private int Diameter(TreeNode node){
        // Base case: if the node is null, return 0
        if(node == null){
            return 0;
        }
        
        // Calculate the left subtree depth recursively
        int leftDepth = Diameter(node.left);
        // Calculate the right subtree depth recursively
        int rightDepth = Diameter(node.right);
        
        // Calculate the current diameter (sum of left and right subtree depths)
        int currentDiameter = leftDepth + rightDepth;
        // Update maxDiameter if the current diameter is greater
        if(currentDiameter > maxDiameter) {
            maxDiameter = currentDiameter;
        }
        
        // Return the depth of the current subtree (1 + max of left and right subtree depths)
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}

