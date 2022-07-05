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
    public int RangeSumBST(TreeNode root, int low, int high) {
        return RangeSum(root, low, high);
    }
    
    private int RangeSum(TreeNode node, int low, int high) {
        if(node == null){
            return 0;
        }
        
        // 1. node.val is within the range; look at both subtrees; node.val should be included because it is within range
        if(node.val >= low && node.val <= high){
            return RangeSum(node.left, low, high) + RangeSum(node.right, low, high) + node.val;
        }
        
        // 2. node.val is greater than high; look at the left subtree
        if(node.val > high){
            return RangeSum(node.left, low, high);
        }
        
        // 3. node.val is less than the low; look at the right subtree
        if(node.val < low){
            return RangeSum(node.right, low, high);
        }
        
        return 0;
    }
}
