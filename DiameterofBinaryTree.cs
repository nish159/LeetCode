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
    int max = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        Diameter(root);
        return max;
    }
    
    private int Diameter(TreeNode node){
        if(node == null){
            return 0;
        }
        
        int leftDepth = Diameter(node.left);
        int rightDepth = Diameter(node.right);
        
        max = Math.Max(max, leftDepth + rightDepth);
        
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
