import java.util.ArrayDeque;
import java.util.Deque;

/** O(n) time. BFS counts one level per queue drain. */
class ReferenceSolution extends Solution {
    @Override
    public int maxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }
        Deque<TreeNode> queue = new ArrayDeque<>();
        queue.add(root);
        int depth = 0;
        while (!queue.isEmpty()) {
            depth += 1;
            for (int count = queue.size(); count > 0; count -= 1) {
                TreeNode node = queue.poll();
                if (node.left != null) {
                    queue.add(node.left);
                }
                if (node.right != null) {
                    queue.add(node.right);
                }
            }
        }
        return depth;
    }
}
