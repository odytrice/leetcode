import sys
from pathlib import Path

sys.path.append(str(Path(__file__).resolve().parent.parent))

from shared import ListNode


class ReferenceSolution:
    # O(n) time, O(1) space. The fast pointer travels twice as far.
    def middle_node(self, head: ListNode) -> ListNode:
        slow = fast = head
        while fast is not None and fast.next is not None:
            slow = slow.next  # type: ignore[assignment]
            fast = fast.next.next
        return slow
