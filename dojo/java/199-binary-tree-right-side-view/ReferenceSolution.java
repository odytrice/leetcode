import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(n) time. The last node of each level is the visible one. */
class ReferenceSolution extends Solution {
    @Override
    public List<Integer> rightSideView(TreeNode root) {
        List<Integer> result = new ArrayList<>();
        if (root == null) {
            return result;
        }
        Deque<TreeNode> queue = new ArrayDeque<>();
        queue.add(root);
        while (!queue.isEmpty()) {
            // The queue holds one full level, left to right.
            int size = queue.size();
            for (int index = 0; index < size; index += 1) {
                TreeNode node = queue.poll();
                // The rightmost node of the level is the one seen from the right.
                if (index == size - 1) {
                    result.add(node.val);
                }
                // Left before right keeps each level in left-to-right order.
                if (node.left != null) {
                    queue.add(node.left);
                }
                if (node.right != null) {
                    queue.add(node.right);
                }
            }
        }
        return result;
    }
}
