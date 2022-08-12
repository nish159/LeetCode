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
