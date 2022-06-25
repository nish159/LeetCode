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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return IsSameTreePrivate(p, q);
    }
    
    private bool IsSameTreePrivate(TreeNode p, TreeNode q) {
        if(p == null && q == null)
        {
            return true;
        }
        if(p == null && q != null)
        {
            return false;
        }
        if(q == null && p != null)
        {
            return false;
        }
        if(p.val != q.val)
        {
            return false;
        }
        
        var sameLeft = IsSameTree(p.left, q.left);
        var sameRight = IsSameTree(p.right, q.right);
        
        if(sameLeft == true && sameRight == true)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
