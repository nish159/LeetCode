/*
Given the root of a binary tree, return the inorder traversal of its nodes' values.

Example 1:
Input: root = [1,null,2,3]
Output: [1,3,2]

Example 2:
Input: root = []
Output: []

Example 3:
Input: root = [1]
Output: [1]
 
Constraints:
The number of nodes in the tree is in the range [0, 100].
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
    // Public method to perform inorder traversal and return the result as a list
    public IList<int> InorderTraversal(TreeNode root) {
        // Initialize a list to store the inorder traversal result
        List<int> list = new List<int>();
        // Call the private helper method to perform the actual traversal
        InorderTraversal(root, list);
        // Return the list containing the inorder traversal result
        return list;
    }
    
    // Private helper method to perform inorder traversal recursively
    private void InorderTraversal(TreeNode node, List<int> list) {
        // Base case: if the node is null, return
        if(node == null){
            return;
        }
        // Recursively traverse the left subtree
        InorderTraversal(node.left, list);
        
        // Add the current node's value to the list (inorder position)
        list.Add(node.val);
        
        // Recursively traverse the right subtree
        InorderTraversal(node.right, list);
    }
}

