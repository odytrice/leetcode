public class ReferenceSolution : Solution
{
    public override int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>(); TreeNode? node = root;
        while (node != null || stack.Count > 0)
        {
            while (node != null) { stack.Push(node); node = node.left; }
            node = stack.Pop(); if (--k == 0) return node.val; node = node.right;
        }
        throw new ArgumentOutOfRangeException(nameof(k));
    }
}
