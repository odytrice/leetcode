public class ReferenceSolution : Solution
{
    // O(n) time. Iterative construction avoids recursion depth on a skewed tree.
    public override TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        var root = new TreeNode(preorder[0]);
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        int j = 0;
        for (int i = 1; i < preorder.Length; i += 1)
        {
            var parent = stack.Peek();
            var node = new TreeNode(preorder[i]);
            if (parent.val != inorder[j])
            {
                // Still descending left.
                parent.left = node;
            }
            else
            {
                // Pop the finished left chain; the last popped node owns the right child.
                while (stack.Count > 0 && stack.Peek().val == inorder[j])
                {
                    parent = stack.Pop();
                    j += 1;
                }
                parent.right = node;
            }
            stack.Push(node);
        }
        return root;
    }
}
