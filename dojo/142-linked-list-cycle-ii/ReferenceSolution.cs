public class ReferenceSolution : Solution
{
    public override ListNode? DetectCycle(ListNode? head)
    {
        var slow = head; var fast = head;
        while (fast?.next != null)
        {
            slow = slow!.next; fast = fast.next.next;
            if (!ReferenceEquals(slow, fast)) continue;
            slow = head;
            while (!ReferenceEquals(slow, fast)) { slow = slow!.next; fast = fast!.next; }
            return slow;
        }
        return null;
    }
}
