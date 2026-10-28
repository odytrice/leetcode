public class ReferenceSolution : Solution
{
    public override TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        // Iterative construction avoids recursion depth on a skewed tree.
        var root = new TreeNode(preorder[0]); var stack = new Stack<TreeNode>(); stack.Push(root);
        int j = 0;
        for (int i = 1; i < preorder.Length; i++)
        {
            var parent = stack.Peek(); var node = new TreeNode(preorder[i]);
            if (parent.val != inorder[j]) parent.left = node;
            else
            {
                while (stack.Count > 0 && stack.Peek().val == inorder[j]) { parent = stack.Pop(); j++; }
                parent.right = node;
            }
            stack.Push(node);
        }
        return root;
    }
}
