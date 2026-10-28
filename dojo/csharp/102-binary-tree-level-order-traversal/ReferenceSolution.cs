public class ReferenceSolution : Solution
{
    public override IList<IList<int>> LevelOrder(TreeNode? root)
    {
        var result = new List<IList<int>>();
        if (root == null) return result;
        var queue = new Queue<TreeNode>(); queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count; var level = new List<int>();
            while (count-- > 0)
            {
                var n = queue.Dequeue(); level.Add(n.val);
                if (n.left != null) queue.Enqueue(n.left);
                if (n.right != null) queue.Enqueue(n.right);
            }
            result.Add(level);
        }
        return result;
    }
}
