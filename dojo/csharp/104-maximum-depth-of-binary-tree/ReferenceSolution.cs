public class ReferenceSolution : Solution
{
    // O(n) time. BFS adds one to the depth for every level it drains.
    public override int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;
        while (queue.Count > 0)
        {
            int count = queue.Count;
            depth += 1;
            for (int i = 0; i < count; i += 1)
            {
                var n = queue.Dequeue();
                if (n.left != null)
                {
                    queue.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    queue.Enqueue(n.right);
                }
            }
        }
        return depth;
    }
}
