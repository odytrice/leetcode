/** O(n) time. Height of each child, summed at every node, is the path through it. */
class ReferenceSolution extends Solution {
    // The longest path found so far, measured in edges.
    private int best;

    @Override
    public int diameterOfBinaryTree(TreeNode root) {
        best = 0;
        height(root);
        return best;
    }

    // Returns the number of nodes on the longest downward path from node.
    private int height(TreeNode node) {
        if (node == null) {
            return 0;
        }
        int left = height(node.left);
        int right = height(node.right);
        // The longest path bending at this node goes down both sides; its edge count is left + right.
        best = Math.max(best, left + right);
        // A parent can only extend one side, so pass up the taller one.
        return 1 + Math.max(left, right);
    }
}
