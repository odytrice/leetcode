import java.util.ArrayDeque;
import java.util.Deque;

/** O(height + k) time. Stops the in-order walk at the kth value. */
class ReferenceSolution extends Solution {
    @Override
    public int kthSmallest(TreeNode root, int k) {
        Deque<TreeNode> stack = new ArrayDeque<>();
        TreeNode node = root;
        while (node != null || !stack.isEmpty()) {
            // Go as far left as possible; the smallest unvisited value ends up on top.
            while (node != null) {
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            // In-order visits values in ascending order, so count down to the kth one.
            k -= 1;
            if (k == 0) {
                return node.val;
            }
            // Values in the right subtree come next in sorted order.
            node = node.right;
        }
        throw new IllegalArgumentException("k is out of range");
    }
}
