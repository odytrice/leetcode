public class ReferenceSolution : Solution
{
    // O(max(m, n)) time. Add digit by digit, carrying into the next column.
    public override ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // A dummy head avoids a special case for the first digit.
        var dummy = new ListNode();
        var tail = dummy;
        ListNode? a = l1;
        ListNode? b = l2;
        int carry = 0;
        // Keep going while either list has digits or a carry is still pending.
        while (a != null || b != null || carry != 0)
        {
            // A missing node counts as 0, so lists of different lengths still line up.
            int sum = (a?.val ?? 0) + (b?.val ?? 0) + carry;
            tail.next = new(sum % 10);
            tail = tail.next;
            carry = sum / 10;
            a = a?.next;
            b = b?.next;
        }
        return dummy.next!;
    }
}
