public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Point each node back at the one before it.
    public override ListNode? ReverseList(ListNode? head)
    {
        ListNode? previous = null;
        while (head != null)
        {
            var next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }
        return previous;
    }
}
