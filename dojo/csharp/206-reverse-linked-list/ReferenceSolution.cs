public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Point each node back at the one before it.
    public override ListNode? ReverseList(ListNode? head)
    {
        ListNode? previous = null;
        while (head != null)
        {
            // Save the rest of the list before the link is overwritten.
            var next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }
        // previous ends on the old tail, which is the new head.
        return previous;
    }
}
