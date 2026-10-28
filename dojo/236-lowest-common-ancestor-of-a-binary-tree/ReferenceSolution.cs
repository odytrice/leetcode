public class ReferenceSolution : Solution
{
    public override TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var parent = new Dictionary<TreeNode, TreeNode?> { [root] = null };
        var stack = new Stack<TreeNode>(); stack.Push(root);
        while (!parent.ContainsKey(p) || !parent.ContainsKey(q))
        {
            var n = stack.Pop();
            if (n.left != null) { parent[n.left] = n; stack.Push(n.left); }
            if (n.right != null) { parent[n.right] = n; stack.Push(n.right); }
        }
        var ancestors = new HashSet<TreeNode>();
        for (TreeNode? n = p; n != null; n = parent[n]) ancestors.Add(n);
        for (TreeNode? n = q; n != null; n = parent[n]) if (ancestors.Contains(n)) return n;
        throw new ArgumentException();
    }
}
