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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null) {
            return null;
        }

        if (root.val == key) {
            return Rebuild(root);
        }

        Queue<TreeNode> q = new Queue<TreeNode>();

        q.Enqueue(root);

        while (q.TryDequeue(out var node)) {
            if (node == null) {
                continue;
            }
            
            if (node.right?.val == key) {
                TreeNode newTree = Rebuild(node.right);
                node.right = newTree;
                return root;
            }
            
            else if (node.left?.val == key) {
                TreeNode newTree = Rebuild(node.left);
                node.left = newTree;
                return root;
            }

            q.Enqueue(node.right);
            q.Enqueue(node.left);
        }

        return root;
    }

    public TreeNode Rebuild(TreeNode node) {
        if (node.right == null && node.left == null) {
            return null;
        }
        else if ((node.right == null && node.left != null) || 
        (node.left == null && node.right != null)) 
        {
            return node.right ?? node.left;
        }
        else {
            TreeNode iterator = node.right;
            while (iterator.left != null) {
                iterator = iterator.left;
            }
            (node.val, iterator.val) = (iterator.val, node.val);
            return DeleteNode(node, iterator.val);
        }
    }
}
