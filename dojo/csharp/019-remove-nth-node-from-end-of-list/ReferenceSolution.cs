public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. A lead of n + 1 nodes leaves slow just before the target.
    public override ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        // The dummy node lets the head itself be removed without a special case.
        var dummy = new ListNode(0, head);
        ListNode? fast = dummy;
        var slow = dummy;
        // Move fast n + 1 steps ahead; the gap then stays fixed as both move.
        for (int i = 0; i <= n; i += 1)
        {
            fast = fast!.next;
        }
        // When fast falls off the end, slow sits just before the node to remove.
        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next!;
        }
        // Unlink the target by skipping over it.
        slow.next = slow.next!.next;
        return dummy.next;
    }
}
