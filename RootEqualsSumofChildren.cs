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
        return CheckTreeP(root);
    }
    
    private bool CheckTreeP(TreeNode node) {
        if(node == null){
            return false;
        }
        
        if(node.left.val + node.right.val == node.val){
            return true;
        }
        else{
            return false;
        }
    }
}
