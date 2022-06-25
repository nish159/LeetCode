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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        PreorderTraversal(root, list);
        return list;
    }
    private void PreorderTraversal(TreeNode node, List<int> list) {
        if(node == null){
            return;
        }
        
        list.Add(node.val);
        
        PreorderTraversal(node.left, list);
        
        PreorderTraversal(node.right, list);
        
        
    }
}
