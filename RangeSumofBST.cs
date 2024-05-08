/*
Given the root node of a binary search tree and two integers low and high, 
return the sum of values of all nodes with a value in the inclusive range [low, high].

Example 1:
Input: root = [10,5,15,3,7,null,18], low = 7, high = 15
Output: 32
Explanation: Nodes 7, 10, and 15 are in the range [7, 15]. 7 + 10 + 15 = 32.

Example 2:
Input: root = [10,5,15,3,7,13,18,1,null,6], low = 6, high = 10
Output: 23
Explanation: Nodes 6, 7, and 10 are in the range [6, 10]. 6 + 7 + 10 = 23.

Constraints:

The number of nodes in the tree is in the range [1, 2 * 104].
1 <= Node.val <= 105
1 <= low <= high <= 105
All Node.val are unique.
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
    public int RangeSumBST(TreeNode root, int low, int high) {
        // Call the private helper method RangeSum to calculate the sum within the range [low, high]
        return RangeSum(root, low, high);
    }
    
    // Private helper method to calculate the sum of values within the range [low, high]
    private int RangeSum(TreeNode node, int low, int high) {
        // Base case: if the node is null, return 0 (sum is 0)
        if(node == null){
            return 0;
        }
        
        // Check if node.val is within the range [low, high]
        if(node.val >= low && node.val <= high){
            // If within range, recursively calculate sum for left and right subtrees and add node.val
            return RangeSum(node.left, low, high) + RangeSum(node.right, low, high) + node.val;
        }
        
        // If node.val is greater than high, search in the left subtree only
        if(node.val > high){
            return RangeSum(node.left, low, high);
        }
        
        // If node.val is less than low, search in the right subtree only
        if(node.val < low){
            return RangeSum(node.right, low, high);
        }
        
        return 0; // Default case if none of the conditions match (should not reach here)
    }
}
