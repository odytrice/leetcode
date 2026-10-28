/** O(n) time. Height of each child, summed at every node, is the path through it. */
class ReferenceSolution extends Solution {
    private int best;

    @Override
    public int diameterOfBinaryTree(TreeNode root) {
        best = 0;
        height(root);
        return best;
    }

    private int height(TreeNode node) {
        if (node == null) {
            return 0;
        }
        int left = height(node.left);
        int right = height(node.right);
        best = Math.max(best, left + right);
        return 1 + Math.max(left, right);
    }
}
