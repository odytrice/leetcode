
/** O(n) time, O(1) space. The fast pointer travels twice as far. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode middleNode(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        // When fast runs out of list, slow is halfway; an even length leaves it on the second middle.
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}
