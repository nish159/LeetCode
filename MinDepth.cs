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
        return MinDepthP(root);
    }
    
    private int MinDepthP(TreeNode node) {
        if(node == null){
            return 0;
        }
        
        // if the leaf nodes in the subtree are null
        if(node.left == null && node.right == null){
            // the count is 1
            return 1;
        }
        else if(node.left == null){
            // when going up the tree you have to add each one from before
            return MinDepthP(node.right) + 1;
        }
        else if(node.right == null){
            return MinDepthP(node.left) + 1;
        }
        
        int depthLeft = MinDepthP(node.left);
        int depthRight = MinDepthP(node.right);
        
        var min = Math.Min(depthLeft, depthRight);
        return min + 1;
    }
}
