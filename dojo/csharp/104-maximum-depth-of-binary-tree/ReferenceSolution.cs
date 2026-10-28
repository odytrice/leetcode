public class ReferenceSolution : Solution
{
    public override int MaxDepth(TreeNode? root)
    {
        if (root == null) return 0;
        var queue = new Queue<TreeNode>(); queue.Enqueue(root); int depth = 0;
        while (queue.Count > 0)
        {
            int count = queue.Count; depth++;
            while (count-- > 0)
            {
                var n = queue.Dequeue();
                if (n.left != null) queue.Enqueue(n.left);
                if (n.right != null) queue.Enqueue(n.right);
            }
        }
        return depth;
    }
}
