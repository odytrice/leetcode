public class ReferenceSolution : Solution
{
    public override ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        ListNode? fast = dummy; var slow = dummy;
        for (int i = 0; i <= n; i++) fast = fast!.next;
        while (fast != null) { fast = fast.next; slow = slow.next!; }
        slow.next = slow.next!.next;
        return dummy.next;
    }
}
