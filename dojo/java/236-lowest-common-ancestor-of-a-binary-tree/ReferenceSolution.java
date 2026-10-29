import java.util.ArrayDeque;
import java.util.Deque;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

/** O(n) time. Records every parent, then walks up from both nodes. */
class ReferenceSolution extends Solution {
    @Override
    public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // parents maps each node to its parent; the root's parent is null.
        Map<TreeNode, TreeNode> parents = new HashMap<>();
        parents.put(root, null);
        Deque<TreeNode> stack = new ArrayDeque<>();
        stack.push(root);
        while (!stack.isEmpty()) {
            TreeNode node = stack.pop();
            if (node.left != null) {
                parents.put(node.left, node);
                stack.push(node.left);
            }
            if (node.right != null) {
                parents.put(node.right, node);
                stack.push(node.right);
            }
        }

        // Collect p and every ancestor of p, up to the root.
        Set<TreeNode> ancestors = new HashSet<>();
        for (TreeNode node = p; node != null; node = parents.get(node)) {
            ancestors.add(node);
        }
        // Climb from q; the first node shared with p's chain is the lowest common ancestor.
        TreeNode node = q;
        while (!ancestors.contains(node)) {
            node = parents.get(node);
        }
        return node;
    }
}