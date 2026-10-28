import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. An in-order traversal of a BST is strictly increasing. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValidBST(TreeNode root) {
        Deque<TreeNode> stack = new ArrayDeque<>();
        long previous = Long.MIN_VALUE;
        TreeNode node = root;
        while (node != null || !stack.isEmpty()) {
            while (node != null) {
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            if (node.val <= previous) {
                return false;
            }
            previous = node.val;
            node = node.right;
        }
        return true;
    }
}
