public class ReferenceSolution : Solution
{
    public override Node? CopyRandomList(Node? head)
    {
        var copies = new Dictionary<Node, Node>();
        for (var n = head; n != null; n = n.next) copies[n] = new(n.val);
        for (var n = head; n != null; n = n.next)
        {
            copies[n].next = n.next == null ? null : copies[n.next];
            copies[n].random = n.random == null ? null : copies[n.random];
        }
        return head == null ? null : copies[head];
    }
}
