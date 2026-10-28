
/** O(n) time, O(1) space. After the meeting, walks from the head and the meeting point. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode detectCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow != fast) {
                continue;
            }
            slow = head;
            while (slow != fast) {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
        return null;
    }
}
