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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        PostOrderTraversal(root, list);
        return list;
    }
    
    private void PostOrderTraversal(TreeNode node, List<int> list){
        if(node == null){
            return;
        }
        
        PostOrderTraversal(node.left, list);
        
        PostOrderTraversal(node.right, list);
        
        list.Add(node.val);
    }
}
