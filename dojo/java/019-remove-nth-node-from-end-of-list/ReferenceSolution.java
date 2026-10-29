
/** O(n) time, O(1) space. A lead of n nodes puts slow on the node before the target. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode removeNthFromEnd(ListNode head, int n) {
        // The dummy gives slow a node to stand on when the head itself is removed.
        ListNode dummy = new ListNode(0, head);
        ListNode fast = dummy;
        ListNode slow = dummy;
        // Open a gap of n + 1 nodes between fast and slow.
        for (int step = 0; step <= n; step += 1) {
            fast = fast.next;
        }
        // When fast falls off the end, slow is just before the node to remove.
        while (fast != null) {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}
