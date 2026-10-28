public class ReferenceSolution : Solution
{
    public override void ReorderList(ListNode head)
    {
        var slow = head; var fast = head;
        while (fast.next?.next != null) { slow = slow.next!; fast = fast.next.next; }
        ListNode? right = slow.next, reversed = null;
        slow.next = null;
        while (right != null) { var next = right.next; right.next = reversed; reversed = right; right = next; }
        var left = head;
        while (reversed != null)
        {
            var nextLeft = left.next; var nextRight = reversed.next;
            left.next = reversed; reversed.next = nextLeft;
            left = nextLeft!; reversed = nextRight;
        }
    }
}
