public class ReferenceSolution : Solution
{
    public override ListNode? ReverseList(ListNode? head)
    {
        ListNode? previous = null;
        while (head != null) { var next = head.next; head.next = previous; previous = head; head = next; }
        return previous;
    }
}
