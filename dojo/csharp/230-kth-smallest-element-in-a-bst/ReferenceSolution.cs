public class ReferenceSolution : Solution
{
    // O(h + k) time. An in-order walk visits values in ascending order.
    public override int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();
        TreeNode? node = root;
        while (node != null || stack.Count > 0)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            node = stack.Pop();
            k -= 1;
            if (k == 0)
            {
                return node.val;
            }
            node = node.right;
        }
        throw new ArgumentOutOfRangeException(nameof(k));
    }
}
