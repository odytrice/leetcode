public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Split at the middle, reverse the back half, then interleave.
    public override void ReorderList(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast.next?.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next;
        }

        // Detach and reverse the second half.
        ListNode? right = slow.next;
        ListNode? reversed = null;
        slow.next = null;
        while (right != null)
        {
            var next = right.next;
            right.next = reversed;
            reversed = right;
            right = next;
        }

        // Weave one node from the back half after each node of the front half.
        var left = head;
        while (reversed != null)
        {
            var nextLeft = left.next;
            var nextRight = reversed.next;
            left.next = reversed;
            reversed.next = nextLeft;
            left = nextLeft!;
            reversed = nextRight;
        }
    }
}
