
/** O(n) time, O(1) space. Splits at the middle, reverses the tail, then merges. */
class ReferenceSolution extends Solution {
    @Override
    public void reorderList(ListNode head) {
        // Find the middle: slow stops at the end of the first half, which keeps the extra node.
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Cut the list in two, then reverse the second half in place.
        ListNode right = slow.next;
        slow.next = null;
        ListNode reversedTail = null;
        while (right != null) {
            ListNode following = right.next;
            right.next = reversedTail;
            reversedTail = right;
            right = following;
        }

        // Weave the halves together, one node from each in turn.
        ListNode left = head;
        while (reversedTail != null) {
            // Save both next nodes before relinking, or the rest of each half is lost.
            ListNode nextLeft = left.next;
            ListNode nextRight = reversedTail.next;
            left.next = reversedTail;
            reversedTail.next = nextLeft;
            left = nextLeft;
            reversedTail = nextRight;
        }
    }
}
