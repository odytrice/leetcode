
/** O(n) time, O(1) space. After the meeting, walks from the head and the meeting point. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode detectCycle(ListNode head) {
        // Phase 1: fast moves two steps per slow step; they only meet if there is a cycle.
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow != fast) {
                continue;
            }
            // Phase 2: the head and the meeting point are the same distance from the cycle start.
            slow = head;
            while (slow != fast) {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
        // fast reached the end of the list, so there is no cycle.
        return null;
    }
}
