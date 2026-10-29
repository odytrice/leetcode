public class ReferenceSolution : Solution
{
    // O(n) time and space. First copy every node, then wire up next and random.
    public override Node? CopyRandomList(Node? head)
    {
        var copies = new Dictionary<Node, Node>();
        // Pass 1: make a copy of every node so each one can be looked up later.
        for (var n = head; n != null; n = n.next)
        {
            copies[n] = new(n.val);
        }
        // Pass 2: point each copy at the copies of its original's next and random.
        for (var n = head; n != null; n = n.next)
        {
            copies[n].next = n.next == null ? null : copies[n.next];
            copies[n].random = n.random == null ? null : copies[n.random];
        }
        // An empty list has no copy.
        return head == null ? null : copies[head];
    }
}
