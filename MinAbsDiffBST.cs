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
        // create a list to traverse through the nodes
        List<int> list = new List<int>();
        
        return GetMinDiff(root, list);
        
    }
    
    private void InOrderTraversal(TreeNode node, List<int> list) {
        if(node == null) {
            return;
        }
        
        InOrderTraversal(node.left, list);
        
        list.Add(node.val);
        
        InOrderTraversal(node.right, list);
    }
    
    private int GetMinDiff(TreeNode node, List<int> list) {
        InOrderTraversal(node, list);
        
        // initialize min variable with a max val
        // and initialize max variable with a min val
        int min = int.MaxValue;
        
        // list.Count will count the numbers in the list
        // subtract 1 to ensure that the for loop does not
        // go out of bounds
      for (int i = 0; i < list.Count - 1; i++) {
          int curr = list[i];
          int next = list[i + 1];
          
          // initialize a value for the min variable
          int val = next - curr;
          
          // override the min value with the new value
          min = Math.Min(min, val);
      }
        return min;
    }
}
