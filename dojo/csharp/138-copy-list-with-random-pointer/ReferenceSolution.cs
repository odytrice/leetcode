public class ReferenceSolution : Solution
{
    // O(n) time and space. First copy every node, then wire up next and random.
    public override Node? CopyRandomList(Node? head)
    {
        var copies = new Dictionary<Node, Node>();
        for (var n = head; n != null; n = n.next)
        {
            copies[n] = new(n.val);
        }
        for (var n = head; n != null; n = n.next)
        {
            copies[n].next = n.next == null ? null : copies[n.next];
            copies[n].random = n.random == null ? null : copies[n.random];
        }
        return head == null ? null : copies[head];
    }
}
