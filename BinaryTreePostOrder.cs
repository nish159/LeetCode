/*
Given the root of a binary tree, return the postorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [3,2,1]

Example 2:
Input: root = []
Output: []

Example 3:
Input: root = [1]
Output: [1]

Constraints:
The number of the nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
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
