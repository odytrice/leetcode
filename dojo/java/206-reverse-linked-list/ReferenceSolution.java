
/** O(n) time, O(1) space. Points each node at the previous one. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode reverseList(ListNode head) {
        ListNode previous = null;
        while (head != null) {
            ListNode following = head.next;
            head.next = previous;
            previous = head;
            head = following;
        }
        return previous;
    }
}
