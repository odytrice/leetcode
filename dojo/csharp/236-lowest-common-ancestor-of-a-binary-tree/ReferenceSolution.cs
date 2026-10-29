public class ReferenceSolution : Solution
{
    // O(n) time. Record parents until both nodes are found, then intersect their ancestor chains.
    public override TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // parent maps each visited node to its parent; the root has none.
        var parent = new Dictionary<TreeNode, TreeNode?> { [root] = null };
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        // Walk the tree only until both p and q have been reached.
        while (!parent.ContainsKey(p) || !parent.ContainsKey(q))
        {
            var n = stack.Pop();
            if (n.left != null)
            {
                parent[n.left] = n;
                stack.Push(n.left);
            }
            if (n.right != null)
            {
                parent[n.right] = n;
                stack.Push(n.right);
            }
        }

        // Collect p and every ancestor of p.
        var ancestors = new HashSet<TreeNode>();
        for (TreeNode? n = p; n != null; n = parent[n])
        {
            ancestors.Add(n);
        }
        // The first of q's ancestors that is also p's is the lowest common one.
        for (TreeNode? n = q; n != null; n = parent[n])
        {
            if (ancestors.Contains(n))
            {
                return n;
            }
        }
        // p and q are always in the tree, so this is never reached.
        throw new ArgumentException();
    }
}
