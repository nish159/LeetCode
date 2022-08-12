/*
Given the root of a binary tree, return the sum of all left leaves.

A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: 24
Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.

Example 2:
Input: root = [1]
Output: 0

Constraints:
The number of nodes in the tree is in the range [1, 1000].
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
    public int SumOfLeftLeaves(TreeNode root) {
        return SumLeft(root);
    }
    
    private int SumLeft(TreeNode node) {
        if(node == null) {
            return 0;
        }
        
        /*  if the left node is not null
            and the left child of the left node is null
            and the right child of the left node is null
            return the value of the left node and the recursive 
            value of the right node left value 
         */
        if(node.left != null && node.left.left == null && node.left.right == null) {
            return node.left.val + SumLeft(node.right);
        }
        // add the values of the left and the right nodes
        return SumLeft(node.left) + SumLeft(node.right);
    }
}
