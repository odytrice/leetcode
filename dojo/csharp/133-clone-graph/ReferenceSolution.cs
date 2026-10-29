public class ReferenceSolution : Solution
{
    // O(V + E) time. BFS, creating each copy the first time its original is seen.
    public override Node? CloneGraph(Node? node)
    {
        if (node == null)
        {
            return null;
        }
        // copies maps each original to its clone and doubles as the visited set.
        var copies = new Dictionary<Node, Node> { [node] = new(node.val) };
        var queue = new Queue<Node>();
        queue.Enqueue(node);
        while (queue.TryDequeue(out var original))
        {
            foreach (var neighbor in original.neighbors)
            {
                // Clone and queue a neighbor only the first time it appears.
                if (!copies.ContainsKey(neighbor))
                {
                    copies[neighbor] = new(neighbor.val);
                    queue.Enqueue(neighbor);
                }
                // Link the clones the same way the originals are linked.
                copies[original].neighbors.Add(copies[neighbor]);
            }
        }
        return copies[node];
    }
}
