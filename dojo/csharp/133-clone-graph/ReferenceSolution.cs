public class ReferenceSolution : Solution
{
    public override Node? CloneGraph(Node? node)
    {
        if (node == null) return null;
        var copies = new Dictionary<Node, Node> { [node] = new(node.val) };
        var queue = new Queue<Node>(); queue.Enqueue(node);
        while (queue.TryDequeue(out var original))
        foreach (var neighbor in original.neighbors)
        {
            if (!copies.ContainsKey(neighbor)) { copies[neighbor] = new(neighbor.val); queue.Enqueue(neighbor); }
            copies[original].neighbors.Add(copies[neighbor]);
        }
        return copies[node];
    }
}
