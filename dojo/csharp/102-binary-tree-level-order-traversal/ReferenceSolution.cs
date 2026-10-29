public class ReferenceSolution : Solution
{
    // O(n) time. Drain the queue one level at a time.
    public override IList<IList<int>> LevelOrder(TreeNode? root)
    {
        var result = new List<IList<int>>();
        if (root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            // At this point the queue holds exactly one level.
            int count = queue.Count;
            var level = new List<int>();
            for (int i = 0; i < count; i += 1)
            {
                var n = queue.Dequeue();
                level.Add(n.val);
                // Children join the queue behind this level, so they form the next one.
                if (n.left != null)
                {
                    queue.Enqueue(n.left);
                }
                if (n.right != null)
                {
                    queue.Enqueue(n.right);
                }
            }
            result.Add(level);
        }
        return result;
    }
}
