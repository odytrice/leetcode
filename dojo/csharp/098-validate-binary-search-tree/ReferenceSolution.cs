public class ReferenceSolution : Solution
{
    // O(n) time. An in-order walk of a valid BST is strictly increasing.
    public override bool IsValidBST(TreeNode? root)
    {
        var stack = new Stack<TreeNode>();
        long previous = long.MinValue;
        while (root != null || stack.Count > 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            if (root.val <= previous)
            {
                return false;
            }
            previous = root.val;
            root = root.right;
        }
        return true;
    }
}
