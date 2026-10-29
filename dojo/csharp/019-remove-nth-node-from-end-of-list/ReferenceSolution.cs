public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. A lead of n + 1 nodes leaves slow just before the target.
    public override ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        ListNode? fast = dummy;
        var slow = dummy;
        for (int i = 0; i <= n; i += 1)
        {
            fast = fast!.next;
        }
        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next!;
        }
        slow.next = slow.next!.next;
        return dummy.next;
    }
}
