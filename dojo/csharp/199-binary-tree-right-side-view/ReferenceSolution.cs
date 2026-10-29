public class ReferenceSolution : Solution
{
    // O(n) time. BFS by level; the last node of each level is the one seen from the right.
    public override IList<int> RightSideView(TreeNode? root)
    {
        var result = new List<int>();
        if (root == null)
        {
            return result;
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            for (int i = 0; i < count; i += 1)
            {
                var n = queue.Dequeue();
                if (i == count - 1)
                {
                    result.Add(n.val);
                }
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
        return result;
    }
}
