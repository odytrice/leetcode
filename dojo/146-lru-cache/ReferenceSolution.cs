public class ReferenceSolution : LRUCache
{
    private readonly int capacity;
    public ReferenceSolution(int capacity) : base(capacity) { this.capacity = capacity; }
    private readonly LinkedList<(int Key, int Value)> order = new();
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> nodes = new();
    public override int Get(int key)
    {
        if (!nodes.TryGetValue(key, out var node)) return -1;
        order.Remove(node); order.AddFirst(node); return node.Value.Value;
    }
    public override void Put(int key, int value)
    {
        if (nodes.TryGetValue(key, out var node)) { node.Value = (key, value); order.Remove(node); order.AddFirst(node); return; }
        if (nodes.Count == capacity) { nodes.Remove(order.Last!.Value.Key); order.RemoveLast(); }
        nodes[key] = order.AddFirst((key, value));
    }
}
