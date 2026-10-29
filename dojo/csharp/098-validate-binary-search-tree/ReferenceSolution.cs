public class ReferenceSolution : Solution
{
    // O(n) time. An in-order walk of a valid BST is strictly increasing.
    public override bool IsValidBST(TreeNode? root)
    {
        var stack = new Stack<TreeNode>();
        // long.MinValue sits below any int, so the first node always passes.
        long previous = long.MinValue;
        while (root != null || stack.Count > 0)
        {
            // Push the left spine; the deepest node is the next value in order.
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            // Visit the next node in sorted order.
            root = stack.Pop();
            if (root.val <= previous)
            {
                return false;
            }
            previous = root.val;
            // Its right subtree holds the values that come next.
            root = root.right;
        }
        return true;
    }
}
