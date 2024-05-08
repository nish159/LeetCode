/*
Given the root of a Binary Search Tree (BST), 
return the minimum absolute difference between the values of any two different nodes in the tree.

Example 1:
Input: root = [4,2,6,1,3]
Output: 1

Example 2:
Input: root = [1,0,48,null,null,12,49]
Output: 1

Constraints:
The number of nodes in the tree is in the range [2, 104].
0 <= Node.val <= 105
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
    public int GetMinimumDifference(TreeNode root) {
        // Create a list to store the values of nodes in the BST (in-order traversal)
        List<int> list = new List<int>();
        
        // Perform in-order traversal to populate the list with node values
        InOrderTraversal(root, list);
        
        // Return the minimum absolute difference between any two adjacent nodes in the list
        return GetMinDiff(list);
    }
    
    // In-order traversal of the BST to populate the list with node values
    private void InOrderTraversal(TreeNode node, List<int> list) {
        if(node == null) {
            return;
        }
        
        InOrderTraversal(node.left, list); // Traverse left subtree
        
        list.Add(node.val); // Add current node value to the list
        
        InOrderTraversal(node.right, list); // Traverse right subtree
    }
    
    // Calculate the minimum absolute difference between any two adjacent nodes in the list
    private int GetMinDiff(List<int> list) {
        // Initialize min variable with a maximum value to store minimum difference
        int min = int.MaxValue;
        
        // Iterate through the list to compare adjacent elements and find the minimum difference
        for (int i = 0; i < list.Count - 1; i++) {
            int curr = list[i];
            int next = list[i + 1];
            
            // Calculate the absolute difference between adjacent elements
            int diff = next - curr;
            
            // Update min value if the current difference is smaller
            min = Math.Min(min, diff);
        }
        
        return min; // Return the minimum absolute difference
    }
}
