import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Deque;
import java.util.List;

/** O(n) time. Drains the queue one level at a time. */
class ReferenceSolution extends Solution {
    @Override
    public List<List<Integer>> levelOrder(TreeNode root) {
        List<List<Integer>> result = new ArrayList<>();
        if (root == null) {
            return result;
        }
        Deque<TreeNode> queue = new ArrayDeque<>();
        queue.add(root);
        while (!queue.isEmpty()) {
            List<Integer> level = new ArrayList<>();
            // At this point the queue holds exactly one level, so its size is the level's width.
            for (int count = queue.size(); count > 0; count -= 1) {
                TreeNode node = queue.poll();
                level.add(node.val);
                // Children join the back of the queue and form the next level.
                if (node.left != null) {
                    queue.add(node.left);
                }
                if (node.right != null) {
                    queue.add(node.right);
                }
            }
            result.add(level);
        }
        return result;
    }
}
