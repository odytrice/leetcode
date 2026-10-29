
/** O(n) time, O(1) space. Points each node at the previous one. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode reverseList(ListNode head) {
        // previous is the head of the part already reversed.
        ListNode previous = null;
        while (head != null) {
            // Save the rest of the list before the link is flipped.
            ListNode following = head.next;
            head.next = previous;
            previous = head;
            head = following;
        }
        return previous;
    }
}
