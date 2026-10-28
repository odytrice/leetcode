
/** O(n) time, O(1) space. The fast pointer travels twice as far. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode middleNode(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}
