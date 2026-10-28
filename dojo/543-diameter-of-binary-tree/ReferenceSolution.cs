public class ReferenceSolution : Solution
{
    public override int DiameterOfBinaryTree(TreeNode? root)
    {
        if (root == null) return 0;
        var heights = new Dictionary<TreeNode, int>(); var stack = new Stack<(TreeNode Node, bool Done)>();
        stack.Push((root, false)); int best = 0;
        while (stack.TryPop(out var item))
        {
            var n = item.Node;
            if (!item.Done)
            {
                stack.Push((n, true));
                if (n.left != null) stack.Push((n.left, false));
                if (n.right != null) stack.Push((n.right, false));
                continue;
            }
            int l = n.left == null ? 0 : heights[n.left], r = n.right == null ? 0 : heights[n.right];
            best = Math.Max(best, l + r); heights[n] = 1 + Math.Max(l, r);
        }
        return best;
    }
}
