
/** O(max(m, n)) time. Adds column by column with a carry. */
class ReferenceSolution extends Solution {
    @Override
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        ListNode first = l1;
        ListNode second = l2;
        int carry = 0;
        while (first != null || second != null || carry != 0) {
            int total = (first == null ? 0 : first.val) + (second == null ? 0 : second.val) + carry;
            tail.next = new ListNode(total % 10);
            tail = tail.next;
            carry = total / 10;
            first = first == null ? null : first.next;
            second = second == null ? null : second.next;
        }
        return dummy.next;
    }
}
