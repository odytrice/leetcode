public class ReferenceSolution : Solution
{
    public override ListNode MiddleNode(ListNode head)
    {
        var slow = head; ListNode? fast = head;
        while (fast?.next != null) { slow = slow.next!; fast = fast.next.next; }
        return slow;
    }
}
