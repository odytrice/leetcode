public class ReferenceSolution : LRUCache
{
    // O(1) per operation. The list keeps recency order; the dictionary finds a node by key.
    private readonly int capacity;
    private readonly LinkedList<(int Key, int Value)> order = new();
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> nodes = new();

    public ReferenceSolution(int capacity) : base(capacity)
    {
        this.capacity = capacity;
    }

    public override int Get(int key)
    {
        if (!nodes.TryGetValue(key, out var node))
        {
            return -1;
        }
        // Reading a key makes it the most recently used.
        order.Remove(node);
        order.AddFirst(node);
        return node.Value.Value;
    }

    public override void Put(int key, int value)
    {
        if (nodes.TryGetValue(key, out var node))
        {
            node.Value = (key, value);
            order.Remove(node);
            order.AddFirst(node);
            return;
        }
        // Evict the least recently used entry, which sits at the back.
        if (nodes.Count == capacity)
        {
            nodes.Remove(order.Last!.Value.Key);
            order.RemoveLast();
        }
        nodes[key] = order.AddFirst((key, value));
    }
}
