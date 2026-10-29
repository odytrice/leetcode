public class ReferenceSolution : Solution
{
    // O(h + k) time. An in-order walk visits values in ascending order.
    public override int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();
        TreeNode? node = root;
        while (node != null || stack.Count > 0)
        {
            // Push the left spine; the smallest unvisited value ends up on top.
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            node = stack.Pop();
            // Count this node as the next smallest.
            k -= 1;
            if (k == 0)
            {
                return node.val;
            }
            // The right subtree holds the next larger values.
            node = node.right;
        }
        // Only reached if k is larger than the number of nodes.
        throw new ArgumentOutOfRangeException(nameof(k));
    }
}
