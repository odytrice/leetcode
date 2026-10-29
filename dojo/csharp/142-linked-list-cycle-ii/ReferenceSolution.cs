public class ReferenceSolution : Solution
{
    // O(n) time, O(1) space. Floyd's tortoise and hare.
    public override ListNode? DetectCycle(ListNode? head)
    {
        var slow = head;
        var fast = head;
        while (fast?.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
            if (!ReferenceEquals(slow, fast))
            {
                continue;
            }
            // From the meeting point and from the head, both reach the cycle start together.
            slow = head;
            while (!ReferenceEquals(slow, fast))
            {
                slow = slow!.next;
                fast = fast!.next;
            }
            return slow;
        }
        return null;
    }
}
