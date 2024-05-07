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
    // Public method to perform postorder traversal and return the result as a list
    public IList<int> PostorderTraversal(TreeNode root) {
        // Initialize a list to store the postorder traversal result
        List<int> list = new List<int>();
        // Call the private helper method to perform the actual traversal
        PostOrderTraversal(root, list);
        // Return the list containing the postorder traversal result
        return list;
    }
    
    // Private helper method to perform postorder traversal recursively
    private void PostOrderTraversal(TreeNode node, List<int> list) {
        // Base case: if the node is null, return
        if(node == null){
            return;
        }
        
        // Recursively traverse the left subtree
        PostOrderTraversal(node.left, list);
        
        // Recursively traverse the right subtree
        PostOrderTraversal(node.right, list);
        
        // Add the current node's value to the list (postorder position)
        list.Add(node.val);
    }
}
