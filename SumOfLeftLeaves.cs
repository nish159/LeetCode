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
