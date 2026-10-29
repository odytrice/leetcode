import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. An in-order traversal of a BST is strictly increasing. */
class ReferenceSolution extends Solution {
    @Override
    public boolean isValidBST(TreeNode root) {
        Deque<TreeNode> stack = new ArrayDeque<>();
        // A long sentinel sits below every int, so even Integer.MIN_VALUE passes the first check.
        long previous = Long.MIN_VALUE;
        TreeNode node = root;
        while (node != null || !stack.isEmpty()) {
            // Walk as far left as possible; the stack remembers the ancestors to visit later.
            while (node != null) {
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            // Each in-order value must be strictly larger than the one before it.
            if (node.val <= previous) {
                return false;
            }
            previous = node.val;
            node = node.right;
        }
        return true;
    }
}
