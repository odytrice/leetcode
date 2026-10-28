
/** O(n) time, O(1) space. Splits at the middle, reverses the tail, then merges. */
class ReferenceSolution extends Solution {
    @Override
    public void reorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode right = slow.next;
        slow.next = null;
        ListNode reversedTail = null;
        while (right != null) {
            ListNode following = right.next;
            right.next = reversedTail;
            reversedTail = right;
            right = following;
        }

        ListNode left = head;
        while (reversedTail != null) {
            ListNode nextLeft = left.next;
            ListNode nextRight = reversedTail.next;
            left.next = reversedTail;
            reversedTail.next = nextLeft;
            left = nextLeft;
            reversedTail = nextRight;
        }
    }
}
