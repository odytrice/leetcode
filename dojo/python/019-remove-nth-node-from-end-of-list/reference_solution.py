import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(n) time, O(1) space. A lead of n nodes puts slow on the node before the target.
    def remove_nth_from_end(self, head: ListNode, n: int) -> ListNode | None:
        dummy = ListNode(0, head)
        fast: ListNode | None = dummy
        slow = dummy
        for _ in range(n + 1):
            fast = fast.next if fast is not None else None
        while fast is not None:
            fast = fast.next
            slow = slow.next  # type: ignore[assignment]
        slow.next = slow.next.next if slow.next is not None else None
        return dummy.next
