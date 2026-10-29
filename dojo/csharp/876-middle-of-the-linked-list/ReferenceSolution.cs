public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. When fast reaches the end, slow is halfway.
    public override ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        ListNode? fast = head;
        while (fast?.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next;
        }
        return slow;
    }
}
