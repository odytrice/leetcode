import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(n) time, O(1) space. After the meeting, walk from the head and the meeting point.
    def detect_cycle(self, head: ListNode | None) -> ListNode | None:
        slow = fast = head
        while fast is not None and fast.next is not None:
            slow = slow.next  # type: ignore[assignment]
            fast = fast.next.next
            if slow is not fast:
                continue
            slow = head
            while slow is not fast:
                slow = slow.next  # type: ignore[assignment]
                fast = fast.next  # type: ignore[assignment]
            return slow
        return None
