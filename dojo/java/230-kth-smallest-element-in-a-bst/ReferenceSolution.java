import java.util.ArrayDeque;
import java.util.Deque;

/** O(height + k) time. Stops the in-order walk at the kth value. */
class ReferenceSolution extends Solution {
    @Override
    public int kthSmallest(TreeNode root, int k) {
        Deque<TreeNode> stack = new ArrayDeque<>();
        TreeNode node = root;
        while (node != null || !stack.isEmpty()) {
            while (node != null) {
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            if (--k == 0) {
                return node.val;
            }
            node = node.right;
        }
        throw new IllegalArgumentException("k is out of range");
    }
}
