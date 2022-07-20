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
    // max length is 0
    int maxDiameter = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        Diameter(root);
        return maxDiameter;
    }
    
    private int Diameter(TreeNode node){
        if(node == null){
            return 0;
        }
        
        int leftDepth = Diameter(node.left);
        int rightDepth = Diameter(node.right);
        // checking if the diameter of the subtree with the current node as the root is greater than the max diameter previously found
        int currentDiameter = leftDepth + rightDepth;
        if(currentDiameter > maxDiameter) {
            maxDiameter = currentDiameter;
        }
        
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
