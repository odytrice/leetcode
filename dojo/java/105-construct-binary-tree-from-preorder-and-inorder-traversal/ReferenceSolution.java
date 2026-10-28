import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. Iterative: attaches each preorder node, popping finished left chains. */
class ReferenceSolution extends Solution {
    @Override
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        TreeNode root = new TreeNode(preorder[0]);
        Deque<TreeNode> stack = new ArrayDeque<>();
        stack.push(root);
        int index = 0;
        for (int position = 1; position < preorder.length; position++) {
            TreeNode parent = stack.peek();
            TreeNode node = new TreeNode(preorder[position]);
            if (parent.val != inorder[index]) {
                parent.left = node;
            } else {
                while (!stack.isEmpty() && stack.peek().val == inorder[index]) {
                    parent = stack.pop();
                    index++;
                }
                parent.right = node;
            }
            stack.push(node);
        }
        return root;
    }
}
