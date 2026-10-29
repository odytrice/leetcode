import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. Iterative: attaches each preorder node, popping finished left chains. */
class ReferenceSolution extends Solution {
    @Override
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        // Preorder always lists the root first.
        TreeNode root = new TreeNode(preorder[0]);
        // The stack holds the current left chain: nodes whose right child is not placed yet.
        Deque<TreeNode> stack = new ArrayDeque<>();
        stack.push(root);
        // index points at the next inorder value, which is the next node to be "finished".
        int index = 0;
        for (int position = 1; position < preorder.length; position += 1) {
            TreeNode parent = stack.peek();
            TreeNode node = new TreeNode(preorder[position]);
            // The top has not reached its inorder turn yet, so it still has a left subtree.
            if (parent.val != inorder[index]) {
                parent.left = node;
            } else {
                // Pop every node whose inorder turn has come; the last one popped owns the right child.
                while (!stack.isEmpty() && stack.peek().val == inorder[index]) {
                    parent = stack.pop();
                    index += 1;
                }
                parent.right = node;
            }
            stack.push(node);
        }
        return root;
    }
}
