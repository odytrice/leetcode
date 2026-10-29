public class ReferenceSolution : Solution
{
    // O(n) time. Iterative post-order: a node's longest path through it is left height + right height.
    public override int DiameterOfBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }
        // heights[n] is the number of nodes on the longest downward path from n.
        var heights = new Dictionary<TreeNode, int>();
        var stack = new Stack<(TreeNode Node, bool Done)>();
        stack.Push((root, false));
        int best = 0;
        while (stack.TryPop(out var item))
        {
            var n = item.Node;
            // First visit: come back to this node after both children are done.
            if (!item.Done)
            {
                stack.Push((n, true));
                if (n.left != null)
                {
                    stack.Push((n.left, false));
                }
                if (n.right != null)
                {
                    stack.Push((n.right, false));
                }
                continue;
            }
            // Second visit: both children already have their heights stored.
            int l = n.left == null ? 0 : heights[n.left];
            int r = n.right == null ? 0 : heights[n.right];
            // The longest path that bends at n has l + r edges.
            best = Math.Max(best, l + r);
            heights[n] = 1 + Math.Max(l, r);
        }
        return best;
    }
}
